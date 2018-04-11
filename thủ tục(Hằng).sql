-- Thủ tục lấy ra thông tin của cơ sở
create proc Xem_CoSo
as
begin
select *from CoSo
end

--test
EXEC Xem_CoSo

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

-- thủ tục xóa cơ sở
create proc Xoa_CoSo(@MaCS varchar(10))
as
begin
delete CoSo
where MaCS = @MaCS
end
