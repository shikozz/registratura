USE [master]
GO

CREATE DATABASE [TestScriptBase]
ON PRIMARY 
( NAME = N'TestScriptBase', FILENAME = N'D:\MSSQL\TestScriptBase.mdf')
GO

USE [TestScriptBase]
GO

create table Doctors(
	id int identity(1,1) not null,
	doctrorsId int,
	name nvarchar(100),
	primary key(id),
	constraint 
)

create table Users(
	id int identity(1,1) not null,
	
)

create table FIRST_TABLE (
ID int identity(100,1) not null,
NAME nvarchar(25),
constraint CON_FIRST_TABLE_PK
primary key (ID),
constraint CON_FIRST_TABLE_UNI_1
unique (NAME))
--GO

create table SECOND_TABLE (
ID int identity(100,1) not null,
FIRST_TABLE_ID int,
NAME nvarchar(25),
VALUE1 decimal(18,2),
VALUE2 decimal(18,2),
SUM_AMOUNT as (VALUE1 + VALUE2),
constraint CON_SECOND_TABLE_PK
primary key (ID),
constraint CON_SECOND_TABLE_FK_1
foreign key (FIRST_TABLE_ID) references FIRST_TABLE (ID)
on delete no action on update cascade,
constraint CON_SECOND_TABLE_UNI_1
unique (VALUE1, VALUE2))
--GO

SET IDENTITY_INSERT FIRST_TABLE ON
insert into FIRST_TABLE(ID, NAME)
values(1, 'Наименование 1'),
      (2, 'Наименование 2')
SET IDENTITY_INSERT FIRST_TABLE OFF
--GO

SET IDENTITY_INSERT SECOND_TABLE ON
insert into SECOND_TABLE(ID, FIRST_TABLE_ID, NAME, VALUE1, VALUE2)
values(1, 2, 'Имя 1', 10.00, 3.45),
      (2, 2, 'Имя 2', 12.50, 7.50),
      (3, 1, 'Имя 3', 1.15, 9.05)
SET IDENTITY_INSERT SECOND_TABLE OFF
--GO