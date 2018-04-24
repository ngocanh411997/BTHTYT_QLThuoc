-- Thủ tục lấy ra thông tin của cơ sở
create proc Xem_CoSo
as
begin
select *from CoSo
end
go
--test
EXEC Xem_CoSo
go
-- thủ tục thêm cơ sở
create proc Them_CoSo
(
	@MaCS varchar(10),
	@TenCS nvarchar(50),
	@DiaChi nvarchar(50),
	@SDT varchar(11)
)
as
begin
insert into CoSo(MaCS, TenCS, DiaChi,SDT)
values(@MaCS,@TenCS,@DiaChi,@SDT)
end

go
-- thủ tục sửa cơ sở
create proc Sua_CoSo
(
	@MaCS varchar(10),
	@TenCS nvarchar(50),
	@DiaChi nvarchar(50),
	@SDT varchar(11)
)
as
begin
update CoSo
set TenCS = @TenCS,
	DiaChi = @DiaChi,
	SDT = @SDT
where MaCS = @MaCS
end
go
-- thủ tục xóa cơ sở
create proc Xoa_CoSo(@MaCS varchar(10))
as
begin
delete CoSo
where MaCS = @MaCS
end
go
-----------
--Hóa đơn
-- thủ tục xem hóa đơn nhập
create proc Xem_HDN
as
begin
select * from HoaDonNhap
end

-- thêm hóa đơn nhập
create proc Them_HDN
( @MaHDN varchar(10), @MaNCC varchar(10), @NgayNhap date, @MaNVNhap varchar(10))
as
begin
insert into HoaDonNhap
values(@MaHDN, @MaNCC, @NgayNhap, @MaNVNhap)
end
go

-- sửa hóa đơn nhập
create proc Sua_HDN
( @MaHDN varchar(10), @MaNCC varchar(10), @NgayNhap date, @MaNVNhap varchar(10))
as
begin
update HoaDonNhap
set MaNCC = @MaNCC, NgayNhap = @NgayNhap, MaNVNhap = @MaNVNhap
where MaHoaDon = @MaHDN
end
go

-- xóa hóa đơn nhập
create proc Xoa_HDN(@MaHDN varchar(10))
as
begin
update ChiTietHoaDonNhap
set MaHDN = null
where MaHDN = @MaHDN
delete HoaDonNhap
where MaHoaDon = @MaHDN
end
go


--Hóa đơn
--thêm chi tiết hóa đơn nhập
create proc Them_CTHDN
( @MaHDN varchar(10), @MaThuoc varchar(10),@DVT nvarchar(50), @Gia bigint, @Soluong int)
as
begin
insert into ChiTietHoaDonNhap
values (@MaHDN, @MaThuoc, @DVT, @Gia, @Soluong)
end
go

-- sửa chi tiết hóa đơn nhập
create proc Sua_CTHDN
( @MaHDN varchar(10), @MaThuoc varchar(10),@DVT nvarchar(50), @Gia bigint, @Soluong int)
as
begin
update ChiTietHoaDonNhap
set MaThuoc = @MaThuoc, DonViTinh = @DVT, Gia = @Gia, SoLuong = @Soluong
where MaHDN = @MaHDN and MaThuoc = @MaThuoc
end
go


-- xóa chi tiết hóa đơn nhập
create proc Xoa_CTHDN(@MaHDN varchar(10), @MaThuoc varchar(10))
as
begin
delete ChiTietHoaDonNhap
where MaHDN = @MaHDN and MaThuoc = @MaThuoc
end
go


