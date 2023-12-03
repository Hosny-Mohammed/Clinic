create table Admins(
	User_Name nvarchar(150) primary key not null,
	User_Password nvarchar(150) not null,
);
insert into Admins
values
('Hosny','Hosny'),
('Mohammed','123456');
select *from Admins
create table Pateints(
	ID int primary key IDENTITY(1,1) not null,
	Name nvarchar(150) not null,
	Address nvarchar(150) not null,
	age int,
	Date_ date not null default getdate(),
	Doc_Name nvarchar(150) not null
);
insert into Pateints
values
('Ibrahim','Geza',24,GETDATE(),'Aymem');
select * from Pateints
create table Users(
	User_Name nvarchar(150) primary key not null,
	User_Password nvarchar(150) not null,
);
insert into Users
values
('Ahmed','Ahmed');
select *from Admins