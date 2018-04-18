-- Thủ tục lấy ra thông tin của khách hàng
create proc Xem_KhachHang
as
begin
select *from KhachHang
end
go
--test
EXEC Xem_KhachHang
go
-- thủ tục thêm khách hàng
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
-- thủ tục sửa khách hàng
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
-- thủ tục xóa khách hàng
create proc Xoa_KhachHang(@MaKH varchar(10))
as
begin
delete KhachHang
where MaKH = @MaKH
end
----------------
create proc Xem_KhachHang
as
begin
select *from KhachHang
end
go
--test
EXEC Xem_KhachHang
go
-- thủ tục thêm khách hàng
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
-- thủ tục sửa khách hàng
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
-- thủ tục xóa khách hàng
create proc Xoa_KhachHang(@MaKH varchar(10))
as
begin
delete KhachHang
where MaKH = @MaKH
end
----------------



--Nhà cung cấp
-- Thủ tục lấy ra thông tin của Nhà cung cấp
create proc Xem_NhaCungCap
as
begin
select *from NhaCungCap
end
go
--test
EXEC Xem_NhaCungCap
go
-- thủ tục thêm Nhà cung cấp
create proc Them_NhaCungCap
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
-- thủ tục sửa Nhà cung cấp
create proc Sua_NhaCungCap
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
create proc Xoa_NhaCungCap(@MaNCC varchar(10))
as
begin
delete NhaCungCap
where MaNCC = @MaNCC
end
----------------
