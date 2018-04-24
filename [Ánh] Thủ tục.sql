-- Thủ tục lấy danh sách NV
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
-- Xem CTHDX
GO
CREATE PROC CTHDX_SelectAll
AS
BEGIN
	SELECT * FROM dbo.ChiTietHoaDonXuat
END
-- Thêm CTHDX
GO
CREATE PROC ThemCTHDX(@MaHDX VARCHAR(10), @MaThuoc VARCHAR(10), @DonViTinh NVARCHAR(50), @Gia BIGINT,@SoLuong INT)
AS
BEGIN
	INSERT INTO dbo.ChiTietHoaDonXuat
	        ( MaHDX ,
	          MaThuoc ,
	          DonViTinh ,
	          Gia ,
	          SoLuong
	        )
	VALUES  ( @MaHDX,@MaThuoc,@DonViTinh,@Gia,@SoLuong)
END


-- Sửa CTHDX
GO
ALTER PROC SuaCTHDX(@MaHDX VARCHAR(10), @MaThuoc VARCHAR(10), @DonViTinh NVARCHAR(50), @Gia BIGINT,@SoLuong INT)
AS
BEGIN
	UPDATE dbo.ChiTietHoaDonXuat
	SET MaThuoc=@MaThuoc,DonViTinh=@DonViTinh,Gia=@Gia,SoLuong=@SoLuong
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
EXEC dbo.ThemCTHDX @MaHDX = 'DX04', -- varchar(10)
    @MaThuoc = 'T02', -- varchar(10)
    @DonViTinh = N'Vỉ', -- nvarchar(50)
    @Gia = 200, -- bigint
    @SoLuong = 20 -- int

EXEC dbo.XoaCTHDX @MaHDX = 'DX01', -- varchar(10)
    @MaThuoc = 'T06' -- varchar(10)


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
ALTER PROC [dbo].[XemHDTT]
AS
BEGIN
	SELECT * FROM dbo.HoaDonXuat WHERE TrangThai=N'Đã thanh toán'
END

--
GO
ALTER PROC [dbo].[XemHoaDonTT]
AS
BEGIN
	SELECT * FROM dbo.HoaDonXuat WHERE TrangThai=N'Đã thanh toán'
END