ALTER TABLE dbo.LoaiThuoc
ADD TTLT NVARCHAR(2)
-- Thủ tục lấy ra thông tin của Loại Thuốc
ALTER proc Xem_LoaiThuoc
as
begin
select MaLoaiThuoc,TenLoaiThuoc,GhiChu FROM LoaiThuoc
WHERE TTLT='0'
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
	@GhiChu nvarchar(50),
	@TTLT NVARCHAR(2)
)
as
begin
insert into LoaiThuoc(MaLoaiThuoc,TenLoaiThuoc,GhiChu,TTLT)
values(@MaLoaiThuoc,@TenLoaiThuoc,@GhiChu,'0')
end

go
-- thủ tục sửa Loại Thuốc
ALTER proc Sua_LoaiThuoc
(
	@MaLoaiThuoc varchar(10),
	@TenLoaiThuoc nvarchar(50),
	@GhiChu nvarchar(50),
	@TTLT NVARCHAR(2))
	as
begin
update LoaiThuoc
set TenLoaiThuoc = @TenLoaiThuoc,
    GhiChu=@GhiChu,
	TTLT='0'
where MaLoaiThuoc = @MaLoaiThuoc
end
go
-- thủ tục xóa Loại Thuốc
ALTER proc Xoa_LoaiThuoc(@MaLoaiThuoc varchar(10))
as
BEGIN
UPDATE dbo.Thuoc
SET TTT='1'
WHERE MaLoaiThuoc=@MaLoaiThuoc
UPDATE LoaiThuoc
SET TTLT ='1'
where MaLoaiThuoc = @MaLoaiThuoc
end
-----------

GO
CREATE PROC ShowNCC
AS
BEGIN
    SELECT * FROM dbo.NhaCungCap
END