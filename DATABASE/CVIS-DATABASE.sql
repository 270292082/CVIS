--- Patients table ---
create table Patients (
	ID varchar(30) primary key unique not null,
	username varchar(255) unique not null,
	password varchar(255) not null,
	firstName varchar(50) not null,
	lastName varchar(50) not null,
	DOB DATE not null,
	gender varchar(10),
	phone varchar(20) not null,
	email varchar(100) unique not null,
	address text not null
);
	
--- Vaccinations status ---
create table Patients_Vaccines (
	ID varchar(30) references patients(ID)on delete cascade,
	vaccine_Date Date not null,
	vaccine_Type varchar(50),
	vaccine_Lot varchar(50),
	vaccine_Doctor varchar(100)
);
	
--- Patients Emergency Contact ---
create table Patients_Emergency_Contacts (
	ID varchar(30) references patients(ID) on delete cascade,
	contactName varchar(50) not null,
	contactPhone varchar(20) not null,
	contactRelation varchar(50)
);
	
	
--- Staffs table (credentials) ---
create table Staffs (
	ID varchar(30) primary key not null unique,
	username varchar(100) unique not null,
	password varchar(100) not null,
	firstName varchar(100) not null,
	lastName varchar(100) not null,
	email varchar(100) unique not null,
	position varchar(50),
	hospitalDepartment varchar(100)
);
	
--- Staffs Info Table ---
create table Staffs_Info (
	ID varchar(30) references Staffs(ID) on delete cascade,
	medicalLicense varchar(30) unique not null,
	licenseExp Date not null,
	specialization varchar(50),
	phone varchar(20),
	address Text,
	rolePermission varchar(20)
);
	
	
--- Patients table data insert ---
insert into Patients (ID, username, password, firstName, lastName, DOB, gender, phone, email, address)
values
('123456','alix0','hellokitty','Alice','Manjaro','2004-04-18','Female','649281','alice.manjaro@gmail.com','8 Ronayne Street, Auckland CBD, Auckland 1010'),
('654321','jdoe','qwerty','John','Doe','1980-12-21','Male','649281','john.doe@gmail.com','9 Madeira Lane, Grafton, Auckland 1023');

--- Vaccines table data insert ---
insert into Patients_Vaccines (ID, vaccine_Date, vaccine_Type, vaccine_Lot, vaccine_Doctor)
values
('123456','2022-04-24','Pfizer','C4892A','Dr. Misha'),
('654321','2022-04-24','Pfizer','C4892A','Dr. Mikalow'),
('654321','2022-06-24','mRNA','C8922A','Dr. Shaman');

--- Emergency contact table data insert ---
insert into Patients_Emergency_Contacts (ID, contactName, contactPhone, contactRelation)
values
('123456','Florence Marshall','122365','Flatmate'),
('654321','Martin Blanchard','876832','Brother');
	
	
--- Staffs table data insert ----
insert into Staffs (ID, username, password, firstName, lastName, email, position, hospitalDepartment)
values
('AD123456','Lucius Snape','luciux','whitehead','lucius.snape@gmail.com','Nurse','Auckland City Hospital');
	
--- Staffs Info table data insert
insert into Staffs_Info (ID, medicalLicense, licenseExp, specialization, phone, address, rolePermission)
values
('AD123456','NRS123456','2030-05-30','ER Nurse','0213334445','58 Symonds Street, Grafton, Auckland 1010','Staff');

	
select * from Patients;
select * from Patients_Vaccines;
select * from Patients_Emergency_Contacts;
select * from Staffs;
select * from Staffs_Info;

-- join three databases ---
select * from Patients
join Patients_Vaccines on Patients.ID = Patients_Vaccines.ID 
join Patients_Emergency_Contacts on Patients.ID = Patients_Emergency_Contacts.ID
where Patients.ID = '654321';

--- join teo databases ---
select * from Staffs
join Staffs_Info
on Staffs.ID = Staffs_Info.ID
where Staffs.ID = 'AD123456';