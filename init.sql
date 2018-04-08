--drop database project;
--create database project;

--drop tables
drop table actor_rating;
drop table movie_rating;
drop table starred;
drop table actor;
drop table [queue];
drop table [order];
drop table movie;
drop table employee;
drop table customer;

--drop functions / stored procedures
drop function limit_score;
drop function can_order;
drop proc calc_cust_rating;
drop proc make_order;
drop proc fill_orders;

create table customer (
	cid int not null primary key identity,
	first_name text not null,
	last_name text not null,
	suite_number text,
	street_number text,
	house_number text,
	city text,
	province text,
	phone_number char(10) check(phone_number is null or (phone_number not like '%[^0-9]%')),
	postalcode char(6) check(postalcode is null or (len(postalcode) = 6 and postalcode like '[a-zA-Z][0-9][a-zA-Z][0-9][a-zA-Z][0-9]')),
	email varchar(320) check(email is null or (email like '_%@_%._%')),
	account_type varchar(10) not null check (account_type IN ('Disabled', 'Limited', 'Bronze', 'Silver', 'Gold')),
	creation_date date not null check(creation_date <= getdate()),
	credit_card text, --doesn't always have 16 digits
	rating int check(0 <= rating and rating <= 5) default 0 not null,
	username varchar(64) not null unique,
	passhash text not null,
);

create table employee (
	eid int not null primary key identity,
	position varchar(10) not null check(position IN ('employee', 'manager')),
	first_name text not null,
	last_name text not null,
	suite_number text,
	street_number text,
	house_number text,
	city text,
	province text,
	phone_number char(10) check(phone_number is null or (phone_number not like '%[^0-9]%')),
	postalcode char(6) check(postalcode is null or (len(postalcode) = 6 and postalcode like '[a-zA-Z][0-9][a-zA-Z][0-9][a-zA-Z][0-9]')),
	start date not null,
	wage float not null check(wage > 0),
	social_insurance_num char(9) check(social_insurance_num is null or (len(social_insurance_num) = 9 and isnumeric(social_insurance_num) = 1)),
	username varchar(64) not null unique,
	passhash text not null,
);

create table movie (
	mid int not null primary key identity,
	name text not null,
	genre text,
	fees float not null,
	num_copies int not null,
	copies_available int not null,
	rating int check(1 <= rating and rating <= 5),
);

create table [order] (
	oid int not null primary key identity,
	mid int not null,
	cid int not null,
	eid int,
	order_placed datetime not null check(order_placed <= getdate()),
	date_returned datetime,
	foreign key (mid) references movie(mid),
	foreign key (cid) references customer(cid),
	foreign key (eid) references employee(eid),
	constraint ck_date_returned
		check(date_returned is null or date_returned > order_placed)
);

create table [queue] (
	cid int not null,
	mid int not null,
	date_added datetime not null check(date_added <= getdate()),
	primary key (cid, mid),
	foreign key (mid) references movie(mid),
	foreign key (cid) references customer(cid),
);

create table actor (
	aid int not null primary key identity,
	first_name text not null,
	last_name text,
	sex char check (sex is null or sex IN ('M', 'F')),
	dob date check(dob <= getdate()),
	age as datediff(hour, dob, getdate())/8766,
	rating int check(1 <= rating and rating <= 5),
);

create table starred (
	aid int not null,
	mid int not null,
	primary key (aid, mid),
	foreign key (aid) references actor(aid) ON DELETE CASCADE,
	foreign key (mid) references movie(mid) ON DELETE CASCADE,
);

create table movie_rating (
	mid int not null,
	cid int not null,
	rating int not null,
	primary key (mid, cid),
	foreign key (mid) references movie(mid) ON DELETE CASCADE,
	foreign key (cid) references customer(cid) ON DELETE CASCADE,
);

create table actor_rating (
	aid int not null,
	cid int not null,
	rating int not null,
	primary key (aid, cid),
	foreign key (aid) references actor(aid) ON DELETE CASCADE,
	foreign key (cid) references customer(cid) ON DELETE CASCADE,
);

go

-- functions
create function limit_score (@score float)
returns int
as
begin
	if @score < 1
		return 1;
	else if @score > 5
		return 5;
	return cast(@score as int);
end
go

create function can_order (@id int)
returns int
as
begin
	declare @account_type varchar(10);
	declare @cur_orders int;
	declare @num_orders int;
	declare @start_of_month datetime;

	select @start_of_month = dateadd(mm, datediff(mm, 0, getdate()), 0);

	select @cur_orders = count(*)
		from [order]
		where cid = @id and date_returned is null;

	select @account_type = account_type
		from customer
		where cid = @id;

	if @account_type like 'Limited'
	begin
		-- if no movies out and <= 1 this month

		if @cur_orders = 0
		begin
			--test num ordered this month
			select @num_orders = count(*)
				from [order]
				where cid = @id and order_placed >= @start_of_month;
			-- if <= 1
			if @num_orders <= 1
			begin
				return 1;
			end
		end
	end
	else if @account_type like 'Bronze'
	begin
		-- if no orders
		if @cur_orders = 0
		begin
			return 1;
		end
	end
	else if @account_type like 'Silver'
	begin
		-- if <= 1 order
		if @cur_orders <= 1
		begin
			return 1;
		end
	end
	else if @account_type like 'Gold'
	begin
		-- if <= 2 orders
		if @cur_orders <= 2
		begin
			return 1;
		end
	end
	return 0;
end
go

