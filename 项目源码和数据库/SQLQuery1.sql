create database MoneyManage
use MoneyManage

go

create table Roles(
ID int primary key identity(1,1),
RoleName nvarchar(20)
)

create table Subsidy(
ID int primary key identity(1,1),
SubsidyName nvarchar(20),
SubsidyDefault int
)

create table AttendanceSet(
ID int primary key identity(1,1),
 AttendanceName nvarchar(20),
 PayDeduction int
)

create table Prize(
ID int primary key identity(1,1),
PrizeName nvarchar(20),
PayDeductionDefault int
)

create table Department(
ID int primary key identity(1,1),
DepartmentName nvarchar(20)
)

create table Ranks(
ID int primary key identity(1,1),
RankName nvarchar(20),
Basepay int
)

create table Shop(
ID int primary key identity(1,1),
ShopName nvarchar(20),
Area nvarchar(50),
States int,
ShopManager nvarchar(20),
Remarks nvarchar(50)
)

create table Personnel(
ID int primary key identity(1,1),
Pwd int,
Name nvarchar(20),
States int,
RankID int references Ranks(ID) not null,
RoleID int references Roles(ID) not null,
DepartmentID int references Department(ID) not null,
Sex bit,
Addresses nvarchar(50),
Photo int,
ShopID int references Shop(ID) not null,
Email nvarchar(50)
)


create table Subsidynotes(
ID int primary key identity(1,1),
PersonnelID int references Personnel(ID) not null,
SubsidyID int references Subsidy(ID) not null,
SubsidyDefault int,
SubsidyDate date
)

create table Attendance(
ID int primary key identity(1,1),
PersonnelID int references Personnel(ID) not null,
AttendanceSetID int references AttendanceSet(ID) not null,
Counts int,
Dates date
)
create table GetPrize(
ID int primary key identity(1,1),
PersonnelID int references Personnel(ID) not null,
PrizeID int references Prize(ID) not null,
Moneys Money,
PrizeDate date
)


create table Pay(
ID int primary key identity(1,1),
PersonnelID int references Personnel(ID) not null,
PersonnelName nvarchar(20),
ShopName nvarchar(20),
RankName nvarchar(20),
PayDate date,
Basepay int,
AttendanceDebits int,
PrizeMoney int,
Payables int,
Paidwages int,
Remarks nvarchar(50)
)

drop table Personnel
drop database MoneyManage
