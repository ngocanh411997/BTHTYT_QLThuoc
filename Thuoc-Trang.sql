ALTER TABLE dbo.Thuoc
DROP COLUMN SoLuong
-- Thủ tục lấy ra thông tin của Thuốc
ALTER proc Xem_Thuoc
as
begin
select MaThuoc,TenThuoc,TenLoaiThuoc,TenNCC,CongDung,HSD,NuocSX FROM dbo.Thuoc INNER JOIN dbo.LoaiThuoc ON LoaiThuoc.MaLoaiThuoc = Thuoc.MaLoaiThuoc INNER JOIN dbo.NhaCungCap ON NhaCungCap.MaNCC = Thuoc.MaDVSX
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
	@HSD nvarchar(50),
	@NuocSX nvarchar(50)
)
as
begin
insert into Thuoc(MaThuoc,TenThuoc,MaLoaiThuoc,MaDVSX,CongDung,HSD,NuocSX)
values(@MaThuoc,@TenThuoc,@MaLoaiThuoc,@MaDVSX,@CongDung,@HSD,@NuocSX)
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
	@HSD nvarchar(50),
	@NuocSX nvarchar(50))
as
begin
update Thuoc
set TenThuoc = @TenThuoc,
	MaLoaiThuoc = @MaLoaiThuoc,
	MaDVSX = @MaDVSX,
	CongDung=@CongDung,
	HSD=@HSD,
	NuocSX=@NuocSX
where MaThuoc = @MaThuoc
end
go
-- thủ tục xóa Thuốc
create proc Xoa_Thuoc(@MaThuoc varchar(10))
as
begin
delete Thuoc
where MaThuoc = @MaThuoc
end
-----------