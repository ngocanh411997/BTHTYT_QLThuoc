-- Thủ tục lấy ra thông tin của cơ sở
create proc Xem_KhachHang
as
begin
select *from KhachHang
end
go
--test
EXEC Xem_KhachHang
go
-- thủ tục thêm Khách hàng
create proc Them_KhachHang
(
	@MaKH varchar(10),
	@TenKH nvarchar(50),
	@DiaChi nvarchar(50),
	@SDT varchar(11)
)
as
begin
insert into KhachHang(MaKH, TenKH, DiaChi,SDT)
values(@MaKH,@TenKH,@DiaChi,@SDT)
end

go
-- thủ tục sửa Khách hàng
create proc Sua_KhachHang
(   
    @MaKH varchar(10),
	@TenKH nvarchar(50),
	@DiaChi nvarchar(50),
	@SDT varchar(11)
)
as
begin
update KhachHang
set TenKH = @TenKH,
	DiaChi = @DiaChi,
	SDT = @SDT
where MaKH = @MaKH
end
go
-- thủ tục xóa Khách hàng
create proc Xoa_KhachHang(@MaKH varchar(10))
as
begin
delete KhachHang
where MaKH = @MaKH
end
----------------
--Nhà cung cấp

create proc Xem_NhaCC
as
begin
select *from NhaCungCap
end
go
--test
EXEC Xem_NhaCC
go
-- thủ tục thêm cung cấp
create proc Them_NhaCC
(
	@MaNCC varchar(10),
	@TenNCC nvarchar(50),
	@DiaChi nvarchar(100),
	@SDT varchar(11)
)
as
begin
insert into NhaCungCap(MaNCC, TenNCC, DiaChi,SDT)
values(@MaNCC,@TenNCC,@DiaChi,@SDT)
end

go
-- thủ tục sửa cung cấp
create proc Sua_NhaCC
(   
    @MaNCC varchar(10),
	@TenNCC nvarchar(50),
	@DiaChi nvarchar(100),
	@SDT varchar(11)
)
as
begin
update NhaCungCap
set TenNCC = @TenNCC,
	DiaChi = @DiaChi,
	SDT = @SDT
where MaNCC = @MaNCC
end
go
-- thủ tục xóa nhà cung cấp
create proc Xoa_NhaCC(@MaNCC varchar(10))
as
begin
delete NhaCungCap
where MaNCC = @MaNCC
END

GO
CREATE PROC Xoa_NhaCungCap( @MaNCC varchar(10))
AS
BEGIN
ALTER table HoaDonNhap
nocheck constraint FK__HoaDonNha__MaNCC__25869641
delete HoaDonNhap where MaNCC = @MaNCC

alter table LopHocPhan
check constraint FK__HoaDonNha__MaNCC__25869641
END

CREATE proc Xoa_NhaCungCap( @MaNCC varchar(10))
as
begin
alter table HoaDonNhap
nocheck constraint FK__HoaDonNha__MaNCC__25869641
delete HoaDonNhap where MaNCC = @MaNCC
delete NhaCungCap where MaNCC = @MaNCC
alter table LopHocPhan
check constraint FK__HoaDonNha__MaNCC__25869641
end

