CREATE DATABASE qlDiemSv
GO

USE qlDiemSv
GO
--Tạo bảng

Create Table Account
 (
   UserName varchar(10) primary key,
   Password varchar(10) not null,
   Type int
 )

Create Table GiangVien
(
   MaGv char(15) primary key,
   TenGv nvarchar(20) ,
   GioiTinh nvarchar(15),
   Phone int,
   Email varchar(10)
 )

 Create Table MonHoc
 (
   MaMH varchar(5) primary key,
   TenMH nvarchar(30) not null,
   Hocki Nvarchar(15),
   SoTc int,
   MaGv char(15) foreign key references GiangVien (MaGv)
 )

--- Tao Bang Khoa --
Create Table Khoa
 (
   MaKhoa char(5) primary key,
   TenKhoa nvarchar(30) not null
 )
-- Tao Bang Lop ---
Create Table Lop
 (
   MaLop char(5) primary key,
   TenLop nvarchar(30) not null,
   MaKhoa char(5) foreign key references Khoa (MaKhoa)
 )
--- Tao Bang Sinh Vien ---
Create Table SinhVien
 (
   MaSV char(15) primary key,
   TenSV nvarchar(20) ,
   GioiTinh nvarchar(15) ,
   NgaySinh datetime ,
   QueQuan nvarchar(50),
   MaLop char(5) foreign key references Lop(MaLop)
 )
--- Tao Bang Diem ---
Create Table Diem
 (
   DiemCc float,
   DiemLan1 float,
   DiemLan2 float,
   DiemThi float,
   MaSV char(15) foreign key references SinhVien(MaSV),
   MaMH varchar(5) foreign key references MonHoc (MaMH)
)

--Nhap du lieu cho bang Account
	insert into Account values('Admin1','1234a',1)
	insert into Account values('Admin2','3456a',0)
	insert into Account values('Admin3','7681a',0)
	select * from Account

-- Nhap Du Lieu Bang Giang vien---
insert into GiangVien values('V1',N'Nguyễn Thu Hiền', N'Nữ',0364768179,'nh@gmail' )
insert into GiangVien values('V2',N'Hà Tiến Huân', N'Nam',03644679,'hth@gmail' )
insert into GiangVien values('V3',N'Trịnh Thị Hưng', N'Nữ',0364728979,'th@gmail' )

  Select * from GiangVien

  -- Nhap Du Lieu Bang Mon Hoc --
insert into MonHoc values('SQL',N'SQL',N'Học kì 1',3,'V2')
insert into MonHoc values('JV',N'Java',N'Học kì 3',2,'V3')
insert into MonHoc values('CNPM',N'Công Nghệ phần mềm',N'Học kì 3',3,'V2')
insert into MonHoc values('PTHT',N'Phân tích hệ thống',N'Học kì 1',4,'V1')
insert into MonHoc values('Mang',N'Mạng máy tính',N'Học kì 2',2,'V2')
insert into MonHoc values('Triet',N'Kinh tế chính trị',N'Học kì 6',4,'V1')

  select * from MonHoc

-- Nhap Du Lieu bang Khoa --
insert into Khoa values('CNTT',N'Công nghệ thông tin')
insert into Khoa values('CK',N'Cơ Khí')
insert into Khoa values('DT',N'Ðiện tử')
insert into Khoa values('KT',N'Kinh Tế')

  Select * from Khoa
 
--- Nhap Du Lieu Cho Bang Lop --
insert into Lop values('TI9',N'Tin 14A9','CNTT')
insert into Lop values('MT2',N'Máy 12A2','DT')
insert into Lop values('CK3',N'Cơ khí 14A3','CK')

select * from Lop


-- Nhap Du Lieu Bang Sinh Vien --
insert into SinhVien values('35110001',N'Nguyễn Ngô Dương',N'Nam','05/03/2004',N'Lạng Sơn','TI9')
insert into SinhVien values('35110002',N'Hà Tiến Hưng',N'Nữ','02/09/2001',N'Kim Ngưu','CK3')
insert into SinhVien values('35110003',N'Đỗ Quang Huân',N'Nữ','09/09/2002',N'Thường tín','TI9')
insert into SinhVien values('35110006',N'Đỗ Tiến Hưng',N'Nam','05/12/2000',N'Phú Thọ','MT2')

select * from SinhVien


-- Nhap Du Lieu Bang Diem --

insert into Diem values(9,6.7,7,8.5,'35110002','CNPM')
insert into Diem values(7.6,8.5,4.5,7.3,'35110002','PTHT')
insert into Diem values(10,8.5,4,5.5,'35110001','SQL')
insert into Diem values(10,7,7,9,'35110001','JV')
insert into Diem values(5,6,6,8,'35110006','PTHT')
insert into Diem values(7,5.5,9,5,'35110006','Triet')
insert into Diem values(8,7,9,7,'35110003','JV')
insert into Diem values(8,10,10,7.5,'35110003','SQL')


select * from Account
select * from GiangVien
select * from MonHoc
select * from Khoa
select * from Lop
select * from SinhVien
select * from Diem

SELECT MonHoc.MaMh as MonHoc_ID, MonHoc.TenMH as MONHOC_NAME, MonHoc.Hocki as HOCKI, GiangVien.MaGv as GIANGVIEN_ID, GiangVien.TenGv as GIANGVIEN_NAME
FROM MonHoc,GiangVien
WHERE MonHoc.MaGv = GiangVien.MaGv
SELECT SinhVien.MaSV, SinhVien.TenSV 
FROM SinhVien
WHERE
select Diem.DiemCc,Diem.DiemLan1,Diem.DiemLan2,Diem.DiemThi,SinhVien.MaSV,SinhVien.TenSV
From SinhVien,Diem
where SinhVien.MaSV = Diem.MaSV
