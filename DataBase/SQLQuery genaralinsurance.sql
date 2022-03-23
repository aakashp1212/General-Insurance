-----------------------------------vehicle details----------------

create table vehiclesdetails
(
manufacturer varchar(50),
customerId int ,
vehicleTypeId int,

model varchar(100),
drivingLicenseNumber varchar(50),
registrationNumber varchar(100) primary key,
engineNumber varchar(100),
chassisNumber varchar(100),
vehicleAge  int,
foreign key (customerId) references Customer_Registration(customerId),
foreign key (vehicleTypeId) references vehicletypes(vehicleTypeId)
);


drop table vehiclesdetails

select * from vehiclesdetails

insert into vehiclesdetails(manufacturer,model,drivingLicenseNumber,registrationNumber,engineNumber,chassisNumber,vehicleAge) values('Swift','Lxi','TDTGJH86545361','TS1E6886','84556','CDG8465',6)
----------------------------------------------------------------------------------------------------------


-------------------------------------customer registration-----------------------------------
create table Customer_Registration(
firstName varchar(50),
address varchar(max),
password varchar(50),

contactNo varchar(10),
userId int unique,
customerId int primary key identity(1,1) not null,
email varchar(50)
);
 insert into Customer_Registration(firstName,address,password,contactNo,email,userId) values('Vamsi','11/322 anthony','Vamsi@22',99892826,'vamsi@gmail.com',1000)

alter table Customer_Registration add  userId int unique
select *  from Customer_Registration
-------------------------------------------------------------------
------------------------------------------Login table--------------------------------
create table login(
userId int ,
password varchar(50),
loginId int primary key identity(100,1),
foreign key (UserId) references Customer_Registration(UserId),

);
insert into login(password) values('Vamsi@22')
drop table login
select * from login

-------------------------------------------------------------------------------------------

-----------------------------------------policy details------------------------------------
create table policydetails(
policyNumber int primary key identity (50,1),
durationId int,
planId int ,
customerId int,

vehicletypeId int
foreign key (customerId) references Customer_Registration(customerId),
foreign key (durationId) references insuranceduration(durationId),
foreign key (planId) references insuranceplantype(planId),
foreign key (vehicletypeId) references vehicletypes(vehicleTypeId)
);

--insert into policydetails(customerId,planId,vehicletypeId,durationId) values(1,1,1,1)

--drop  table policydetails
--select * from policydetails
----------------------------------------------------------------------------------------------

-----------------------------------claimhistory-----------------------------------------

create table claimhistory( 
claimNo int primary key identity(1,1) not null,
policyNumber int,
isApproved BIT,
amount decimal,
claimId int,
foreign key (policyNumber) references policydetails(policyNumber),
foreign key (claimId) references claimreasons(claimId)
);
--------------------------------------------------------------------

----------------------------------------claimreasons------------------------------------

create table claimreasons(
claimreason varchar(50),

claimId int primary key identity(1,1)
);
drop table claimreasons
------------------------------------------------------------------------


select * from claimreasons
insert into claimreasons(claimreason) values('Theft')

--------------------------------------vehicletypes------------------------------

 create table vehicletypes
 (
 vehicleType varchar(50),	
 vehicleTypeId int primary key identity(1,1)

 );
 

 insert into vehicletypes(vehicleType) values(' 2 Wheeler')
 select * from  vehicletypes
 ------------------------------------------------------------------------------
 --drop table vehicletypes
 --insert into insuranceplantype(planname) values('third party')
 ----------------------------------------------insuranceduration------------------------------------

 create table insuranceduration
 (
 durationValue varchar(50),	
 durationId int primary key identity(1,1) not null
 );

 insert into insuranceduration(durationValue) values('Three Years')
 ------------------------------------------------------------------------------
 
 
 --drop table insuranceduration
 
 select * from insuranceduration
 -----------------------------insuranceplantype--------------------------------

 create table insuranceplantype
 (
  planName varchar(50),	
 planId int primary key identity(1,1) not null
 );
 insert into insuranceplantype(planName) values('Comprehensive')
 select * from insuranceplantype
-----------------------------------------------------------


---------------------claims data------------------------

INSERT INTO vehiclesdetails(manufacturer,customer_id,
Vehicle_Type,model,driving_license_number, registration_number,engine_number,chasis_number)
VALUES ('Swift',1,'TwoWheeler','Lxi','TDTGJH86545361','TS1E6886',84556,'CDG8465');




select * from claimhistory
select * from claimreasons
select * from Customer_Registration
select * from insuranceduration
select * from insuranceplantype
select * from login
select * from policydetails
select * from vehiclesdetails
select * from vehicletypes