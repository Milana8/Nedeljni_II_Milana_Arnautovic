CREATE DATABASE Nedeljni_II
 IF DB_ID('Nedeljni_II') IS NULL
CREATE DATABASE Nedeljni_II;
GO
USE Nedeljni_II;

if exists (SELECT name FROM sys.sysobjects WHERE name = 'tblClinic')
drop table tblClinic;
if exists (SELECT name FROM sys.sysobjects WHERE name = 'tblUser')
drop table tblUser;
if exists (SELECT name FROM sys.sysobjects WHERE name = 'tblManager')
drop table tblManager;
if exists (SELECT name FROM sys.sysobjects WHERE name = 'tblAdministrator')
drop table tblAdministrator;
if exists (SELECT name FROM sys.sysobjects WHERE name = 'tblDoctor')
drop table tblDoktor;
if exists (SELECT name FROM sys.sysobjects WHERE name = 'tblPatient')
drop table tblPatient;
if exists (SELECT name FROM sys.sysobjects WHERE name = 'tblMaintenance')
drop table tblMaintenance;
if exists (SELECT name FROM sys.sysobjects WHERE name = 'vwManager')
drop view vwManager;
if exists (SELECT name FROM sys.sysobjects WHERE name = 'vwDoctor')
drop view vwDoctor;
if exists (SELECT name FROM sys.sysobjects WHERE name = 'vwPatient')
drop view vwPatient;
if exists (SELECT name FROM sys.sysobjects WHERE name = 'vwMaintenance')
drop view vwMaintenance;
if exists (SELECT name FROM sys.sysobjects WHERE name = 'vwAdministrator')
drop view vwAdministrator;


Create table tblClinic(
ClinicID int identity(1,1) PRIMARY KEY,
ClinicName varchar(50)  NOT NULL,
DateConstruction date NOT NULL,
ClinicOwner varchar(50)  NOT NULL,
Adress varchar(50)  NOT NULL,
FloorNumber int not null,
NumberRoomsPerFloor int not null,
Balcony bit not null,
Garden bit not null,
AmbulancesParking int not null,
InvalidParking int not null,


);

Create table tblUser (
	UserID INT IDENTITY(1,1) PRIMARY KEY		NOT NULL,
	FirstName VARCHAR (50) 				NOT NULL,
	Surname VARCHAR (50)     not null,
	IdCard varchar(9) unique not null,
	Gender char not null,
	DateOfBirth date not null,
	Citizenship VARCHAR (50) not null,
	Username VARCHAR (50)  unique   not null,
	Pasword char (50),
);

  
Create table tblManager(
	ManagerID INT IDENTITY(1,1) PRIMARY KEY 	NOT NULL,
	FloorNumber int					NOT NULL,
	Surname VARCHAR (40) NOT NULL,
	MaxDoctorNumber int not null,
	MinRoomsNumber int not null,
	NumberOfOmissions	int not null,
	UserId int not null,			
);

Create table tblAdministrator(
	AdministratorID INT IDENTITY(1,1) PRIMARY KEY		NOT NULL,
	UserID int not null,
);

Create table tblDoctor (
	DoctorID INT IDENTITY(1,1) PRIMARY KEY		NOT NULL,
	UniqueNumber int unique not null,
	AccountNumber int unique not null,
	Department varchar (50) not null,
	ShiftWork varchar (50) not null, 
	AdmissionOfPatients bit not null,
	ManagerID int not null,
	UserID INT not null ,
);

Create table tblPatient (
	PatientID INT IDENTITY(1,1) PRIMARY KEY		NOT NULL,
	HealthInsuranceNumber int unique not null,
	InsuranceExpirationDate date not null,
	UniqueNumber int not null,
    UserID INT,
);

Create table tblMaintenance (
	MaintenanceID INT IDENTITY(1,1) PRIMARY KEY		NOT NULL,
	PermissionExpansionClinic bit not null,
	ResponsibleForDisabledAccess bit not null,
	UserID int not null,

);



ALTER TABLE tblAdministrator
ADD FOREIGN KEY (UserID) REFERENCES tblUser(UserID);
ALTER TABLE tblMaintenance
ADD FOREIGN KEY (UserID) REFERENCES tblUser(UserID);
ALTER TABLE tblManager
ADD FOREIGN KEY (UserID) REFERENCES tblUser(UserID);
ALTER TABLE tblDoctor
ADD FOREIGN KEY (UserID) REFERENCES tblUser(UserID);
ALTER TABLE tblDoctor
ADD FOREIGN KEY (ManagerID) REFERENCES tblManager(ManagerID);
ALTER TABLE tblPatient
ADD FOREIGN KEY (UserID) REFERENCES tblUser(UserID);
ALTER TABLE tblPatient
ADD FOREIGN KEY (UniqueNumber) REFERENCES tblDoctor(UniqueNumber);

GO
CREATE VIEW vwDoctor AS
	SELECT	tblUser.*, 
			tblDoctor.UniqueNumber, tblDoctor.AccountNumber, tblDoctor.Department, tblDoctor.ShiftWork, tblDoctor.AdmissionOfPatients, 
			tblDoctor.ManagerID, tblDoctor.DoctorID 
	FROM	tblUser, tblDoctor
	WHERE	tblUser.UserID = tblDoctor.UserID

GO
CREATE VIEW vwManager AS
	SELECT	tblUser.*, 
			tblManager.FloorNumber, tblManager.MaxDoctorNumber, tblManager.MinRoomsNumber, tblManager.NumberOfOmissions, 
		     tblManager.ManagerID
	FROM	tblUser, tblManager 
	WHERE	tblUser.UserID = tblManager.UserID

GO
CREATE VIEW vwAdministrator AS
	SELECT	tblUser.*, tblAdministrator.AdministratorID
	FROM	tblUser, tblAdministrator
	WHERE	tblUser.UserID = tblAdministrator.UserID

	GO
CREATE VIEW vwMaintenance AS
	SELECT	tblUser.*, tblMaintenance.PermissionExpansionClinic,tblMaintenance.ResponsibleForDisabledAccess,tblMaintenance.MaintenanceID
	FROM	tblUser, tblMaintenance
	WHERE	tblUser.UserID = tblMaintenance.UserID


