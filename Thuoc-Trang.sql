-- Thủ tục lấy ra thông tin của Thuốc
create proc Xem_Thuoc
as
begin
select *from Thuoc
end
go
--test
EXEC Xem_Thuoc
go
-- thủ tục thêm thuốc
create proc Them_Thuoc
(
	@MaThuoc varchar(10),
	@TenThuoc nvarchar(50),
	@MaLoaiThuoc nvarchar(50),
	@MaDVSX nvarchar(10),
	@CongDung nvarchar(50),
	@HSD nvarchar(50),
	@SoLuong int,
	@NuocSX nvarchar(50)
)
as
begin
insert into Thuoc(MaThuoc,TenThuoc,MaLoaiThuoc,MaDVSX,CongDung,HSD,SoLuong,NuocSX)
values(@MaThuoc,@TenThuoc,@MaLoaiThuoc,@MaDVSX,@CongDung,@HSD,@SoLuong,@NuocSX)
end

go
-- thủ tục sửa Thuốc
create proc Sua_Thuoc
(
	@MaThuoc varchar(10),
	@TenThuoc nvarchar(50),
	@MaLoaiThuoc nvarchar(50),
	@MaDVSX nvarchar(10),
	@CongDung nvarchar(50),
	@HSD nvarchar(50),
	@SoLuong int,
	@NuocSX nvarchar(50))
as
begin
update Thuoc
set TenThuoc = @TenThuoc,
	MaLoaiThuoc = @MaLoaiThuoc,
	MaDVSX = @MaDVSX,
	CongDung=@CongDung,
	HSD=@HSD,
	SoLuong=@SoLuong,
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