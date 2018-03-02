
declare @mid1 int;
declare @cid1 int;
declare @cid2 int;
/*************************** 
 * test movie rating trigger
 ***************************/
insert into customer (first_name, last_name, account_type, creation_date)
	values ('first', 'second', 'limited', getdate());

insert into customer (first_name, last_name, account_type, creation_date)
	values ('first2', 'second', 'limited', getdate());

insert into movie (name, fees, num_copies, copies_available)
	values ('59.59 seconds', 59.59, 60, 1);

-- assign variables
select @cid1 = cid from customer where first_name like 'first';
select @cid2 = cid from customer where first_name like 'first2';
select @mid1 = mid from movie where name like '59.59 seconds';

insert into movie_rating (mid, cid, rating)
	values (@mid1, @cid1, 5);

insert into movie_rating (mid, cid, rating)
	values (@mid1, @cid2, 1);

-- test
select * from movie;

delete movie_rating 
where cid = @cid2;

select * from movie;

-- cleanup
delete from movie_rating;
delete from customer;
delete from movie;


/*************************** 
 * test movie trigger deleating
 ***************************/


