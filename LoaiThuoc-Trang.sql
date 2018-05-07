-- Thủ tục lấy ra thông tin của Loại Thuốc
create proc Xem_LoaiThuoc
as
begin
select *from LoaiThuoc
end
go
--test
EXEC Xem_LoaiThuoc
go
-- thủ tục thêm loại thuốc
ALTER proc Them_LoaiThuoc
(
	@MaLoaiThuoc nvarchar(10),
	@TenLoaiThuoc nvarchar(50),
	@GhiChu nvarchar(50)
)
as
begin
insert into LoaiThuoc(MaLoaiThuoc,TenLoaiThuoc,GhiChu)
values(@MaLoaiThuoc,@TenLoaiThuoc,@GhiChu)
end

go
-- thủ tục sửa Loại Thuốc
create proc Sua_LoaiThuoc
(
	@MaLoaiThuoc varchar(10),
	@TenLoaiThuoc nvarchar(50),
	@GhiChu nvarchar(50))
	as
begin
update LoaiThuoc
set TenLoaiThuoc = @TenLoaiThuoc,
    GhiChu=@GhiChu

where MaLoaiThuoc = @MaLoaiThuoc
end
go
-- thủ tục xóa Loại Thuốc
create proc Xoa_LoaiThuoc(@MaLoaiThuoc varchar(10))
as
begin
delete LoaiThuoc
where MaLoaiThuoc = @MaLoaiThuoc
end
-----------

GO
CREATE PROC ShowNCC
AS
BEGIN
    SELECT * FROM dbo.NhaCungCap
END