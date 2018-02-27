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
drop proc calc_cust_rating;

create table customer (
	cid int not null primary key identity,
	first_name text not null,
	last_name text not null,
	suite_number text,
	street_number text,
	house_number text,
	city text,
	province text,
	phone_number char(10) check(phone_number not like '%[^0-9]%'),
	postalcode char(6) check(len(postalcode) = 6 and postalcode like '[a-zA-Z][0-9][a-zA-Z][0-9][a-zA-Z][0-9]'),
	email varchar(320) check(email like '_%@_%._%'),
	account_type text not null, -- add constraint
	creation_date date not null check(creation_date <= getdate()),
	credit_card text,
	rating int check(0 <= rating and rating <= 5) default 0 not null,
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
	phone_number char(10) check(phone_number not like '%[^0-9]%'),
	postalcode char(6) check(len(postalcode) = 6 and postalcode like '[a-zA-Z][0-9][a-zA-Z][0-9][a-zA-Z][0-9]'),
	start date not null,
	wage float not null check(wage > 0),
	social_insurance_num char(9) check(len(social_insurance_num) = 6 and isnumeric(social_insurance_num) = 1),
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