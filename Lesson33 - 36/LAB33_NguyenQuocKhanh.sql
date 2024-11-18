USE LAB32_NguyenQuocKhanh
GO


/*1. Liệt kê danh sách sinh viên gồm các thông tin sau: Họ và tên sinh viên, 
Giới tính,Tuổi, Mã khoa. Trong đó Giới tính hiển thị ở 
dạng Nam/Nữ tuỳ theo giá trị củafield Phai là True hay False, 
Tuổi sẽ được tính bằng cách lấy năm hiện hành trừ cho năm sinh. 
Danh sách sẽ được sắp xếp theo thứ tự Tuổi giảm dần*/

SELECT HoSV as'Họ' ,TenSV as'Tên',
          [Giới tính] =CASE
		                       WHEN Phai =1 THEN N'Nữ'
							   WHEN Phai =0 THEN N'Nam'
							END,
[Tuổi]= YEAR(GETDATE())-YEAR(NgaySinh)
From SinhVien
ORDER by YEAR(GETDATE())-YEAR(NgaySinh) DESC
go

/*2. Liệt kê danh sách sinh viên, gồm các thông tin sau: Mã sinh viên, Họ sinh viên,
Tên sinh viên, Học bổng. Danh sách sẽ được sắp xếp theo thứ tự Mã sinh viên
tăng dần.*/

SELECT HoSV AS 'Họ', TenSV AS'Tên',
[Phải]= CASE WHEN phai =1 THEN N'Nữ'
            WHEN phai =0 THEN N'Nam'
			END,
DAY(NgaySinh)
FROM dbo.SinhVien
WHERE MONTH(NgaySinh)=2 AND YEAR(NgaySinh)=1994
GO

/*3. Danh sách các sinh viên, gồm các thông tin sau: Mã sinh viên, Tên sinh viên,
Phái, Ngày sinh. Danh sách sẽ được sắp xếp theo thứ tự của tên.*/

SELECT * FROM dbo.SinhVien
ORDER BY NgaySinh DESC
GO
/*4. Thông tin các sinh viên gồm: Họ tên sinh viên, Ngày sinh, Học bổng. Thông tin
sẽ được sắp xếp theo thứ tự Ngày sinh tăng dần và Học bổng giảm dần.*/
SELECT MaSV AS 'Mã sinh viên',Phai AS 'Phái',MaKH AS 'Mã khoa',
[Mức học bổng]=CASE WHEN HocBong >500000 THEN N'Học bổng cao'
                    ELSE N'Mức trung bình'
				END
FROM dbo.SinhVien
GO

/*5. Cho biết điểm thi của các sinh viên, gồm các thông tin: Họ tên sinh viên, Mã
môn học, Điểm. Kết quả sẽ được sắp theo thứ tự Họ tên sinh viên và mã môn
học tăng dần*/

SELECT HoSV AS 'Họ', TenSV AS 'Tên',
MonHoc.MaMH AS 'Mã môn học', Diem AS 'Điểm'
FROM dbo.SinhVien JOIN dbo.Ketqua ON Ketqua.MaSV = SinhVien.MaSV JOIN
dbo.MonHoc ON MonHoc.MaMH = Ketqua.MaMH
ORDER BY Họ , Tên , MonHoc.MaMH
GO

/*6. Danh sách sinh viên của khoa Anh văn, điều kiện lọc phải sử dụng tên khoa, gồm
các thông tin sau: Họ tên sinh viên, Giới tính, Tên khoa. Trong đó, Giới tính sẽ
hiển thị dạng Nam/Nữ*/

SELECT HoSV AS' Họ', TenSV AS 'Tên',
[Giới tính] = CASE
                    WHEN Phai =1 THEN N'Nữ'
					WHEN Phai =0 THEN N'Nam'
				END
,TenKH AS 'Tên khoa'
FROM dbo.SinhVien JOIN dbo.Khoa ON Khoa.MaKH = SinhVien.MaKH
WHERE Khoa.MaKH = 'AV'
GO
/*7. Liệt kê bảng điểm của sinh viên khoa Tin Học, gồm các thông tin:Tên khoa, Họ
tên sinh viên, Tên môn học, Số tiết, Điểm*/

SELECT TenKH AS 'Tên khoa', HoSV AS 'Họ',
TenSV AS 'Tên',
TenMH AS 'Tên môn học',
Sotiet AS 'Số tiết',
Diem AS 'Điểm'
FROM dbo.SinhVien JOIN dbo.Khoa ON Khoa.MaKH = SinhVien.MaKH JOIN dbo.Ketqua ON
Ketqua.MaSV = SinhVien.MaSV JOIN dbo.MonHoc ON MonHoc.MaMH = Ketqua.MaMH
WHERE Khoa.MaKH='TH'
GO

