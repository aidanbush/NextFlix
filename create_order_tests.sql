declare @mid1 int;
declare @mid2 int;
declare @mid3 int;
declare @mid4 int;

declare @cid1 int;
declare @cid2 int;
declare @cid3 int;
declare @cid4 int;

--create customer
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

--create movie
insert into movie (name, fees, num_copies, copies_available)
	values ('59.59 seconds', 59.59, 60, 30);

insert into movie (name, fees, num_copies, copies_available)
	values ('Speed', 50, 50, 50);

insert into movie (name, fees, num_copies, copies_available)
	values ('Back to the Future', 1985, 88, 88);

insert into movie (name, fees, num_copies, copies_available)
	values ('The Room', 1900, 10, 10);

select @mid1 = mid from movie where name like '59.59 seconds';
select @mid2 = mid from movie where name like 'Speed';
select @mid3 = mid from movie where name like 'Back to the Future';
select @mid4 = mid from movie where name like 'The Room';

--add to queue
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

--check orders
select * from [queue];
select * from [order];

--remove order
update [order]
	set date_returned = getdate()
	where cid = @cid1 and mid = @mid1;

--check orders again
select * from [queue];
select * from [order];

--test fill_orders
exec dbo.fill_orders;

--clean up
delete from [order]
	where cid = @cid1 or cid = @cid2 or cid = @cid3 or cid = @cid4;

delete from [queue]
	where cid = @cid1 or cid = @cid2 or cid = @cid3 or cid = @cid4;

delete from movie
	where mid = @mid1 or mid = @mid2 or mid = @mid3 or mid = @mid4;

delete from customer
	where cid = @cid1 or cid = @cid2 or cid = @cid3 or cid = @cid4;