-- test actor dob
--/*
insert into actor (first_name, dob)
	values ('test2', '1968-02-21');

select * from actor;
delete from actor;
--*/

-- test customer account creation date
--/*
insert into customer (first_name, last_name, account_type, creation_date)
	values ('first', 'second', 'limited', getdate());

select * from customer;
delete from customer;
--*/

-- test movie rating trigger
/*
insert into customer (first_name, last_name, account_type, creation_date)
	values ('first', 'second', 'limited', getdate());

insert into movie (name, fees, num_copies, copies_available)
	values ('59.59 seconds', 59.59, 60, 1);

insert into movie_rating (mid, cid, rating)
	values (1, 1, 5);

select * from movie;
--*/

-- test actor rating trigger
/*
insert into customer (first_name, last_name, account_type, creation_date)
	values ('second', 'last', 'all the movies', getdate());

insert into actor (first_name)
	values ('that actor');

insert into actor_rating (aid, cid, rating)
	values (1, 1, 5);

select * from actor;
--*/

-- test customer rating trigger
/*
insert into customer (first_name, last_name, account_type, creation_date)
	values ('third', 'last_name', 'type', getdate());

insert into movie (name, fees, num_copies, copies_available)
	values ('the avenger', 1000000000, 1000, 0);

insert into [order] (mid, cid, order_placed)
	values (1, 1, getdate());

select * from customer;
--*/

-- test postal code constraint
/*
--valid
insert into customer (first_name, last_name, account_type, creation_date, postalcode)
	values ('postal', ' code', 'test', getdate(), 'A0Z9L5');
--invalid
--lowercase
insert into customer (first_name, last_name, account_type, creation_date, postalcode)
	values ('postal', ' code', 'test', getdate(), 'a0Z9L5');
--short
insert into customer (first_name, last_name, account_type, creation_date, postalcode)
	values ('postal', ' code', 'test', getdate(), 'A0Z9L');
--long
insert into customer (first_name, last_name, account_type, creation_date, postalcode)
	values ('postal', ' code', 'test', getdate(), 'A0Z9L5W');
--swaped order
insert into customer (first_name, last_name, account_type, creation_date, postalcode)
	values ('postal', ' code', 'test', getdate(), '3D9A0Z');
--validate
select * from customer;
--*/

-- test customer email validating
/*
--valid
--lowercase
insert into customer (first_name, last_name, account_type, creation_date, email)
	values ('email', 'validating', 'test', getdate(), 'local1@domain.tld');
--uppercase
insert into customer (first_name, last_name, account_type, creation_date, email)
	values ('email', 'validating', 'test', getdate(), 'LOCAL2@DOMAIN.TLD');
--invalid
--no local part
insert into customer (first_name, last_name, account_type, creation_date, email)
	values ('email', 'validating', 'test', getdate(), '@domain.tld');
insert into customer (first_name, last_name, account_type, creation_date, email)
	values ('email', 'validating', 'test', getdate(), 'domain.tld');
--no domain
insert into customer (first_name, last_name, account_type, creation_date, email)
	values ('email', 'validating', 'test', getdate(), 'local@.tld');
--no tld
insert into customer (first_name, last_name, account_type, creation_date, email)
	values ('email', 'validating', 'test', getdate(), 'local@domain.');
insert into customer (first_name, last_name, account_type, creation_date, email)
	values ('email', 'validating', 'test', getdate(), 'local@domain');
--nothing
insert into customer (first_name, last_name, account_type, creation_date, email)
	values ('email', 'validating', 'test', getdate(), 'localdomaintld');
--validate
select * from customer;
--*/

-- test customer rating
--/*
--setup
--create two customers
declare @mid1 int;
declare @cid1 int;
declare @cid2 int;
insert into customer (first_name, last_name, account_type, creation_date)
	values ('first', 'rating', 'test', getdate());
insert into customer (first_name, last_name, account_type, creation_date)
	values ('second', 'rating', 'test', getdate());
set @cid2 = @@IDENTITY;
insert into customer (first_name, last_name, account_type, creation_date)
	values ('no movies', 'rating', 'test', getdate());
set @mid1 = @@IDENTITY;
--create movie
insert into movie (name, fees, num_copies, copies_available)
	values ('rating test', 1.0, 10, 5);

--grab inserted identitys
select @cid1 = cid from customer where first_name like 'first';
select @cid2 = cid from customer where first_name like 'second';
select @mid1 = mid from movie where name like 'rating test';

--tests
--test middle value
insert into [order] (mid, cid, order_placed)
	values (@mid1, @cid1, getdate());
insert into [order] (mid, cid, order_placed)
	values (@mid1, @cid2, getdate());
exec calc_cust_rating;
select * from customer;
--test high / low value
insert into [order] (mid, cid, order_placed)
	values (@mid1, @cid1, getdate());
exec calc_cust_rating;
select * from customer;

delete from [order];
delete from movie;
delete from customer;
--*/