create database MoneyManage
go

use MoneyManage

go

create table Roles(
ID int primary key identity(1,1),
RoleName nvarchar(20)
)
insert into Roles values('店长'),
('员工')
select * from Roles
go

create table Subsidy(
ID int primary key identity(1,1),
SubsidyName nvarchar(20),
SubsidyDefault int
)
insert into Subsidy values('午餐补贴',100),
('交通补贴',50)
go

create table AttendanceSet(
ID int primary key identity(1,1),
 AttendanceName nvarchar(20),
 PayDeduction int
)
insert into AttendanceSet values('考勤扣款',80)
go

create table Prize(
ID int primary key identity(1,1),
PrizeName nvarchar(20),
PayDeductionDefault int
)
insert into Subsidy values('全勤奖',100),
('优秀员工',100)
go

create table Department(
ID int primary key identity(1,1),
DepartmentName nvarchar(20)
)
insert into Department values('门店部'),
('采购部'),
('行政部'),
('人事部部')
go

create table Ranks(
ID int primary key identity(1,1),
RankName nvarchar(20),
Basepay int
)
insert into Ranks values
('门店实习生',1500),
('门店一级',2600),
('门店二级',3500),
('门店三级',4200),
('门店四级',5200),
('采购实习生',1500),
('采购一级',2600),
('采购二级',3500),
('采购三级',4200),
('采购四级',5200),
('行政实习生',1500),
('行政一级',2600),
('行政二级',3500),
('行政三级',4200),
('行政四级',5200),
('人事实习生',1500),
('人事一级',2600),
('人事二级',3500),
('人事三级',4200),
('人事四级',5200)

go

create table Shop(
ID int primary key identity(1,1),
ShopName nvarchar(20),
Area nvarchar(50),
States int,
ShopManager nvarchar(20),
Remarks nvarchar(50)
)
insert into Shop values('晨光','长沙',1,'小晨','非常棒'),
('联合商业','北京',1,'小连','不错'),
('强强联合','岳阳',0,'小强','继续加油')
go

create table Personnel(
ID int primary key identity(1,1),
Pwd int,
Name nvarchar(20),
States int,
RankID int references Ranks(ID),
RoleID int references Roles(ID),
DepartmentID int references Department(ID),
Sex bit,
Addresses nvarchar(50),
Photo int,
ShopID int references Shop(ID),
Email nvarchar(50)
)
insert into Personnel values(123456,'小彩',1,2,2,1,1,'长沙',181419999,1,'1263@163.com')
--,
--(123456,'小刘',1,2,2,1,0,'岳阳',18174419999,2,'1263@163.com'),
--(123456,'小李',1,2,2,1,1,'长沙',18174419999,1,'1263@163.com'),
--(123456,'小哥',0,3,3,1,0,'北京',18174419999,1,'1263@163.com')
go

create table Subsidynotes(
ID int primary key identity(1,1),
PersonnelID int references Personnel(ID) not null,
SubsidyID int references Subsidy(ID) not null,
SubsidyDefault int,
SubsidyDate datetime
)
insert into Subsidynotes values(1,1,100,getdate())

create table Attendance(
ID int primary key identity(1,1),
PersonnelID int references Personnel(ID) not null,
AttendanceSetID int references AttendanceSet(ID) not null,
Counts int,
Dates datetime
)
insert into Attendance values(1,1,1,GETDATE())
update 
go

create table GetPrize(
ID int primary key identity(1,1),
PersonnelID int references Personnel(ID) not null,
PrizeID int references Prize(ID) not null,
Moneys Money,
PrizeDate datetime
)
insert into GetPrize values(1,1,100,GETDATE())
go

create table Pay(
ID int primary key identity(1,1),
PersonnelID int references Personnel(ID) not null,
PersonnelName nvarchar(20),
ShopName nvarchar(20),
RankName nvarchar(20),
PayDate datetime,
Basepay int,
AttendanceDebits int,
SubMoney int,
PrizeMoney money,
Payables int,
Paidwages int,
Remarks nvarchar(50)
)

insert into Pay select * from Personnel
go
create table Attendances(
ID int primary key identity(1,1),
PersonnelID int references Personnel(ID) not null,
AttendanceStates int
)
go
drop table pay
drop table Attendances
drop table Personnel
drop database MoneyManage
