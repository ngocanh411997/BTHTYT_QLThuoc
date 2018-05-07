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

alter table HoaDonNhap add TrangThai NVARCHAR(50)
alter table ChiTietHoaDonNhap add ThanhTien int 
-- thủ tục xem hóa đơn nhập
alter proc Xem_HDN
as
begin
select hd.MaHoaDon, TenNCC, NgayNhap,hd.MaNVNhap ,hd.TrangThai from HoaDonNhap hd , NhaCungCap
where hd.MaNCC = NhaCungCap.MaNCC and TrangThai =N'Chưa thanh toán'
end

-- thêm hóa đơn nhập
alter proc Them_HDN
( @MaHDN varchar(10), @MaNCC varchar(10), @NgayNhap date, @MaNVNhap varchar(10), @TrangThai nvarchar(50))
as
begin
insert into HoaDonNhap
values(@MaHDN, @MaNCC, @NgayNhap, @MaNVNhap, N'Chưa thanh toán')
end
go

-- sửa hóa đơn nhập
alter proc Sua_HDN
( @MaHDN varchar(10), @MaNCC varchar(10), @NgayNhap date, @MaNVNhap varchar(10),@TrangThai nvarchar(50))
as
begin
update HoaDonNhap
set MaNCC = @MaNCC, NgayNhap = @NgayNhap, MaNVNhap = @MaNVNhap, TrangThai = N'Chưa thanh toán' 
where MaHoaDon = @MaHDN
end
go

-- xóa hóa đơn nhập
alter proc Xoa_HDN(@MaHDN varchar(10))
as
begin
update ChiTietHoaDonNhap
set MaHDN = null
where MaHDN = @MaHDN
delete HoaDonNhap
where MaHoaDon = @MaHDN
end
go


-- showcomno cho mã nhà cung cấp
create proc Show_NCC
as
begin
select TenNCC, MaNCC
from NhaCungCap
end
go

-- show combo cho mã nhân viên
create proc Show_NV
as
begin
select MaNV
from NhanVien
end
go

--thêm chi tiết hóa đơn nhập
alter proc Them_CTHDN
( @MaHDN varchar(10), @MaThuoc varchar(10),@DVT nvarchar(50), @Gia bigint, @Soluong int, @ThanhTien int)
as
begin
insert into ChiTietHoaDonNhap
values (@MaHDN, @MaThuoc, @DVT, @Gia, @Soluong, @ThanhTien)
end
go

-- sửa chi tiết hóa đơn nhập
alter proc Sua_CTHDN
( @MaHDN varchar(10), @MaThuoc varchar(10),@DVT nvarchar(50), @Gia bigint, @Soluong int, @ThanhTien int)
as
begin
update ChiTietHoaDonNhap
set MaThuoc = @MaThuoc, DonViTinh = @DVT, Gia = @Gia, SoLuong = @Soluong, ThanhTien = @Gia * @Soluong
where MaHDN = @MaHDN and MaThuoc = @MaThuoc
end
go


-- xóa chi tiết hóa đơn nhập
alter proc Xoa_CTHDN(@MaHDN varchar(10), @MaThuoc varchar(10))
as
begin
delete ChiTietHoaDonNhap
where MaHDN = @MaHDN and MaThuoc = @MaThuoc
end
go