-- stored procedures
create proc calc_cust_rating
as
begin
	-- get users orders in the last month
	declare @temp table (cid int, order_count int)
	insert into @temp (cid, order_count)
		select cid, count(*) as order_count
			from [order]
			where datediff(mm, order_placed, getdate()) < 1
			group by cid;

	-- get average and standard deviation
	declare @avg float;
	declare @stdev float;
	select @avg = avg(order_count), @stdev = stdev(order_count)
		from @temp as cust_orders;

	-- deal with stdev == 0
	if @stdev = 0
		set @stdev = 0.0001;

	-- update all scores
	-- need to deal with outliers
	update customer set rating = dbo.limit_score((order_count - @avg) / @stdev + 3)
		from @temp as t
		where customer.cid = t.cid;

	-- set all other customers to have a rating of 0
	update customer set rating = 0
		where customer.cid not in (select cid from @temp);
end;
go

create proc make_order (@id int)
as
begin
	declare @mid int;
	set @mid = null;

	declare @temp table (mid int, date_added date);
	declare @cur_orders table (mid int);

	-- get bottom 4 from queue that have copies available
	insert into @temp (mid, date_added)
		select top 4 mid, date_added
			from (select q.mid, q.date_added 
					from [queue] as q, movie as m
					where q.cid = @id and q.mid = m.mid and m.copies_available > 0) as t
			order by date_added desc;

	-- get list of current orders
	insert into @cur_orders (mid)
		select mid from [order]
			where cid = @id and date_returned is null;

	-- get mid
	while exists (select * from @temp)
	begin
		select top 1 @mid = mid
			from @temp order by date_added;

		if @mid not in (select mid from @cur_orders)
		begin
			-- make order
			insert [order] (cid, mid, order_placed)
				values (@id, @mid, getdate());
			-- remove from queue
			delete from [queue] where cid = @id and mid = @mid;
			-- update copies available
			update movie
				set copies_available = copies_available -1
				where mid = @mid;
			-- return
			return
		end
		-- remove mid from @temp
		delete from @temp where mid = @mid;
	end
end
go

create proc fill_orders
as
begin
	--for each cid
	declare @temp table (cid int, size int);
	declare @id int;
	declare @size int;

	insert into @temp (cid, size)
		select cid, count(*)
			from [queue]
			group by cid;

	--while can make order on cid and non empty queue
	while exists (select * from @temp)
	begin
		select top 1 @id = cid, @size = size from @temp
		-- if can create order and size > 0
		if dbo.can_order(@id) = 1 and @size > 0
		begin
			-- make order
			exec dbo.make_order @id;
			-- decrement size
			update @temp
				set size = @size - 1
				where cid = @id;
		end
		else
		begin
			-- delete from table
			delete from @temp
				where cid = @id;
		end
	end
end
go

-- triggers
create trigger cust_create_order_from_queue_trigger
on [queue]
after insert
as
begin
	declare @temp table (cid int);
	declare @id int;

	insert into @temp (cid)
		select cid
			from inserted;
	while exists (select * from @temp)
	begin
		select top 1 @id = cid from @temp;

		-- check id if can add another order
		if dbo.can_order(@id) = 1
		begin
			-- if true create order
			exec dbo.make_order @id;
		end

		delete top (1) from @temp
			where cid = @id;
	end
end
go

create trigger cust_create_order_from_order_trigger
on [order]
after update
as
begin
	declare @temp table (cid int);
	declare @id int;

	insert into @temp (cid)
		select cid
			from inserted;
	while exists (select * from @temp)
	begin
		select top 1 @id = cid from @temp;
		
		-- check id if can add another order
		if dbo.can_order(@id) = 1
		begin
			-- if true create order
			exec dbo.make_order @id;
		end

		delete top (1) from @temp
			where cid = @id;
	end
end
go

create trigger cust_postal_code_upper_trigger
on customer
after insert, update
as
begin
	update customer
		set postalcode = upper(postalcode)
		where customer.cid in (select cid from inserted);
end
go

create trigger cust_email_lower_trigger
on customer
after insert, update
as
begin
	if trigger_nestlevel() > 1
	begin
		return
	end
	update customer
		set email = lower(email)
		where customer.cid in (select cid from inserted);
end
go


create trigger movie_rating_trigger
on movie_rating
after insert, delete, update
as
begin
	update movie
		set rating = (select avg(rating) from movie_rating where mid = movie.mid) -- test
		where movie.mid in (select mid from inserted) or movie.mid in (select mid from deleted);
end;
go

create trigger actor_rating_trigger
on actor_rating
after insert, delete
as
begin
	update actor
		set rating = (select avg(rating) from actor_rating where aid = actor.aid) -- test
		where actor.aid in (select aid from inserted) or actor.aid in (select aid from deleted)
end;
go

-- needs more testing
-- if returned increment counter
create trigger movie_available_on_return_trigger
on [order]
after update
as
begin
	declare @temp table (mid int);
	-- check if return
	insert into @temp
		select mid
			from inserted
			where date_returned is not null;
	-- increment counter
	update movie
		set copies_available = copies_available + 1
		where mid in (select mid from @temp);
end
go


insert into employee (position, first_name, last_name, [start], wage, username, passhash)
values ('manager', 'admin', 'admin', getdate(), 1, 'admin', 'pass');

insert into customer (first_name, last_name, account_type, creation_date, username, passhash)
values ('admin', 'admin', 'Gold', getdate(), 'admin', 'pass');

insert into movie ([name], genre, fees, num_copies, copies_available)
values ('ThisMovie', 'space', '12', '22', '2');

insert into movie_rating (mid, cid, rating)
values ('1','1','5');

insert into actor (first_name, last_name, sex, dob)
values ('Evan', 'Test', 'M', getdate());

insert into starred (mid, aid)
values (1, 1)

select * from employee;
select * from customer;