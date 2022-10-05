create database Student

on

use Student

go 

create table STUDENT
(
  EmployeeID INT PRIMARY KEY IDENTITY(1,1),
  Fullname NVARCHAR(100),
  Gender VARCHAR(100),
  Class VARCHAR(10),
  Dept VARCHAR(50)
)

go

INSERT INTO STUDENT VALUES(N'Phan Thanh Bình', 'Male','10DHTH1', 'Information Technology' )
INSERT INTO STUDENT VALUES(N'Nguyễn Tuấn Đạt', 'Male', '10DHSH5', 'Biology Technology' )
INSERT INTO STUDENT VALUES(N'Nguyễn Thị Thanh Thuỳ', 'Female','10DHTH1', 'Information Technology' )
INSERT INTO STUDENT VALUES(N'Trần Tuấn Anh', 'Male', '10DHNH2', 'Restaurant And Hotel Management' )
INSERT INTO STUDENT VALUES(N'Lương Bích Trang', 'Female', '10DHTH3', 'Information Technology' )
INSERT INTO STUDENT VALUES(N'Phan Ngọc Bích', 'Female', '10DHTP4', 'Food Technology' )
GO

select * from STUDENT