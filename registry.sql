USE [master]
GO

CREATE DATABASE [RegistraturaBase]
ON PRIMARY 
( NAME = N'RegistraturaBase', FILENAME = N'D:\MSSQL\RegistraturaBase.mdf')
GO

USE [RegistraturaBase]
GO



--таблица с ролями
create table Roles(
	id int identity(1,1) not null,
	name nvarchar(100),
	primary key(id)
)

--типы услуг
create table TypeServices(
	id int identity(1,1) not null,
	name nvarchar(100) not null
	primary key(id)
)

--виды специальностей работников в регистратуре
create table JobTitles(
	id int identity(1,1) not null, 
	name nvarchar(100) not null,
	description nvarchar(2000),
	primary key(id)
)

--справочник всех пользователей в приложении(админы тоже пользователи)
create table Users(
	id int identity(1,1) not null,
	name nvarchar(100) not null,
	snils nvarchar(11) not null,
	unique(snils),
	age int,
	gender bit,
	login nvarchar(100) not null,
	password nvarchar(100) not null,
	roleId int not null,
	dateReg dateTime,
	blocked bit,
	primary key(id),
	foreign key(roleId) references Roles(id),
)

--таблица в которую будут добавляться айдишник врача и его специальность, у одного врача может быть несколько прав
create table Permissions(
	id int identity(1,1) not null,
	jobTitleId int not null,
	userId int not null,
	primary key(id),
	foreign key(userId) references Users(id),
	foreign key(jobTitleId) references JobTitles(id)
)

--справочник заказов регистратуры
create table Orders(
	id int identity(1,1) not null,
	clientId int not null,
	doctorId int not null,
	typeServiceId int not null,
	dateOrder dateTime not null,
	primary key(id),
	foreign key(typeServiceId) references TypeServices(id),
	foreign key(clientId) references Users(id),
	foreign key(doctorId) references Users(id)
)

set identity_insert Users on
insert into Users(id, name, snils, age, gender, login, password, roleId)
values	(1, 'Соловьёв Назарий Святославович', '88028707129', 25, 1, 'soloviev', 'sns25ru', 0),
		(2, 'Мамонтов Витольд Дамирович', '71950154191', 69, 1, 'mamontov', 'mvd69ru', 0),
		(3, 'Бирюков Ефрем Лукьянович', '24543969600', 19, 1, 'birukov', 'bel19ru', 0),
		(4, 'Карпова Инара Ростиславовна', '44188153390', 41, 0, 'karpova', 'kir41ru', 0),
		(5, 'Коновалова Северина Кимовна', '43519629598', 55, 0, 'konovalova', 'ksk55ru', 0),
		(6, 'Авдеева Кармелитта Евсеевна', '95941244544', 39, 0, 'avdeeva', 'ake39ru', 0)
set identity_insert Users off

set identity_insert TypeServices on
insert into TypeServices(id, name)
values	(1, 'Запись к врачу'),
		(2, 'Сдача анализов'),
		(3, 'Запись на продецуры'),
		(4, 'График работы врачей')
set identity_insert TypeServices off

set identity_insert JobTitles on
insert into JobTitles(id, name)
values	(1, 'ВРАЧ-АЛЛЕРГОЛОГ'),
		(2, 'ВРАЧ-АНЕСТЕЗИОЛОГ-РЕАНИМАТОЛОГ'),
		(3, 'ВРАЧ-ЭПИДЕМИОЛОГ'),
		(4, 'ВРАЧ-ДЕЗИНФЕКЦИОНИСТ'),
		(5, 'ВРАЧ-КАРДИОЛОГ'),
		(6, 'ВРАЧ-ОНКОЛОГ'),
		(7, 'ВРАЧ-ТРАВМАТОЛОГ-ОРТОПЕД'),
		(8, 'ВРАЧ-ФИЗИОТЕРАПЕВТ'),
		(9, 'ВРАЧ-СУДЕБНО-МЕДИЦИНСКИЙ ЭКСПЕРТ'),
		(10, 'САНИТАРНЫЙ ВРАЧ'),
		(11, 'ВРАЧ-РЕНТГЕНОЛОГ'),
		(12, 'ВРАЧ-ТОКСИКОЛОГ'),
		(13, 'ВРАЧ-ПУЛЬМОНОЛОГ'),
		(14, 'ВРАЧ-УРОЛОГ'),
		(15, 'ВРАЧ-ТЕРАПЕВТ'),
		(16, 'ВРАЧ-ПЕДИАТР'),
		(17, 'ВРАЧ-ИНФЕКЦИОНИСТ'),
		(18, 'ВРАЧ-ХИРУРГ'),
		(19, 'ВРАЧ АКУШЕР-ГИНЕКОЛОГ'),
		(20, 'ВРАЧ-НЕВРОПАТОЛОГ'),
		(21, 'ВРАЧ-ПСИХИАТР'),
		(22, 'ВРАЧ-НАРКОЛОГ'),
		(23, 'ВРАЧ-ОФТАЛЬМОЛОГ'),
		(24, 'ВРАЧ-ОТОЛАРИНГОЛОГ'),
		(25, 'ВРАЧ-ДЕРМАТОВЕНЕРОЛОГ'),
		(26, 'ВРАЧ-СТОМАТОЛОГ'),
		(27, 'ФАРМАЦЕВТ'),
		(28, 'ЗУБНОЙ ТЕХНИК')
set identity_insert JobTitles off

set identity_insert Roles on
insert into Roles(id, name)
values	(1, 'Администратор'),
		(2, 'Врач'),
		(3, 'Клиент')
set identity_insert Roles off