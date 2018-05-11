ALTER TABLE dbo.Thuoc
DROP COLUMN SoLuong

ALTER TABLE dbo.Thuoc
ADD TTT NVARCHAR(2)

ALTER TABLE dbo.Thuoc 
ALTER COLUMN HSD DATE
-- Thủ tục lấy ra thông tin của Thuốc
ALTER proc Xem_Thuoc
as
begin
select MaThuoc,TenThuoc,TenLoaiThuoc,TenNCC,CongDung,HSD,NuocSX FROM dbo.Thuoc INNER JOIN dbo.LoaiThuoc ON LoaiThuoc.MaLoaiThuoc = Thuoc.MaLoaiThuoc INNER JOIN dbo.NhaCungCap ON NhaCungCap.MaNCC = Thuoc.MaDVSX
WHERE TTT='0'
end
go
--test
EXEC Xem_Thuoc
go
-- thủ tục thêm thuốc
ALTER proc Them_Thuoc
(
	@MaThuoc varchar(10),
	@TenThuoc nvarchar(50),
	@MaLoaiThuoc nvarchar(50),
	@MaDVSX nvarchar(10),
	@CongDung nvarchar(50),
	@HSD DATE,
	@NuocSX nvarchar(50),
	@TTT NVARCHAR(2)
)
as
begin
insert into Thuoc(MaThuoc,TenThuoc,MaLoaiThuoc,MaDVSX,CongDung,HSD,NuocSX,TTT)
values(@MaThuoc,@TenThuoc,@MaLoaiThuoc,@MaDVSX,@CongDung,@HSD,@NuocSX,'0')
end

go
-- thủ tục sửa Thuốc
ALTER proc Sua_Thuoc
(
	@MaThuoc varchar(10),
	@TenThuoc nvarchar(50),
	@MaLoaiThuoc nvarchar(50),
	@MaDVSX nvarchar(10),
	@CongDung nvarchar(50),
	@HSD DATE,
	@NuocSX nvarchar(50),
	@TTT NVARCHAR(2))
as
begin
update Thuoc
set TenThuoc = @TenThuoc,
	MaLoaiThuoc = @MaLoaiThuoc,
	MaDVSX = @MaDVSX,
	CongDung=@CongDung,
	HSD=@HSD,
	NuocSX=@NuocSX,
	TTT ='0'
where MaThuoc = @MaThuoc
END

go
-- thủ tục xóa Thuốc
ALTER proc Xoa_Thuoc(@MaThuoc varchar(10))
as
begin
delete dbo.ChiTietHoaDonXuat
WHERE MaThuoc=@MaThuoc AND MaHDX IN (SELECT MaHoaDon FROM dbo.HoaDonXuat WHERE TrangThai=N'Chưa thanh toán')
UPDATE dbo.Thuoc
SET TTT='1'
where MaThuoc = @MaThuoc
end
-----------