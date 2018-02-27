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
drop table employee_phone;
drop table employee;
drop table customer_phone;
drop table customer;

--drop functions
drop function calc_cust_rating;

--drop triggers
/*
drop trigger actor_rating_trigger;
drop trigger movie_rating_trigger;
drop trigger cust_rating_trigger;
drop trigger cust_email_lower_trigger;
drop trigger cust_postal_code_upper_trigger;
--*/

create table customer (
	cid int not null primary key identity,
	first_name text not null,
	last_name text not null,
	suite_number text,
	street_number text,
	house_number text,
	city text,
	province text,
	postalcode char(6),
	email varchar(320) check(email like '_%@_%._%'),
	account_type text not null, -- add constraint
	creation_date date not null check(creation_date <= getdate()),
	credit_card text,
	rating int check(1 <= rating and rating <= 5),
);

create table customer_phone (
	cid int not null,
	number char(10) not null check(number not like '%[^0-9]%'),
	[type] text not null,
	primary key (cid, number),
	foreign key (cid) references customer(cid),
);

create table employee (
	eid int not null primary key identity,
	position text not null,
	first_name text not null,
	last_name text not null,
	suite_number text,
	street_number text,
	house_number text,
	city text,
	province text,
	postalcode char(6),
	start date not null,
	wage float not null,
	social_insurance_num int,
);

create table employee_phone (
	eid int not null,
	number char(10) not null check(number not like '%[^0-9]%'),
	[type] text not null,
	primary key (eid, number),
	foreign key (eid) references employee(eid),
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
	order_placed date not null check(order_placed <= getdate()),
	foreign key (mid) references movie(mid),
	foreign key (cid) references customer(cid),
	foreign key (eid) references employee(eid),
);

create table [queue] (
	cid int not null,
	mid int not null,
	date_added date not null check(date_added <= getdate()),
	primary key (cid, mid),
	foreign key (mid) references movie(mid),
	foreign key (cid) references customer(cid),
);

create table actor (
	aid int not null primary key identity,
	first_name text not null,
	last_name text,
	sex char,
	CONSTRAINT sex CHECK (sex IN ('M', 'G')),
	dob date check(dob <= getdate()),
	age as datediff(hour, dob, getdate())/8766,
	rating int check(1 <= rating and rating <= 5),
);

create table starred (
	aid int not null,
	mid int not null,
	primary key (aid, mid),
	foreign key (aid) references actor(aid),
	foreign key (mid) references movie(mid),
);

create table movie_rating (
	mid int not null,
	cid int not null,
	rating int not null,
	primary key (mid, cid),
	foreign key (mid) references movie(mid),
	foreign key (cid) references customer(cid),
);

create table actor_rating (
	aid int not null,
	cid int not null,
	rating int not null,
	primary key (aid, cid),
	foreign key (aid) references actor(aid),
	foreign key (cid) references customer(cid),
);
go

--functions
create function calc_cust_rating (@cid int)
returns int
as
begin
	-- get users orders in last month
	declare @value int;
	select @value = count(*)
		from [order]
		where cid = @cid and datediff(mm, order_placed, getdate()) < 1;
		
	-- get average and standard deviation
	declare @avg float;
	declare @stdev float;
	select @avg = avg(order_count), @stdev = stdev(order_count) from
			(select count(*) as order_count, cid
			from [order]
			where datediff(mm, order_placed, getdate()) < 1
			group by cid) as cust_orders;
	
	-- calculate z-score and add 3 to get into range about +3
	declare @score float;
	set @score = (cast(@value as float) - cast(@avg as float) / @stdev) + 3;
	
	-- deal with outliers
	if @score < 1.0
		return 1;
	else if @score > 5.0
		return 5;

	return cast(round(@score, 0) as int);
end;
go

--triggers
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
	where customer.cid in (select cid from inserted)
end
go

-- need to test
create trigger cust_rating_trigger
on [order]
after insert
as
begin
	declare @rating int
	update customer
	set rating = @rating
	where customer.cid in (select cid from inserted)
	exec @rating = calc_cust_rating @cid = cid
end;
go

create trigger movie_rating_trigger
on movie_rating
after insert
as
begin
	update movie
	set rating = (select avg(rating) from movie_rating where mid = movie.mid) -- test
	where movie.mid in (select mid from inserted)
end;
go

create trigger actor_rating_trigger
on actor_rating
after insert
as
begin
	update actor
	set rating = (select avg(rating) from actor_rating where aid = actor.aid) -- test
	where actor.aid in (select aid from inserted)
end;