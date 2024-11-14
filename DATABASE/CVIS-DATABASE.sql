
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
	date Date not null,
	patient_ID varchar(30) references patients(ID)on delete cascade,
	type varchar(50) not null,
	lot varchar(50) not null,
	doctor varchar(100) not null
);
	
--- Patients Emergency Contact ---
create table Patients_Emergency_Contacts (
	patient_ID varchar(30) references patients(ID) on delete cascade,
	firstName varchar(50) not null,
	lastName varchar(50) not null,
	phone varchar(20) not null,
	relation varchar(50)
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
	medicalLicense varchar(30) unique,
	licenseExp Date,
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
insert into Patients_Vaccines (date, patient_ID, type, lot, doctor)
values
('2022-04-24','123456','Pfizer','C4892A','Dr. Misha'),
('2022-04-24','654321','Pfizer','C4892A','Dr. Mikalow'),
('2022-06-24','654321','mRNA','C8922A','Dr. Shaman');

--- Emergency contact table data insert ---
insert into Patients_Emergency_Contacts (patient_ID, firstName, lastName, phone, relation)
values
('123456','Florence', 'Marshall','122365','Flatmate'),
('654321','Martin', 'Blanchard','876832','Brother');
	
	
--- Staffs table data insert ----
insert into Staffs (ID, username, password, firstName, lastName, email, position, hospitalDepartment)
values
('AD123456','serverix','whitehead','Severus', 'Snape', 'severus.snape@gmail.com','Nurse','Auckland City Hospital'),
('AD654321','willy','micheal123','William', 'Afton', 'william.afton@gmail.com','Doctor','Auckland City Hospital'),
('AD872911','yun0','heisminebitch','Yuno', 'Gasai', 'yuno.gasai341@gmail.com','Nurse','Auckland City Hospital'),
('AD666666','hisoka','gonfreecss','Hisoka', 'Morow', 'hisoka@gmail.com','Admin','Auckland City Hospital');
	
--- Staffs Info table data insert
insert into Staffs_Info (ID, medicalLicense, licenseExp, specialization, phone, address, rolePermission)
values
('AD123456','NRS123456','2030-05-30','ER Nurse','0213334445','58 Symonds Street, Grafton, Auckland 1010','Staff'),
('AD654321','NRS654321','2032-02-23','ER Doctor','0213212321','15 Whitty Place, Grafton, Auckland 1010','Staff'),
('AD872911','NRS872911','2030-08-20','ER Nurse','0218189883','12 Rodeo Street, Grafton, Auckland 1010','Staff'),
('AD666666','','','Admin','0216719237','23 Toki Doki Place, Somewhere, Auckland 1010','Admin');


-- join three databases ---
select * from Patients
join Patients_Vaccines on Patients.ID = Patients_Vaccines.patient_ID 
join Patients_Emergency_Contacts on Patients.ID = Patients_Emergency_Contacts.patient_ID
where Patients.ID = '654321';

--- join two databases ---
select * from Staffs
join Staffs_Info
on Staffs.ID = Staffs_Info.ID
where Staffs.ID = 'AD123456';