/*8. Kết quả học tập của sinh viên, gồm các thông tin: Họ tên sinh viên, Mã khoa,
Tên môn học, Điểm thi, Loại. Trong đó, Loại sẽ là Giỏi nếu điểm thi > 8, từ 6 đến
8 thì Loại là Khá, nhỏ hơn 6 thì loại là Trung Bình*/

SELECT
HoSV AS 'Họ',
TenSV AS 'Tên',
MaKH AS 'Mã khoa',
TenMH AS 'Tên môn học',
Diem AS 'Điểm',
[Loại]= CASE WHEN Diem >8 THEN N'Giỏi'
                 WHEN Diem BETWEEN 6 AND 8 THEN N'Khá'
				 WHEN Diem <6 THEN N'Trung bình'
				 END
FROM dbo.SinhVien JOIN dbo.Ketqua ON Ketqua.MaSV = SinhVien.MaSV
JOIN dbo.Monhoc ON MonHoc.MaMH = Ketqua.MaMH
GO

SELECT MonHoc.MaMH as N'Mã môn',
TenMH as N'Tên môn',
AVG(Diem) as N'Trung bình điểm thi'
FROM dbo.SinhVien JOIN dbo.Ketqua ON Ketqua.MaSV = SinhVien.MaSV JOIN dbo.MonHoc ON
MonHoc.MaMH = Ketqua.MaMH
GROUP BY MonHoc.MaMH,TenMH,DiemTrungBinh
GO

SELECT HoSV AS N'HỌ', TenSV AS N'TÊN',TenKH,[Tong Mon Thi] = COUNT(Ketqua.MaMH)
FROM SinhVien JOIN Ketqua ON Ketqua.MaSV = SinhVien.MaSV join MonHoc 
on MonHoc.MaMH = Ketqua.MaMH JOIN Khoa on Khoa.MaKH = SinhVien.MaKH
GROUP BY HoSV, TenSV, TenKH
GO

SELECT TenKH as 'Ten khoa',[TỔNG SỐ SINH  VIÊN] = COUNT(MaSV)
From Khoa join	SinhVien on SinhVien.MaKH = Khoa.MaKH 
Group by TenKH
GO

SELECT HoSV, TenSV, [Diem] = MAX(Diem)
FROM SinhVien join Ketqua on Ketqua.MaSV = SinhVien.MaSV
GROUP BY HoSV,TenSV
GO

SELECT TenMH, SoTiet
FROM MonHoc
WHERE SoTiet = (SELECT MAX(Sotiet) FROM MonHoc)
GO

SELECT Khoa.MaKH as N'Mã khoa', TenKH, MAX(HocBong)
FROM SinhVien JOIN Khoa ON Khoa.MaKH = SinhVien.MaKH
Group by Khoa.MaKH, TenKH
go

SELECT TenMH, MAX(Diem) 
FROM MonHoc JOIN Ketqua ON Ketqua.MaMH = MonHoc.MaMH
GROUP BY TenMH
go

SELECT Ketqua.MaMH, TenMH, COUNT(SinhVien.MaSV)
FROM MonHoc JOIN Ketqua ON Ketqua.MaMH= MonHoc.MaMH
JOIN SinhVien on SinhVien.MaSV = Ketqua.MaSV
GROUP BY Ketqua.MaMH,TenMH
GO

SELECT TOP 1 TenMH, SoTiet, TenSV, Diem
FROM MonHoc JOIN Ketqua on Ketqua.MaMH = MonHoc.MaMH
join SinhVien on SinhVien.MaSV = Ketqua.MaSV
ORDER BY Diem DESC
GO

Select TOP 1 TenMH, SoTiet, TenSV, Diem
FROM MonHoc join KetQua on KetQua.MaMH = MonHoc.MaMH
join SinhVien on SinhVien.MaSV = KetQua.MaSV
Order By Diem DESC
GO

Select TOP 1
	Khoa.MaKH as N'Ma Khoa',
	Khoa.TenKH as N'Ten Khoa',
	Count (SinhVien.MaSV) as N'Tong So Sinh Vien Dang Hoc'
From 
	Khoa
Join
	SinhVien on Khoa.MaKH = SinhVien.MaKH
Group By 
	Khoa.MaKH, Khoa.TenKH
Order By
	Count (SinhVien.MaSV) DESC
GO
------------------------------------

