create table Heroes(
Id int primary key identity(1,1),
Name nvarchar(50) not null,
Photo nvarchar(50),
Q_Coin int not null,
Weixin money
)
insert into Heroes(Name,Photo,Q_Coin,Weixin)
 values('���','1.jpg',45,'��43.65'),
 ('��Ѫ�伧 ϣ����','2.jpg',35,'��43.95'),
 ('�°��ܹ� ����','3.jpg',25,'��24.25'),
 ('������� �����','4.jpg',20,'��19.40')

 select * from Heroes