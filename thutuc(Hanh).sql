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
-- thủ tục thêm cơ sở
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
-- thủ tục sửa cơ sở
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
-- thủ tục xóa cơ sở
create proc Xoa_KhachHang(@MaKH varchar(10))
as
begin
delete KhachHang
where MaKH = @MaKH
end
