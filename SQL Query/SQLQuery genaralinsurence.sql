-----------------------------------vehicle details----------------

create table vehiclesdetails
(
manufacturer varchar(50),
customer_id bigint ,
Vehicle_Type varchar(50),
policy_number int,
model varchar(100),
driving_license_number varchar(50),
registration_number varchar(100) primary key,
engine_number varchar(100),
chasis_number varchar(100),
purchase_date date,
foreign key (customer_id) references Customer_Registration(customer_id),
foreign key (policy_number) references policydetails(policy_number)
);
drop table vehiclesdetails

select * from vehiclesdetails
----------------------------------------------------------------------------------------------------------


-------------------------------------customer registration-----------------------------------
create table Customer_Registration(
First_Name varchar(50),
Address varchar(max),
password varchar(50),
DOB datetime,
contact_no varchar(10),
policy_number int ,
customer_id bigint primary key identity(1,1) not null 
);
-------------------------------------------------------------------
------------------------------------------Login table--------------------------------
create table login(
email varchar(50),
password varchar(50)
);
-------------------------------------------------------------------------------------------

-----------------------------------------policy details------------------------------------
create table policydetails(
policy_number int primary key identity (50,1),
duration_id int,
plan_id int ,
customer_id bigint,
vehicle_id int,
vehicletype_id int
foreign key (customer_id) references Customer_Registration(customer_id),
foreign key (duration_id) references insuranceduration(duration_id),
foreign key (plan_id) references insuranceplantype(plan_id),
foreign key (vehicletype_id) references vehicletypes(vehicletype_id)
);
drop  table policydetails
----------------------------------------------------------------------------------------------

-----------------------------------claimhistory-----------------------------------------

create table claimhistory( 
claim_no int primary key identity(1,1) not null,
policy_number int,
is_Approved BIT,
amount decimal,
claim_id int,
foreign key (policy_number) references policydetails(policy_number),
foreign key (claim_id) references claimreasons(claim_id)
);
--------------------------------------------------------------------

----------------------------------------claimreasons------------------------------------

create table claimreasons(
claimreason varchar(50),

claim_id int primary key identity(1,1)
);
drop table claimreasons
------------------------------------------------------------------------


--select * from vehicletypes
-- insert into claimreasons(claimreason,claim_id) values('Theft',4

--------------------------------------vehicletypes------------------------------

 create table vehicletypes
 (
 vehicletype varchar(50),	
 vehicletype_id int primary key identity(1,1)

 );
 ------------------------------------------------------------------------------
 --drop table vehicletypes
 --insert into insuranceplantype(planname) values('third party')
 ----------------------------------------------insuranceduration------------------------------------

 create table insuranceduration
 (
 duration_value varchar(50),	
 duration_id int primary key identity(1,1) not null
 );
 ------------------------------------------------------------------------------
 
 
 --drop table insuranceduration
 
 --select * from insuranceduration
 -----------------------------insuranceplantype--------------------------------

 create table insuranceplantype
 (
  planname varchar(50),	
 plan_id int primary key identity(1,1) not null
 );
 
-----------------------------------------------------------