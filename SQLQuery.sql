
drop database ESocietyProject


create database ESocietyProject
use ESocietyProject



--Society table
create table Society_Details(
	Society_ID varchar(10) PRIMARY KEY,
	Society_Name varchar(50) not null  ,
	Society_City varchar(20)not null,
	Society_Pincode bigint not null,
	Society_NoOffHouse int not null
)

--house details
create table House_Details(
	House_ID varchar(10) primary key,
	House_Size_BHK int not null,
	House_Type varchar(50) not null
)

--Owner details
create table Owner_Registration(
	Owner_ID int primary key identity(1,1),
	Owner_UserName varchar(50) not null,
	Owner_Password varchar(50) not null,
	Owener_Email varchar(50) not null,
	House_ID  varchar(10)references House_Details(House_ID),             
	Society_ID  varchar(10)references Society_Details(Society_ID),           
	Owner_FirstName varchar(50) not null,
	Owner_Lastname varchar(50) not null,
	Owner_IDPROOF varchar(50)not null, 
	Owner_Contact bigint not null,
	Owner_Occupation varchar(50)  null,
	Owner_NumberOfFamily int  null
)

--service category details
create table Service_Category(
	Service_Category_ID int primary key identity(1,1),
	Service_Category varchar(50) not null
)

 
--User service details
create table User_Service_Details(
	User_Id int primary key identity(1,1),
	Service_Category_ID int references Service_Category(Service_Category_ID),
	User_Name varchar(50) not null,
	User_Address varchar (50) not null,
	User_Contact bigint not null,
	User_Availavility varchar(50) not null,
	User_Rate bigint not null
)

--Nearby service category
create table Nearby_Services_Category(
	Nearby_Services_Category_ID int primary key identity(1,1),
	Nearby_Services_Category varchar(50) not null
)

 
--Nearby service details
create table Nearby_Services(
	Nearby_Services_ID int primary key identity(1,1),
	Nearby_Services_Category_ID int references Nearby_Services_Category(Nearby_Services_Category_ID),
	Nearby_Services_Name varchar(50) not null,
	Nearby_Services_Contact bigint not null,
	Nearby_Services_Address varchar(50) not null,
	Nearby_Services_Distance real not null,
	Nearby_Services_Details varchar(50) not null
)

--Gard table
create table Guard_Duty(
	Visitor_ID int primary key identity(1,1),
	Visitor_Name varchar(50)not null,
	In_Datetime varchar(50) not null,
	Out_Datetime varchar(50) null,
	Details varchar(50) not null,
	House_ID varchar(10) References House_Details(House_ID),
	Require int  null
)

--parking table
create table Parking_Details(
	Parking_ID int primary key identity(1,1),
	Vechile_Number varchar(50) not null,
	Visitor_ID int References Guard_Duty(Visitor_ID),
	Slot_Id varchar(5) ,
)

--Additional details
create table Additional_Facility_Details(
	Facility_ID int primary key identity(1,1),
	Facility_Name varchar(50) not null,
	Facility_Address varchar(50) not null,
	Facility_Contact bigint not null,
	Facility_Availability int default(0) not null,
	Facility_Charges bigint not null
)

--funtion category
create table Function_Category(
	Function_Category_ID int primary key identity(1,1),
	Function_Category varchar(50) not null
)

 
--Function Details
create table Function_Details(
	Function_ID int primary key identity(1,1),
	Function_Category_ID int References Function_Category(Function_Category_ID),
	Owner_ID int References Owner_Registration(Owner_ID),
	Function_Date varchar(50) not null,
	Function_Time varchar(50) not null,
	Function_Duration varchar(50) not null,
	Function_Details varchar(50) not null,
	Function_Status int default(0) not null
)

--admin
create table AdminRegistration(
	Admin_ID int primary key identity(1,1),
	Admin_Name varchar(50) not null,
	Admin_Password varchar(50) not null
)


create table Available_Slots(
	Slot_ID varchar(5) primary key
)

create table Engaged_Slots(
	Slot_ID varchar(5) primary key
)

drop table AvailableSlots





--trigger for entering the visitor

create trigger SlotHandeller 
on Parking_Details
for insert
as 
begin
	declare @pid int,@slta varchar(5),@slte varchar(5)
	select @pid=Parking_ID,@slte=Slot_Id from inserted
	select @slta=Slot_Id from Available_Slots where Slot_Id=@slte
	if @slte=@slta
		begin
			insert into Engaged_Slots values(@slte);
			delete from Available_Slots where Slot_Id=@slte;
			commit;
		end;
	else
		begin
			Print 'Invalid Slot';
			rollback;
		end;
end;

drop trigger SlotHandeller 
--testing
insert into Parking_Details values('VN',1,'S1')


insert into Parking_Details values('VNWER',2,'S2')