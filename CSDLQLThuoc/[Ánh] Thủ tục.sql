﻿-- Thủ tục lấy danh sách NV
GO
ALTER PROC NV_SelectAll
AS
BEGIN
	SELECT MaNV,TenNV,TenCS,GioiTinh,NgaySinh,NhanVien.SDT,NhanVien.DiaChi
	FROM dbo.NhanVien INNER JOIN dbo.CoSo ON CoSo.MaCS = NhanVien.MaCS
END
-- Thủ tục Thêm NV
GO
CREATE PROC ThemNV(@MaNV VARCHAR(10), @TenNV NVARCHAR(50), @MaCS VARCHAR(10), @GioiTinh NVARCHAR(5), @NgaySinh DATE,@SDT VARCHAR(11), @DiaChi NVARCHAR(50))
AS
BEGIN
	INSERT INTO dbo.NhanVien
	        ( MaNV ,
	          TenNV ,
	          MaCS ,
	          GioiTinh ,
	          NgaySinh ,
	          SDT ,
	          DiaChi
	        )
	VALUES  ( @MaNV,@TenNV,@MaCS,@GioiTinh,@NgaySinh,@SDT,@DiaChi)
END
-- Thủ tục Sửa NV
go
CREATE PROC SuaNV(@MaNV VARCHAR(10), @TenNV NVARCHAR(50), @MaCS VARCHAR(10), @GioiTinh NVARCHAR(5), @NgaySinh DATE,@SDT VARCHAR(11), @DiaChi NVARCHAR(50))
AS
BEGIN
	UPDATE dbo.NhanVien
	SET TenNV=@TenNV,MaCS=@MaCS,GioiTinh=@GioiTinh,NgaySinh=@NgaySinh,SDT=@SDT,DiaChi=@DiaChi
	WHERE MaNV=@MaNV
END
-- Thủ tục xóa NV
GO
CREATE PROC XoaNV(@MaNV VARCHAR(10))
AS
BEGIN
	DELETE dbo.NhanVien
	WHERE MaNV=@MaNV
END

SELECT * FROM dbo.NhanVien WHERE NgaySinh='10/10/1997'

-------------
-- Sửa bảng HDX
ALTER TABLE dbo.HoaDonXuat
ADD TrangThai NVARCHAR(50)

-- HoaDonXuat
-- Xem HDX
GO
ALTER PROC [dbo].[HDX_SelectAll]
AS
BEGIN
	SELECT * FROM dbo.HoaDonXuat WHERE TrangThai=N'Chưa thanh toán'
END
-- Thêm HĐX
GO
ALTER PROC [dbo].[ThemHDX](@MaHoaDon VARCHAR(10), @MaKH VARCHAR(10), @NgayXuat DATE, @MaNVXuat VARCHAR(10), @TrangThai NVARCHAR(50))
AS
BEGIN
	INSERT INTO dbo.HoaDonXuat
	        ( MaHoaDon, MaKH, NgayXuat, MaNVXuat,TrangThai )
	VALUES  ( @MaHoaDon,@MaKH,@NgayXuat,@MaNVXuat,N'Chưa thanh toán')
END
-- Sửa HĐX
GO
ALTER PROC [dbo].[SuaHDX](@MaHoaDon VARCHAR(10), @MaKH VARCHAR(10), @NgayXuat DATE, @MaNVXuat VARCHAR(10),@TrangThai NVARCHAR(50))
AS
BEGIN
	UPDATE dbo.HoaDonXuat
	SET MaKH=MaKH,NgayXuat=@NgayXuat,MaNVXuat=@MaNVXuat, TrangThai=N'Chưa thanh toán'
	WHERE MaHoaDon=@MaHoaDon
END
-- Xóa HĐX
GO
ALTER PROC XoaHDX(@MaHoaDon VARCHAR(10))
AS
BEGIN
	DELETE dbo.ChiTietHoaDonXuat
	WHERE MaHDX=@MaHoaDon
	DELETE dbo.HoaDonXuat
	WHERE MaHoaDon=@MaHoaDon
