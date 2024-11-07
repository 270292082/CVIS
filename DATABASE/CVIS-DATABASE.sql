--- patients table ---
create table Patients (
	ID varchar(30) primary key unique not null,
	username varchar(255) unique not null,
	password varchar(255) not null,
	FirstName varchar(50) not null,
	LastName varchar(50) not null,
	DOB DATE not null,
	Gender varchar(10),
	Phone varchar(20) not null,
	Email varchar(100) unique not null,
	Address text not null
);
 
--- vaccination status ---
create table Patient_Vaccine (
	patient_ID varchar(30) references patients(ID)on delete cascade,
	Vaccine_Date Date not null,
	Vaccine_Type varchar(50),
	Vaccine_Lot varchar(50),
	Vaccine_Doctor varchar(100)
);
 
--- patient emergency contact ---
create table Patient_Emergency_Contact (
	patient_ID varchar(30) references patients(ID) on delete cascade,
	ContactName varchar(50) not null,
	ContactPhone varchar(20) not null,
	ContactRelation varchar(50)
);
 
 
--- Admin table (credentials) ---
create table Admins (
	admin_ID varchar(30) primary key not null unique,
	Email varchar(100) unique not null,
	Password varchar(100) not null,
	FullName varchar(100) not null,
	Position varchar(50),
	HospitalDepartment varchar(100)
);
 
--- Admin Info Table ---
create table Admin_Info (
	admin_ID varchar(30) references Admins(admin_ID) on delete cascade,
	MedicalLicense varchar(30) unique not null,
	LicenseExp Date not null,
	Specialization varchar(50),
	Phone varchar(20),
	Address Text,
	RolePermission varchar(20)
);
 
 
--- patients table data insert ---
insert into Patients (ID,username,password,FirstName,LastName,DOB,Gender,Phone,Email,Address)
values
('123456','alix0','hellokitty','Alice','Manjaro','2004-04-18','Female','649281','alice.manjaro@gmail.com','8 Ronayne Street, Auckland CBD, Auckland 1010'),
('654321','jdoe','qwerty','John','Doe','1980-12-21','Male','649281','john.doe@gmail.com','9 Madeira Lane, Grafton, Auckland 1023');
 
--- vaccine table data insert ---
insert into Patient_Vaccine (patient_ID,Vaccine_Date,Vaccine_Type,Vaccine_Lot,Vaccine_Doctor)
values
('123456','2022-04-24','Pfizer','C4892A','Dr. Misha'),
('654321','2022-04-24','Pfizer','C4892A','Dr. Mikalow'),
('654321','2022-06-24','mRNA','C8922A','Dr. Shaman');
 
--- Emergency contact table data insert ---
insert into Patient_Emergency_Contact (patient_ID,ContactName,ContactPhone,ContactRelation)
values
('123456','Florence Marshall','122365','Flatmate'),
('654321','Martin Blanchard','876832','Brother');
 
 
--- Admins table data insert ----
insert into Admins (admin_ID,Email,Password,FullName,Position,HospitalDepartment)
values
('AD123456','lucius.snape@gmail.com','whitehead','Lucius Snape','Nurse','Auckland City Hospital, Emergency');
 
--- Admin_Info table data insert
insert into Admin_Info (admin_ID,MedicalLicense,LicenseExp,Specialization,Phone,Address,RolePermission)
values
('AD123456','NRS123456','2030-05-30','ER Nurse','0213334445','58 Symonds Street, Grafton, Auckland 1010','Staff');
 
 
select * from Patients;
select * from Patient_Vaccine;
select * from Patient_Emergency_Contact;
select * from Admins;
select * from Admin_Info;
 
-- join three databases ---
select * from Patients
join Patient_Vaccine on Patients.ID = Patient_Vaccine.patient_ID 
join Patient_Emergency_Contact on Patients.ID = Patient_Emergency_Contact.patient_ID
where Patients.ID = '654321';
 
--- join teo databases ---
select * from Admins
join Admin_Info
on Admins.admin_ID = Admin_Info.admin_ID
where Admins.admin_ID = 'AD123456';