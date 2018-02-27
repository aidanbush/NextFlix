--Not Null inserts
insert into employee (position, first_name, last_name, [start], wage)
values ('front', 'dan', 'dan', '1968-02-21', 48.06);

UPDATE employee
Set suite_number = '35', street_number = '55', house_number = '2', city = 'Edmonton',  province = 'AB'
where first_name like 'dan'

UPDATE employee
Set postalcode = 'T8A3M4'
where first_name like 'dan'

select * from employee;
DELETE FROM employee;