END
-- Sửa bảng CTHDX
ALTER TABLE dbo.ChiTietHoaDonXuat
ADD ThanhTien int
-- Xem CTHDX
GO
ALTER PROC CTHDX_SelectAll
AS
BEGIN
	SELECT MaHDX,MaThuoc,DonViTinh,Gia,SoLuong,ThanhTien FROM dbo.ChiTietHoaDonXuat INNER JOIN dbo.HoaDonXuat ON HoaDonXuat.MaHoaDon = ChiTietHoaDonXuat.MaHDX WHERE TrangThai='Chưa thanh toán'
END
-- Thêm CTHDX
GO
ALTER PROC ThemCTHDX(@MaHDX VARCHAR(10), @MaThuoc VARCHAR(10), @DonViTinh NVARCHAR(50), @Gia BIGINT,@SoLuong INT,@ThanhTien INT)
AS
BEGIN
	INSERT INTO dbo.ChiTietHoaDonXuat
	        ( MaHDX ,
	          MaThuoc ,
	          DonViTinh ,
	          Gia ,
	          SoLuong,
			  ThanhTien
	        )
	VALUES  ( @MaHDX,@MaThuoc,@DonViTinh,@Gia,@SoLuong,@Gia*@SoLuong)
END


-- Sửa CTHDX
GO
ALTER PROC SuaCTHDX(@MaHDX VARCHAR(10), @MaThuoc VARCHAR(10), @DonViTinh NVARCHAR(50), @Gia BIGINT,@SoLuong INT,@ThanhTien INT)
AS
BEGIN
	UPDATE dbo.ChiTietHoaDonXuat
	SET MaThuoc=@MaThuoc,DonViTinh=@DonViTinh,Gia=@Gia,SoLuong=@SoLuong,ThanhTien=@Gia*@SoLuong
	WHERE MaHDX=@MaHDX AND MaThuoc=@MaThuoc
END
-- Xóa CTHDX
GO
ALTER PROC XoaCTHDX(@MaHDX VARCHAR(10),@MaThuoc VARCHAR(10))
AS
BEGIN
	DELETE dbo.ChiTietHoaDonXuat
	WHERE MaHDX=@MaHDX AND MaThuoc=@MaThuoc
END

--


	SELECT MaHDX,MaThuoc,DonViTinh,Gia,SoLuong,ThanhTien=(Gia*SoLuong) 
	FROM dbo.ChiTietHoaDonXuat

	SELECT A.MaKH,TenKH,A.MaHoaDon,SUM(A.ThanhTien) 
	FROM dbo.KhachHang,(SELECT MaHoaDon,MaThuoc,DonViTinh,Gia,SoLuong,ThanhTien=(Gia*SoLuong),MaKH
						FROM dbo.ChiTietHoaDonXuat INNER JOIN dbo.HoaDonXuat ON HoaDonXuat.MaHoaDon = ChiTietHoaDonXuat.MaHDX
						WHERE MaHoaDon='') A
	WHERE A.MaKH=KhachHang.MaKH
	GROUP BY A.MaKH,TenKH,A.MaHoaDon

-- Thanh toán hóa đơn, chuyển từ trạng thái chưa thanh toán sang đã thanh toán
GO
CREATE PROC [dbo].[DaTT](@MaHoaDon VARCHAR(10),@TrangThai NVARCHAR(50))
AS
BEGIN
	UPDATE dbo.HoaDonXuat
	SET TrangThai=N'Đã thanh toán'
	WHERE MaHoaDon=@MaHoaDon
END
--Xem hóa đơn đã thanh toán
GO
CREATE PROC [dbo].[XemHDTT]
AS
BEGIN
	SELECT * FROM dbo.HoaDonXuat WHERE TrangThai=N'Đã thanh toán'
END

--
GO
CREATE PROC [dbo].[XemHoaDonTT]
AS
BEGIN
	SELECT * FROM dbo.HoaDonXuat WHERE TrangThai=N'Đã thanh toán'
END


SELECT MaHDX,TenThuoc, DonViTinh,ChiTietHoaDonXuat.SoLuong,Gia,ThanhTien FROM dbo.HoaDonXuat INNER JOIN dbo.ChiTietHoaDonXuat ON ChiTietHoaDonXuat.MaHDX = HoaDonXuat.MaHoaDon INNER JOIN dbo.Thuoc ON Thuoc.MaThuoc = ChiTietHoaDonXuat.MaThuoc
WHERE MaHDX=''

