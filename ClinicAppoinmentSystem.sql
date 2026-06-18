Create Database appointmentsystem;

create table Doctors(
DoctorId varchar(12) Primary Key,
DoctorName varchar(20) not null,
PhoneNum varchar(15) Not Null,
Emailaddress varchar(20) Not Null
)

create table Patient(
PatientIc varchar(12) Primary Key,
PatientName varchar(20) not null,
PatientPhone varchar(15) not null,
patientaddress varchar(255) Not null,
dateofbirth DATE Not Null
)

create table DoctorSchedule(

schedule_id INT PRIMARY KEY IDENTITY,
DoctorId Varchar(12) FOREIGN KEY REFERENCES Doctors(DoctorId),
available_date DATE Not Null,
start_time TIME Not Null,
end_time TIME Not Null,
status VARCHAR(20)
)
create table Appointment(
appointment_id INT PRIMARY KEY IDENTITY,
patient_id varchar(12) FOREIGN KEY REFERENCES Patient(PatientIc),
schedule_id INT FOREIGN KEY REFERENCES DoctorSchedule(schedule_id),
appointment_time TIME,
status VARCHAR(20)
)


INSERT INTO Doctors (DoctorId, DoctorName, PhoneNum, Emailaddress,Password) VALUES
('800101145678', 'Dr. Ahmad Zaki', '0123456789', 'ahmad@clinic.com','Abc123'),
('820305102345', 'Dr. Siti Nur', '0134567890', 'siti@clinic.com','Abc123'),
('780912088765', 'Dr. Lim Wei', '0145678901', 'lim@clinic.com','Abc123'),
('850623053456', 'Dr. Raj Kumar', '0156789012', 'raj@clinic.com','Abc123'),
('900411071122', 'Dr. Tan Mei', '0167890123', 'tan@clinic.com','Abc123');

INSERT INTO Patient (PatientIc, PatientName, PatientPhone, patientaddress, dateofbirth,Password) VALUES
('010101101234', 'Ali Rahman', '0121111111', 'Kuala Lumpur', '2001-01-01','Abc123'),
('020202102345', 'Siti Aminah', '0132222222', 'Selangor', '2002-02-02','Abc123'),
('030303103456', 'John Tan', '0143333333', 'Penang', '2003-03-03','Abc123'),
('040404104567', 'Mei Ling', '0154444444', 'Johor', '2004-04-04','Abc123'),
('050505105678', 'Kumar Ravi', '0165555555', 'Perak', '2005-05-05','Abc123');

Delete from Patient;

Delete From Doctors;

ALTER TABLE DOCTORS

ADD Password varchar(6) Not Null;
