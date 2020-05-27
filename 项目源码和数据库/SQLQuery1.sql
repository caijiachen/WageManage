create table Heroes(
Id int primary key identity(1,1),
Name nvarchar(50) not null,
Photo nvarchar(50),
Q_Coin int not null,
Weixin money
)
insert into Heroes(Name,Photo,Q_Coin,Weixin)
 values('腕豪','1.jpg',45,'￥43.65'),
 ('龙血武姬 希瓦娜','2.jpg',35,'￥43.95'),
 ('德邦总管 赵信','3.jpg',25,'￥24.25'),
 ('正义巨像 加里奥','4.jpg',20,'￥19.40')

 select * from Heroes