--
SELECT HoaDonXuat.MaKH,TenKH,MaHDX, SUM(ThanhTien) AS TongTien FROM dbo.HoaDonXuat INNER JOIN dbo.ChiTietHoaDonXuat ON ChiTietHoaDonXuat.MaHDX = HoaDonXuat.MaHoaDon INNER JOIN dbo.KhachHang ON KhachHang.MaKH = HoaDonXuat.MaKH
WHERE TrangThai=N'Đã thanh toán' AND MaHDX=''
GROUP BY HoaDonXuat.MaKH,TenKH,MaHDX


SELECT MaHDX,TenThuoc,DonViTinh,Gia,ChiTietHoaDonXuat.SoLuong,ThanhTien FROM dbo.ChiTietHoaDonXuat INNER JOIN dbo.Thuoc ON Thuoc.MaThuoc = ChiTietHoaDonXuat.MaThuoc

SELECT * FROM dbo.Thuoc WHERE TenThuoc NOT IN (SELECT TenThuoc FROM dbo.ChiTietHoaDonXuat INNER JOIN dbo.Thuoc ON Thuoc.MaThuoc = ChiTietHoaDonXuat.MaThuoc WHERE MaHDX='DX04') AND TTT='0'


SELECT * FROM dbo.ChiTietHoaDonNhap

GO
CREATE PROC KhoThuoc
AS
BEGIN
SELECT T.MaThuoc,T.TenThuoc, SL=N.SLN-X.SLX
FROM dbo.Thuoc T,(SELECT MaThuoc, SUM(SoLuong) AS SLN FROM dbo.ChiTietHoaDonNhap GROUP BY MaThuoc) N, (SELECT MaThuoc,SUM(SoLuong) AS SLX FROM dbo.ChiTietHoaDonXuat GROUP BY MaThuoc) X
WHERE N.MaThuoc=T.MaThuoc AND T.MaThuoc=X.MaThuoc
END

 IIF(IsNull(SUM(X1.SoLuong)), 0,  SUM(X1.SoLuong)) AS TonXuat,
            TonNhap - TonXuat AS Ton,

Alter PROC KhoThuoc
AS
BEGIN
SELECT T.MaThuoc,T.TenThuoc, 
 IIF(ISNULL(SUM(N.SoLuong)), 0,  SUM(N.SoLuong)) AS SLNhap,
 IIF(ISNULL(SUM(X.SoLuong)), 0,  SUM(X.SoLuong)) AS SLXuat,
 SLNhap-SLXuat AS SL
FROM dbo.Thuoc T,(SELECT MaThuoc, SoLuong FROM dbo.ChiTietHoaDonNhap GROUP BY MaThuoc) N, (SELECT MaThuoc,SoLuong FROM dbo.ChiTietHoaDonXuat GROUP BY MaThuoc) X
WHERE N.MaThuoc=T.MaThuoc AND T.MaThuoc=X.MaThuoc
GROUP BY T.MaThuoc,T.TenThuoc
END



SELECT * FROM dbo.ChiTietHoaDonNhap

SELECT * FROM dbo.ChiTietHoaDonXuat

-- DT ngày
GO
ALTER PROC DTNgay
AS
BEGIN
SELECT NgayXuat, SUM(ThanhTien) AS DTNgay FROM dbo.ChiTietHoaDonXuat INNER JOIN dbo.HoaDonXuat ON HoaDonXuat.MaHoaDon = ChiTietHoaDonXuat.MaHDX
WHERE TrangThai=N'Đã thanh toán'
 GROUP BY NgayXuat
END

-- KHVIP
GO
CREATE PROC KHVIP
AS
BEGIN
	SELECT TOP 3 A.MaKH,A.TenKH,A.CHITIEU
	FROM (SELECT KhachHang.MaKH,TenKH, SUM(ThanhTien) AS CHITIEU FROM dbo.KhachHang INNER JOIN dbo.HoaDonXuat ON HoaDonXuat.MaKH = KhachHang.MaKH INNER JOIN dbo.ChiTietHoaDonXuat ON ChiTietHoaDonXuat.MaHDX = HoaDonXuat.MaHoaDon
			GROUP BY KhachHang.MaKH,TenKH) A
