---Database Creation----
create database AssignmentTaskDB

----Customer Table Creation-----
use AssignmentTaskDB

create table Customers(
Customerid char(5) not null,
CompanyName varchar(40) not null,
contactName char(30) null,
Address varchar(60) null,
City char(15) null,
Phone char(24) null,
Fax char(24) null
)

----Orders Table Creation------
create table Orders(
OrderId integer not null,
customerId char(5) not null,
Orderdate datetime null,
Shippeddate datetime null,
Freight money null,
Shipname varchar(40) null,
Shipaddres varchar(60) null,
Quantity integer null
)
---add column----
ALTER table Orders ADD Shipregion int null
select * from Orders
--Modify Column----
ALTER table Orders ALTER COLUMN Shipregion char(5)

----Delete Column----
ALTER table Orders DROP COLUMN Shipregion
select * from Orders

---inserting new row values into table
insert into Orders values (10, 'ord01', getdate(), getdate(), 100.0, 'Windstar', 'Ocean' ,1)

---Adding constraint to table-----
ALTER table Orders
ADD CONSTRAINT df_Orderdate
DEFAULT getdate() for Orderdate

---Renaming the old column name to new one---
EXEC sp_RENAME 'Customers.City', 'Town', 'COLUMN';
select * from Customers;

---------Department table-----------
create table Department(
Dept_no	varchar(5) primary key not null,
Dept_name char(20) not null,	
location char(10) not null 
)
-----Insert data into table--------
insert into Department values('d1',	'Research',	'Dallas'),('d2','Accounting','Seattle'),('d3',	'Marketing'	,'Dallas')
select * from Department

 ------Employee table----------
create table Employee(emp_no varchar(5) primary key,
emp_fname char(10) not null,
emp_lname char(10) not null,	
Dept_no varchar(5)
)
---------insert employee data-----
insert into Employee values('25348','Matthew','Smith','d3'),('10102','Ann','Jones','d3'),('18316','John','Barrimore','d1'),('29346','James','James','d2')
select * from Employee

------Project table---------
create table Project(project_no	varchar(5) primary key,
project_name char(20) not null,
Budget int not null)

-----Inserting data into table---------
insert into Project values('p1','Apollo',120000),('p2','Gemini',95000),('p3','Mercury',185600)
Select * from Project
---------Work Table------------
create table Works_on(emp_no varchar(5) not null,
project_no varchar(5)not null,
Job char(10) null,
enter_date date not null
)
--------inserting data into table----------
insert into Works_on values('10102','p1','Analyst','10.1.1997'),('10102','p3','manager','1.1.1999'),('25348','p2','Clerk','2.15.1998')
insert into Works_on (emp_no,project_no,enter_date)values('18316','p2','6.1.1998'),('29346','p2','12.15.1997')
insert into Works_on values('2581','p3','Analyst','10.15.1998'),('9031','p1','Manager','4.15.1998')
insert into Works_on (emp_no,project_no,enter_date)values('28559','p1','1.8.1998')
insert into Works_on values('28559','p2','Clerk','1.2.1992'),('9031','p3','Clerk','11.15.1997'),('29346','p1','Clerk','1.4.1998')

------------------------------------------------QUERIES------------------------------------------------

select * from Works_on

select emp_no from Works_on where job='Clerk'

select emp_no from Works_on where emp_no<10000 AND project_no='p1'

select emp_no from Works_on where year(enter_date)='1998'

select emp_no from Works_on where Job='Analyst' OR Job='Manager' AND project_no='p2'

select enter_date from Works_on where Job IS NUll AND project_no='p2'

select emp_no,emp_lname from Employee where emp_fname LIKE '%t%'

select emp_no,emp_fname from Employee where emp_lname LIKE '_o%es' OR emp_lname LIKE '_a%es'

select emp_no from employee where dept_no in (select Dept_no from Department where location='Seattle')

select emp_lname,emp_fname from Employee where emp_no in(select emp_no from Works_on where enter_date='01.04.1998')

select count(dept_no) from department group by location

select MAX(emp_no) from Employee

select job from Works_on GROUP BY Job Having COUNT(*) >2;

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               