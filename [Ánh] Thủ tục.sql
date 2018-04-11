-- Thủ tục lấy danh sách NV
GO
CREATE PROC NV_SelectAll
AS
BEGIN
	SELECT * FROM dbo.NhanVien
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