END

SELECT MaHDX,MaNVXuat,NgayXuat,HoaDonXuat.MaKH,TenKH,SUM(ThanhTien) AS TongTien FROM dbo.ChiTietHoaDonXuat INNER JOIN dbo.HoaDonXuat ON HoaDonXuat.MaHoaDon = ChiTietHoaDonXuat.MaHDX INNER JOIN dbo.KhachHang ON KhachHang.MaKH = HoaDonXuat.MaKH WHERE MaHDX='DX04'
GROUP BY MaHDX,MaNVXuat,NgayXuat,HoaDonXuat.MaKH,TenKH


-----
CREATE FUNCTION [dbo].[ChuyenDoiUnicode] ( @strInput NVARCHAR(4000) )
 RETURNS NVARCHAR(4000) AS BEGIN 
 IF @strInput IS NULL RETURN @strInput
 IF @strInput = '' RETURN @strInput 
 DECLARE @RT NVARCHAR(4000) 
 DECLARE @SIGN_CHARS NCHAR(136) 
 DECLARE @UNSIGN_CHARS NCHAR (136) 
 SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) 
 SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
 DECLARE @COUNTER int 
 DECLARE @COUNTER1 int 
 SET @COUNTER = 1 
 WHILE (@COUNTER <=LEN(@strInput)) 
 BEGIN SET @COUNTER1 = 1 
 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
 BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
 BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
 ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) 
 BREAK END 
 SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END 
 SET @strInput = replace(@strInput,' ','-') 
 RETURN @strInput END
GO


go
CREATE PROC TKTenNV(@Ten NVARCHAR(50))
AS BEGIN
SELECT MaNV,TenNV,TenCS,GioiTinh,NgaySinh,NhanVien.SDT,NhanVien.DiaChi
	FROM dbo.NhanVien INNER JOIN dbo.CoSo ON CoSo.MaCS = NhanVien.MaCS
WHERE dbo.ChuyenDoiUnicode(TenNV) LIKE N'%'+dbo.ChuyenDoiUnicode(@Ten)+N'%' 
END

go
CREATE PROC TKGTNV(@Ten NVARCHAR(50))
AS BEGIN
SELECT MaNV,TenNV,TenCS,GioiTinh,NgaySinh,NhanVien.SDT,NhanVien.DiaChi
	FROM dbo.NhanVien INNER JOIN dbo.CoSo ON CoSo.MaCS = NhanVien.MaCS
WHERE dbo.ChuyenDoiUnicode(GioiTinh) LIKE N'%'+dbo.ChuyenDoiUnicode(@Ten)+N'%' 
END

go
CREATE PROC TKDCNV(@Ten NVARCHAR(50))
AS BEGIN
SELECT MaNV,TenNV,TenCS,GioiTinh,NgaySinh,NhanVien.SDT,NhanVien.DiaChi
	FROM dbo.NhanVien INNER JOIN dbo.CoSo ON CoSo.MaCS = NhanVien.MaCS
WHERE dbo.ChuyenDoiUnicode(NhanVien.DiaChi) LIKE N'%'+dbo.ChuyenDoiUnicode(@Ten)+N'%' 
END

go
CREATE PROC TKCSNV(@Ten NVARCHAR(50))
AS BEGIN
SELECT MaNV,TenNV,TenCS,GioiTinh,NgaySinh,NhanVien.SDT,NhanVien.DiaChi
	FROM dbo.NhanVien INNER JOIN dbo.CoSo ON CoSo.MaCS = NhanVien.MaCS
WHERE dbo.ChuyenDoiUnicode(TenCS) LIKE N'%'+dbo.ChuyenDoiUnicode(@Ten)+N'%' 
END

SELECT MaNV,TenNV,TenCS,GioiTinh,NgaySinh,NhanVien.SDT,NhanVien.DiaChi FROM dbo.NhanVien INNER JOIN dbo.CoSo ON CoSo.MaCS = NhanVien.MaCS WHERE NhanVien.SDT LIKE '%01688%'