DECLARE @MaKH nvarchar(10);
SET @MaKH = 'AV';

Select 
	SinhVien.MaSV as N'Ma Sinh Vien',
	SinhVien.TenSV as N'Ten Sinh Vien',
	SinhVien.Phai as N'Gioi Tinh',
	Khoa.TenKH as N'Ten Khoa'
From 
	SinhVien
Join
	Khoa on SinhVien.MaKH = Khoa.MaKH
Where
	Khoa.MaKH = @MaKH;
GO

DECLARE @Diem FLOAT;
SET @Diem = 5.0;

SELECT
	SinhVien.MaSV AS N'Mã sinh viên',
	SinhVien.TenSV AS N'Tên sinh viên',
	MonHoc.TenMH AS N'Tên môn học',
	Ketqua.Diem AS N'Điểm'
FROM 
	SinhVien
JOIN 
	Ketqua ON SinhVien.MaSV = Ketqua.MaSV
JOIN
	MonHoc ON Ketqua.MaMH = MonHoc.MaMH
WHERE 
	MonHoc.TenMH = N'Cơ sở dữ liệu' and Ketqua.Diem > @Diem
GO


CREATE TABLE [dbo].[DELETETABLE](
	[MaSV] [nvarchar](3) NOT NULL,
	[HoSV] [nvarchar](15) NOT NULL,
	[TenSV] [nvarchar](7) NOT NULL,
	[Phai] [bit] NOT NULL,
	[NgaySinh] [smalldatetime] NOT NULL,
	[NoiSinh] [nvarchar](100) NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
	[HocBong] [float] NULL,
)
GO

INSERT [dbo].[DELETETABLE] ([MaSV], [HoSV], [TenSV], [Phai], [NgaySinh], [NoiSinh], [TenKH], [HocBong]) VALUES (N'A01', N'Nguyễn Thị', N'Vân', 0, CAST(N'1986-02-23T00:00:00' AS SmallDateTime), N'Hà Giang', N'KT', 130000, 5.1800000190734865)
INSERT [dbo].[DELETETABLE] ([MaSV], [HoSV], [TenSV], [Phai], [NgaySinh], [NoiSinh], [TenKH], [HocBong]) VALUES (N'A02', N'Trần Văn', N'Chính', 0, CAST(N'1994-12-20T00:00:00' AS SmallDateTime), N'Bình Định', N'TH', 150000, NULL)
INSERT [dbo].[DELETETABLE] ([MaSV], [HoSV], [TenSV], [Phai], [NgaySinh], [NoiSinh], [TenKH], [HocBong]) VALUES (N'A03', N'Lê Thu Bạch', N'Yến', 1, CAST(N'1993-02-21T00:00:00' AS SmallDateTime), N'Tp. HCM', N'TH', 0, NULL)
INSERT [dbo].[DELETETABLE] ([MaSV], [HoSV], [TenSV], [Phai], [NgaySinh], [NoiSinh], [TenKH], [HocBong]) VALUES (N'A04', N'Trần Anh', N'Tuấn', 0, CAST(N'1987-12-20T00:00:00' AS SmallDateTime), N'Hà Nội', N'AV', 80000, NULL)
INSERT [dbo].[DELETETABLE] ([MaSV], [HoSV], [TenSV], [Phai], [NgaySinh], [NoiSinh], [TenKH], [HocBong]) VALUES (N'A10', N'Trần Thị', N'Mai', 1, CAST(N'1994-10-04T00:00:00' AS SmallDateTime), N'Hà Nội', N'TH', 0, NULL)
INSERT [dbo].[DELETETABLE] ([MaSV], [HoSV], [TenSV], [Phai], [NgaySinh], [NoiSinh], [TenKH], [HocBong]) VALUES (N'A11', N'Nguyễn Thành', N'Nam', 0, CAST(N'2000-01-01T00:00:00' AS SmallDateTime), N'Cà Mau', N'AV', NULL, NULL)
INSERT [dbo].[DELETETABLE] ([MaSV], [HoSV], [TenSV], [Phai], [NgaySinh], [NoiSinh], [TenKH], [HocBong]) VALUES (N'A12', N'Nguyễn Quang', N'Quyền', 0, CAST(N'2001-01-01T00:00:00' AS SmallDateTime), N'Đồng Nai', N'DT', NULL, NULL)
INSERT [dbo].[DELETETABLE] ([MaSV], [HoSV], [TenSV], [Phai], [NgaySinh], [NoiSinh], [TenKH], [HocBong]) VALUES (N'B01', N'Hoàng Thanh', N'Mai', 1, CAST(N'1992-08-12T00:00:00' AS SmallDateTime), N'Hải Phòng', N'TR', 0, NULL)
INSERT [dbo].[DELETETABLE] ([MaSV], [HoSV], [TenSV], [Phai], [NgaySinh], [NoiSinh], [TenKH], [HocBong]) VALUES (N'B02', N'Trần Thị Thu', N'Thủy', 1, CAST(N'1990-01-02T00:00:00' AS SmallDateTime), N'Tp. HCM', N'AV', 80000, NULL)
INSERT [dbo].[DELETETABLE] ([MaSV], [HoSV], [TenSV], [Phai], [NgaySinh], [NoiSinh], [TenKH], [HocBong]) VALUES (N'B03', N'Đố Văn', N'Lâm', 0, CAST(N'1994-02-26T00:00:00' AS SmallDateTime), N'Bình Định', N'TR', 0, NULL)
INSERT [dbo].[DELETETABLE] ([MaSV], [HoSV], [TenSV], [Phai], [NgaySinh], [NoiSinh], [TenKH], [HocBong]) VALUES (N'B04', N'Bùi Kim', N'Dung', 0, CAST(N'1988-10-18T00:00:00' AS SmallDateTime), N'Hµ Néi', N'TH', 170000, NULL)
INSERT [dbo].[DELETETABLE] ([MaSV], [HoSV], [TenSV], [Phai], [NgaySinh], [NoiSinh], [TenKH], [HocBong]) VALUES (N'C01', N'Hà Quang', N'Anh', 0, CAST(N'1985-03-11T00:00:00' AS SmallDateTime), N'Tp. HCM', N'TR', 0, NULL)
INSERT [dbo].[DELETETABLE] ([MaSV], [HoSV], [TenSV], [Phai], [NgaySinh], [NoiSinh], [TenKH], [HocBong]) VALUES (N'C03', N'Lê Quang', N'Lưu', 0, CAST(N'1985-02-23T00:00:00' AS SmallDateTime), N'Hà Nội', N'TH', 0, NULL)
INSERT [dbo].[DELETETABLE] ([MaSV], [HoSV], [TenSV], [Phai], [NgaySinh], [NoiSinh], [TenKH], [HocBong]) VALUES (N'T03', N'Hoàng Thị Hải', N'Yến', 1, CAST(N'1989-09-10T00:00:00' AS SmallDateTime), N'Hà Nội', N'AV', 170000, NULL)
INSERT [dbo].[DELETETABLE] ([MaSV], [HoSV], [TenSV], [Phai], [NgaySinh], [NoiSinh], [TenKH], [HocBong]) VALUES (N'T06', N'Nguyễn Văn', N'Thắng', 0, CAST(N'1988-10-18T00:00:00' AS SmallDateTime), N'Hà Nội', N'AV', 1500000, NULL)
GO

