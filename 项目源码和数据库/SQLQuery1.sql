create database MoneyManage
go

use MoneyManage

go

create table Roles(
ID int primary key identity(1,1),
RoleName nvarchar(20)
)
insert into Roles values('�곤'),
('Ա��')
select * from Roles
go

create table Subsidy(
ID int primary key identity(1,1),
SubsidyName nvarchar(20),
SubsidyDefault int
)
insert into Subsidy values('��Ͳ���',100),
('��ͨ����',50)
go

create table AttendanceSet(
ID int primary key identity(1,1),
 AttendanceName nvarchar(20),
 PayDeduction int
)
insert into AttendanceSet values('���ڿۿ�',80)
go

create table Prize(
ID int primary key identity(1,1),
PrizeName nvarchar(20),
PayDeductionDefault int
)
insert into Subsidy values('ȫ�ڽ�',100),
('����Ա��',100)
go

create table Department(
ID int primary key identity(1,1),
DepartmentName nvarchar(20)
)
insert into Department values('�ŵ겿'),
('�ɹ���'),
('������'),
('���²���')
go

create table Ranks(
ID int primary key identity(1,1),
RankName nvarchar(20),
Basepay int
)
insert into Ranks values
('�ŵ�ʵϰ��',1500),
('�ŵ�һ��',2600),
('�ŵ����',3500),
('�ŵ�����',4200),
('�ŵ��ļ�',5200),
('�ɹ�ʵϰ��',1500),
('�ɹ�һ��',2600),
('�ɹ�����',3500),
('�ɹ�����',4200),
('�ɹ��ļ�',5200),
('����ʵϰ��',1500),
('����һ��',2600),
('��������',3500),
('��������',4200),
('�����ļ�',5200),
('����ʵϰ��',1500),
('����һ��',2600),
('���¶���',3500),
('��������',4200),
('�����ļ�',5200)

go

create table Shop(
ID int primary key identity(1,1),
ShopName nvarchar(20),
Area nvarchar(50),
States int,
ShopManager nvarchar(20),
Remarks nvarchar(50)
)
insert into Shop values('����','��ɳ',1,'С��','�ǳ���'),
('������ҵ','����',1,'С��','����'),
('ǿǿ����','����',0,'Сǿ','��������')
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
insert into Personnel values(123456,'С��',1,2,2,1,1,'��ɳ',181419999,1,'1263@163.com')
--,
--(123456,'С��',1,2,2,1,0,'����',18174419999,2,'1263@163.com'),
--(123456,'С��',1,2,2,1,1,'��ɳ',18174419999,1,'1263@163.com'),
--(123456,'С��',0,3,3,1,0,'����',18174419999,1,'1263@163.com')
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
