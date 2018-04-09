declare @mid1 int;
declare @mid2 int;
declare @mid3 int;
declare @mid4 int;
declare @mid5 int;
declare @mid6 int;

declare @cid1 int;
declare @cid2 int;
declare @cid3 int;
declare @cid4 int;

declare @aid1 int;
declare @aid2 int;
declare @aid3 int;

-- create customer
insert into customer (first_name, last_name, account_type, creation_date, username, passhash)
	values ('Mark', 'Daddy', 'Bronze', getdate(), 'Daddy', 'bbQckId+cip5EYWwstAUf/SUI8k=');--yesyesyes

insert into customer (first_name, last_name, account_type, creation_date, username, passhash)
	values ('Gragam', 'John', 'Silver', getdate(), 'gorgram', '0BXMRlvbTlGYfff7hwRy0/uaNQU=');--secure

insert into customer (first_name, last_name, account_type, creation_date, username, passhash)
	values ('Tommy', 'Wiseau', 'Gold', getdate(), 'tommy', '8bvD33MV0ic2EgKIXVjVPPnCIDo=');--ohHiMahk

insert into customer (first_name, last_name, account_type, creation_date, username, passhash)
	values ('Jim', 'Rob', 'Limited', getdate(), 'myusername1', 'password');

select @cid1 = cid from customer where username like 'Daddy';
select @cid2 = cid from customer where username like 'gorgram';
select @cid3 = cid from customer where username like 'tommy';
select @cid4 = cid from customer where username like 'myusername1';

-- create movie
insert into movie (name, fees, num_copies, copies_available, genre)
	values ('59.59 seconds', 59.59, 60, 30, 'Action');

insert into movie (name, fees, num_copies, copies_available, genre)
	values ('Speed', 50, 50, 50, 'Action');

insert into movie (name, fees, num_copies, copies_available, genre)
	values ('Back to the Future', 1985, 88, 88, 'Action');

insert into movie (name, fees, num_copies, copies_available, genre)
	values ('The Room', 1900, 10, 10, 'Drama');

insert into movie ([name], genre, fees, num_copies, copies_available)
	values ('ThisMovie', 'Comedy', '12', '22', '2');

insert into movie ([name], genre, fees, num_copies, copies_available)
	values ('SpaceJam', 'Drama', '12', '22', '2');


select @mid1 = mid from movie where name like '59.59 seconds';
select @mid2 = mid from movie where name like 'Speed';
select @mid3 = mid from movie where name like 'Back to the Future';
select @mid4 = mid from movie where name like 'The Room';
select @mid5 = mid from movie where name like 'ThisMovie';
select @mid6 = mid from movie where name like 'SpaceJam';

-- add actors
insert into actor (first_name, last_name, sex, dob)
	values ('Lucy', 'Lu', 'F', getdate());

insert into actor (first_name, last_name, sex, dob)
	values ('Arnald', 'steroids', 'M', getdate());

insert into actor (first_name, last_name, sex, dob)
	values ('Evanina', 'test', 'F', getdate());

select @aid1 = aid from actor where first_name like 'Lucy';
select @aid2 = aid from actor where first_name like 'Arnald';
select @aid3 = aid from actor where first_name like 'Evanina';

-- add starred
insert into starred (mid, aid)
	values (@mid5, @aid1)

insert into starred (mid, aid)
	values (@mid5, @aid2)

insert into starred (mid, aid)
	values (@mid6, @aid3)

-- add to queue
insert into [queue] (mid, cid, date_added)
	values (@mid1, @cid1, getdate());

insert into [queue] (mid, cid, date_added)
	values (@mid4, @cid1, getdate());

insert into [queue] (mid, cid, date_added)
	values (@mid2, @cid2, getdate());

insert into [queue] (mid, cid, date_added)
	values (@mid3, @cid2, getdate());

insert into [queue] (mid, cid, date_added)
	values (@mid4, @cid3, getdate());

insert into [queue] (mid, cid, date_added)
	values (@mid1, @cid4, getdate());

insert into [queue] (mid, cid, date_added)
	values (@mid2, @cid4, getdate());

insert into [queue] (mid, cid, date_added)
	values (@mid3, @cid4, getdate());

insert into [queue] (mid, cid, date_added)
	values (@mid4, @cid4, getdate());

-- check orders
select * from [queue];
select * from [order];

-- return order
update [order]
	set eid = 1, date_returned = getdate()
	where cid = @cid1 and mid = @mid1;

-- check orders again
select * from [queue];
select * from [order];

-- check actors
select * from starred;

-- test order report
declare @from datetime;
set @from = dateadd(mm, datediff(mm, 0, getdate()), 0);
declare @to datetime;
set @to = getdate();
declare @genre varchar(10);
set @genre = 'Action';

select m.name, m.genre, c.mid, c.count from (select mid, count(*) as count from [order] where order_placed between @from and @to group by mid) as c, movie as m where c.mid = m.mid;
SELECT m.name, m.genre, c.mid, c.count
                FROM (SELECT mid, COUNT(*) as count FROM [order] WHERE order_placed BETWEEN @from AND @to GROUP BY mid) AS c, movie AS m
                WHERE c.mid = m.mid AND m.genre LIKE @genre;

-- test fill_orders
exec dbo.fill_orders;