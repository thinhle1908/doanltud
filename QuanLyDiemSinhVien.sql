CREATE DATABASE QuanLyDiemSinhVien;
GO

USE QuanLyDiemSinhVien;
GO

CREATE TABLE USERS (
	user_id int IDENTITY NOT NULL,
	username NVARCHAR (30) NOT NULL UNIQUE,
	password NVARCHAR(250) NOT NULL,
	isAdmin INT NOT NULL
);
GO

CREATE TABLE SINHVIEN(
	MASV CHAR (12) NOT NULL,
	HO NVARCHAR (250) NOT NULL,
	TEN NVARCHAR (250) NOT NULL,
	GIOITINH NVARCHAR (3) NULL,
	NGAYSINH DATE ,
	DANTOC NVARCHAR (250) NULL,
	DIACHI NVARCHAR (250) NULL,
	QUEQUAN NVARCHAR (30) NULL,
	SODIENTHOAI NVARCHAR(15) NULL,
	EMAIL NVARCHAR (250) NULL,
	KHOAHOC INT NOT NULL,
	MAKHOA CHAR(6)


);
GO

CREATE TABLE USERS_SINHVIEN(
	user_id  int NOT NULL,
	MASV CHAR (6) NOT NULL,

);
GO

CREATE PROC sp_login(
	@username NVARCHAR (30)  ,
	@password NVARCHAR(250) 
)
AS
SELECT * FROM USERS WHERE USERS.username = @username AND USERS.password = @password;
GO

CREATE PROC sp_createUser(
	@username NVARCHAR (30),
	@password NVARCHAR(250),
	@isAdmin INT 
)
AS
INSERT INTO USERS(username,password,isAdmin)
VALUES (@username,@password,@isAdmin)
GO

CREATE PROC sp_addSinhVien(
	@MASV CHAR (12) ,
	@HO NVARCHAR (250) ,
	@TEN NVARCHAR (250) ,
	@GIOITINH NVARCHAR (3) ,
	@NGAYSINH DATE ,
	@DANTOC NVARCHAR (250) ,
	@DIACHI NVARCHAR (250) ,
	@QUEQUAN NVARCHAR (30) ,
	@SODIENTHOAI NVARCHAR(15) ,
	@EMAIL NVARCHAR (250) ,
	@KHOAHOC INT,
	@MAKHOA CHAR(6)
)
AS
INSERT INTO SINHVIEN(MASV,HO,TEN,GIOITINH,NGAYSINH,DANTOC,DIACHI,QUEQUAN,SODIENTHOAI,EMAIL,KHOAHOC,MAKHOA)
VALUES (@MASV,@HO,@TEN,@GIOITINH,@NGAYSINH,@DANTOC,@DIACHI,@QUEQUAN,@SODIENTHOAI,@EMAIL,@KHOAHOC,@MAKHOA)
GO

exec sp_addSinhVien '2211TT0001',N'Nguyễn',N'Quốc Bảo','Nam','1/1/2003','Kinh',N'Quận 3 Thành Phố Hồ Chí Minh',N'Bình Định','0123456789','nguyenquocbao@gmail.com','22','QT';
exec sp_addSinhVien '2211TT0002',N'Trần',N'Thị Xuân',N'Nữ','3/5/2004','Kinh',N'Quận 1 Thành Phố Hồ Chí Minh',N'Long An','01234513242','tranthixuan@gmail.com','22','TT';
exec sp_addSinhVien '2211TT0003',N'Đỗ',N'Quốc Hùng','Nam','12/1/2004','Kinh',N'Quận 4 Thành Phố Hồ Chí Minh',N'Cà Mau','032312313242','tranthixuan@gmail.com','22','DT';

exec sp_createUser 'thinhle','123',1;
exec sp_createUser 'quang98','123',2;


select * from USERS;
exec sp_login 'thinhle','123'

CREATE PROC sp_getallsinhvien
AS
select * from SINHVIEN
GO

CREATE PROC sp_searchsinhvien(
	@TEN NVARCHAR (250) 
)
AS
SELECT * FROM SINHVIEN WHERE SINHVIEN.TEN LIKE '%' + @TEN + '%';
GO

CREATE PROC sp_deletesinhvien(
	@MASV CHAR (12) 
)
AS
DELETE FROM SINHVIEN WHERE MASV =@MASV
GO
select * from sinhvien
/*drop database QuanLyDiemSinhVien; */
