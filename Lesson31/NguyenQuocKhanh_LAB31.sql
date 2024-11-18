use master
go
-- Tao co so du lieu
CREATE DATABASE LAB31_NguyenQuocKhanh
GO
--su dung co so du lieu
use LAB31_NguyenQuocKhanh
go 

-- tao cau truc bangVattu(MaVtu,TenVTu,DvTinh,PhanTram)

CREATE TABLE VATTU
(
	MaVTu char(4) not null
		Constraint PK_VATTU primary key
	,TenVTu nvarchar(100) not null
		Constraint UQ_VATTU_TenVTu UNIQUE
	,DvTinh nvarchar(10) 
		Constraint DF_VATTU_DvTinh DEFAULT ''
	,PhanTram real 
		Constraint CK_VATTU_PhanTram Check(PhanTram>=0 and PhanTram<=100)
)
CREATE TABLE NHACC
(
	MaNhaCC char(3) not null PRIMARY KEY
	,TenNhaCC nvarchar(100) not null UNIQUE
	,DiaChi nvarchar(200) not null UNIQUE
	,DienThoai nvarchar(20) null DEFAULT N'Chưa có'
)
CREATE TABLE DONDH
(
	SoDh char(4) not null PRIMARY KEY
	,NgayDH datetime default GETDATE()
	,MaNhaCC char(3) not null references NHACC(MaNhaCC)
)
CREATE TABLE CTĐONDH
(
	SoDh char(4) not null references DONDH(SoDh)
	,MaVTu char(4) not null references VATTU(MaVTu)
	,SlDat int not null check(SlDat>0)
	,primary key(SoDh,MaVTu)
)
CREATE TABLE PNHAP
(
	SoPn char(4) not null PRIMARY KEY,
	NgayNhap datetime default GETDATE(),
	SoDh char(4) not null references DONDH(SoDh)
)
CREATE TABLE CTPNHAP
(
	SoPn char(4) not null,
	MaVTu char(4) not null references VATTU(MaVTu),
	SlNhap int not null check(SlNhap>0),
	DgNhap money not null check(DgNhap>0),
	primary key(SoPn,MaVTu)
)
CREATE TABLE PXUAT
(
	SoPx char(4) not null PRIMARY KEY,
	NgayXuat datetime default GETDATE(),
	TenKh nvarchar(100) not null
)
CREATE TABLE CTPXUAT
(
	SoPx char(4) not null,
	MaVTu char(4) not null references VATTU(MaVTu),
	SlXuat int not null check(SlXuat>0),
	DgXuat money not null check(DgXuat>0),
	primary key(SoPx,MaVTu)
)
CREATE TABLE TONKHO
(
	NamThang char(6) not null,
	MaVTu char(4) not null references VATTU(MaVTu),
	SLDau int not null check(SLDau>0),
	TongSLN int not null check(TongSLN>0),
	TongSLX int not null check(TongSLX>0),
	SLCuoi as SLDau + TongSLN - TongSLX PERSISTED ,
	primary key(NamThang,MaVTu)
)