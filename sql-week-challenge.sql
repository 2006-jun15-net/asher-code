create table CustomerX
(
	ID INT IDENTITY(1, 1) NOT NULL, 
	FirstName  NVARCHAR(200) NOT NULL, 
	LastName   NVARCHAR(200) NOT NULL,
	Cardnumber INT NOT NULL
	Primary key(ID)
);

create table ProductX
(
	ID INT IDENTITY(1,1) NOT NULL,
	Name NVARCHAR(200) NOT NULL,
	Price DECIMAL(10,2) NOT NULL
	Primary key(ID)
);

CREATE TABLE OrdersX
(
	ID INT IDENTITY(1, 1) NOT NULL,
	ProductID INT FOREIGN KEY REFERENCES ProductX(ID) ON DELETE CASCADE ON UPDATE CASCADE,
	CustomerID INT FOREIGN KEY REFERENCES CustomerX(ID) ON DELETE CASCADE ON UPDATE CASCADE
	Primary key(ID)
);

Insert into CustomerX (FirstName, LastName, CardNumber) values
('Fred', 'Wilcox', 624735),
('Billy', 'Rand', 702854),
('Claire', 'Green', 624735);

insert into ProductX (Name, Price) values
('PC Monitor', 300.00),
('Neon Keyboard', 85.00),
('Samsung Earbuds', 25.00);

insert into OrdersX (CustomerID, ProductID) values
(4, 3),
(4, 1),
(2, 3);

insert into ProductX (Name, Price) values
('iPhone', 200.00);
insert into CustomerX (FirstName, LastName, CardNumber) values
('Tina', 'Smith', 624624);
insert into OrdersX (CustomerID, ProductID) values
(5, 4),
(3, 4);

select * from OrdersX
where CustomerID = 5;

select sum(p.Price) as Revenue from ProductX as p
left join OrdersX on OrdersX.ProductID = p.ID
where p.ID = 4;

update ProductX
set Price = 250.00
where Name = 'iPhone';