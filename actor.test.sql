
declare @aid1 int;
declare @cid1 int;
declare @cid2 int;

--birthday is a day behind. Not sure why.
/*
insert into actor (first_name, last_name, dob)
	values ('Jason', 'Statham','2000-02-27');
insert into customer (first_name, last_name, account_type, creation_date)
	values ('first', 'rating', 'test', getdate());
insert into customer (first_name, last_name, account_type, creation_date)
	values ('second', 'rating', 'test', getdate());

select @cid1 = cid from customer where first_name like 'first';
select @cid2 = cid from customer where first_name like 'second';
select @aid1 = aid from actor where first_name like 'Jason';
--*/
/********************************
 * test Sex Contraint
 ********************************/
/*
UPDATE actor 
Set dob = '2000-02-25', sex = 'M'
WHERE first_name like 'Jason'
and last_name like 'Statham'
select * from actor;

DELETE FROM actor
where first_name like'Jason';
select * from actor;
--*/

/********************************
 * test age Constraint --cannot modify age it should be calculated from dob
 ********************************/
/*
UPDATE actor
SET age = 11
WHERE first_name like 'Jason';
--*/


/********************************
 * test actor rating.
 ********************************/
/*



insert into actor_rating (aid, cid, rating)
	values (
		@aid1,
		@cid1,
		1
	);
		
insert into actor_rating (aid, cid, rating)
	values (
		@aid1,
		@cid2,
		5
	);

select * from actor;

delete from actor_rating 
where aid = @aid1;

delete from actor;
delete from customer;
--*/