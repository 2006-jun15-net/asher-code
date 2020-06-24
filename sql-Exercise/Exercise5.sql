-- creating three tables: Department, exEmployee, EmpDetails
create table Department (
	ID int primary key,
	Name varchar(255),
	Location varchar(255)
)

create table exEmployee (
	ID int primary key,
	LastName varchar(255),
	FirstName varchar(255),
	SSN int not null check (SSN between 0 and 999999999),
	DeptID int foreign key references Department(ID)
)

create table EmpDetails (
	ID int primary key,
	EmployeeID int foreign key references exEmployee(ID),
	Salary decimal(10,2),
	Address1 varchar(255),
	Address2 varchar(255),
	City varchar(255),
	State varchar(255),
	Country varchar(255)
);

-- adding records into the table
insert into Department (ID, Name, Location) values
	(1, 'Accounting', 'Houston'),
	(2, 'Management', 'Dallas'),
	(3, 'Human Resources', 'Austin');
insert into exEmployee (ID, LastName, FirstName, SSN, DeptID) values
	(1, 'Beckett', 'Aaron', 462467247, 2),
	(2, 'Reed', 'Emily', 724672257, 1),
	(3, 'Fletcher', 'Christian', 791404681, 2);
insert into EmpDetails (ID, EmployeeID, Salary, Address1, Address2, City, State, Country) values
	(1, 1, 6145.34, '614 Grapevine Bl.', null, 'Dallas', 'Texas', 'USA'),
	(2, 2, 7256.56, '724 Central Dr.', null, 'Houston', 'Texas', 'USA'),
	(3, 3, 6246.79, '871 Main St.', null, 'Dallas', 'Texas', 'USA');

-- adding Employee Tina Smith
insert into exEmployee (ID, LastName, FirstName, SSN, DeptID) values
	(4, 'Smith', 'Tina', 926491649, 3)
insert into EmpDetails (ID, EmployeeID, Salary, Address1, Address2, City, State, Country) values
	(4, 4, 7246.23, '263 Grand Oak Dr.', null, 'Austin', 'Texas', 'USA');

-- add new department
insert into Department (ID, Name, Location) values
	(4, 'Marketing', 'San Antonio');

update exEmployee
set DeptID = 4
where ID = 4;
update EmpDetails
set City = 'San Antonio'
where EmployeeID = 4;

-- list all employee's from Marketing
select exEmployee.* from exEmployee
inner join Department on exEmployee.DeptID = Department.ID
where Department.Name = 'Marketing';

-- list the total salary from all employee's in Marketing
select sum(EmpDetails.Salary) as TotalSalary from EmpDetails
inner join exEmployee on EmpDetails.EmployeeID = exEmployee.ID
inner join Department on exEmployee.DeptID = Department.ID
where Department.Name = 'Marketing';

-- report total employees by Department
select Department.Name, count(exEmployee.DeptID) as TotalEmployees from exEmployee
inner join Department on exEmployee.DeptID = Department.ID
group by Department.Name;

update EmpDetails
set Salary = 90000
where EmployeeID = 4;