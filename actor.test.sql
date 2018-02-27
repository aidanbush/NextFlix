
--birthday is a day behind.
/*
insert into actor (first_name, last_name, dob)
	values ('Jason', 'Statham','2000-02-27');
select * from actor;

--Sex should be either M or G
UPDATE actor 
Set dob = '2000-02-25', sex = 'M'
WHERE first_name like 'Jason'
and last_name like 'Statham'
select * from actor;

DELETE FROM actor
where first_name like'Jason';
select * from actor;
--*/

--cannot modify age it should be calculated from dob
/*
UPDATE actor
SET age = 11
WHERE first_name like 'Jason';
--*/