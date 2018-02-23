-- test actor dob
/*
insert into actor (first_name, dob)
	values ('test2', '1968-02-21');

select * from actor;
*/

-- test customer account creation date
/*
insert into customer (first_name, last_name, account_type, creation_date)
	values ('first', 'second', 'limited', getdate());

select * from customer;
*/

-- test movie rating trigger
/*
insert into customer (first_name, last_name, account_type, creation_date)
	values ('first', 'second', 'limited', getdate());

insert into movie (name, fees, num_copies, copies_available)
	values ('59.59 seconds', 59.59, 60, 1);

insert into movie_rating (mid, cid, rating)
	values (1, 1, 5);

select * from movie;
*/

-- test actor rating trigger
/*
insert into customer (first_name, last_name, account_type, creation_date)
	values ('second', 'last', 'all the movies', getdate());

insert into actor (first_name)
	values ('that actor');

insert into actor_rating (aid, cid, rating)
	values (1, 1, 5);

select * from actor;
*/

-- test customer rating trigger
/*
insert into customer (first_name, last_name, account_type, creation_date)
	values ('third', 'last_name', 'type', getdate());

insert into movie (name, fees, num_copies, copies_available)
	values ('the avenger', 1000000000, 1000, 0);

insert into [order] (mid, cid, order_placed)
	values (1, 1, getdate());

select * from customer;
*/

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
*/

-- test customer email validating
--/*
--valid
insert into customer (first_name, last_name, account_type, creation_date, email)
	values ('email', 'validating', 'test', getdate(), 'local@domain.tld');
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