DELETE FROM  [DELETETABLE] WHERE [HocBong] = null;
GO

UPDATE MonHoc
SET SoTiet = 45
WHERE TenMH = N'Tiếng Anh cơ bản';
GO

UPDATE SinhVien
SET TenSV = N'Trần Thanh Kỳ'
WHERE TenSV = N'Trần Thị Mai';
GO

UPDATE SinhVien
SET Phai = 0
WHERE TenSV = N'Trần Thanh Kỳ';
GO

UPDATE SinhVien
SET NgaySinh = '1990-07-05'
WHERE TenSV = N'Trần Thị Thu Thủy';
GO

UPDATE SinhVien
SET HocBong = HocBong + 100000
WHERE MaKH = N'AV';
GO

UPDATE Ketqua
SET Diem = CASE 
				WHEN Diem + 5 > 10 then 10
				ELSE Diem + 5
			END
WHERE MaMH = '02' AND MaSV IN (SELECT MaSV FROM SinhVien WHERE MaMH = 'AV')
GO

UPDATE SinhVien
SET HocBong = CASE 
				WHEN Phai = 1 AND MaKH = N'AV' THEN HocBong + 100000
				WHEN Phai = 0 AND MaKH = N'TH' THEN HocBong + 150000
				ELSE HocBong + 50000
			  END;


UPDATE Ketqua
SET Diem = CASE	
				WHEN MaSV IN (SELECT MaSV FROM SinhVien WHERE MaKH = N'AV') THEN LEAST(Diem + 2, 10)
				WHEN MaSV IN (SELECT MaSV FROM SinhVien WHERE MaKH = N'TH') THEN GREATEST(Diem - 1, 0)
				ELSE Diem
			END
WHERE MaMH = '01';
GO