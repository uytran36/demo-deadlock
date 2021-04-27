
create procedure sp_dirtyRead_trangThai2
as
begin
begin try
	begin tran t2
		select * from Nha where MaNha = '1'
	commit tran t2
end try
begin catch
	print N'Nỗi'
end catch
end
go
set transaction isolation level read committed
exec sp_dirtyRead_trangThai2

--------------------------------------------------------
create procedure sp_dirtyRead_lichSuXem2
as
begin
begin try
	begin tran t2
		select * from Xem where MaNha = '1'
	commit tran t2
end try
begin catch
	print N'Nỗi'
end catch
end
go

set transaction isolation level read committed
exec sp_dirtyRead_lichSuXem2

--------------------------------------------------------

create procedure sp_dirtyRead_chuNha2
as
begin
begin try
	begin tran t2
		select * from ChuNha where MaChuNha = '1'
	commit tran t2
end try
begin catch
	print N'Nỗi'
end catch
end
go

set transaction isolation level read committed
exec sp_dirtyRead_chuNha2

---------------------------------------------

CREATE PROCEDURE sp_unrepeatableRead_sdt2
AS
BEGIN
Begin try
	begin Tran t2
		select * from ChuNha where MaChuNha = '1'
		update ChuNha set SoDienThoai = '002' where MaChuNha = '1'
		commit tran t2
end try
begin catch
	print N'Lỗi'
end catch
END


exec sp_unrepeatableRead_sdt2


---------------------------------------------

CREATE PROCEDURE sp_unrepeatableRead_diaChi2
AS
BEGIN
Begin try
	begin Tran t2
		select * from KhachHang where MaKhachHang = '1'
		update KhachHang set Duong = N'Nguyễn Du' where MaKhachHang = '1'
		commit tran t2
end try
begin catch
	print N'Lỗi'
end catch
END


exec sp_unrepeatableRead_diaChi2

---------------------------------------------

CREATE PROCEDURE sp_unrepeatableRead_tinhTrang2
AS
BEGIN
Begin try
	begin Tran t2
		select * from Nha where MaNha = '1'
		update Nha set TinhTrang = 3 where MaNha = '1'
		commit tran t2
end try
begin catch
	print N'Lỗi'
end catch
END


exec sp_unrepeatableRead_tinhTrang2


---------------------------------------------
create procedure sp_phantom_nhanXet2
as
begin
begin try
	begin tran t2
		select * from ChiTietNhanXet where MaNha = '1'
		insert into ChiTietNhanXet values('5', '1', '1', 'Nhan xet 2')
	commit tran t2
end try
begin catch
	print N'Lỗi'
end catch
end
go

exec sp_phantom_nhanXet2
---------------------------------------------

create procedure sp_phantom_dsNha2
as
begin
begin try
	begin tran t2
		select * from Nha
		insert into Nha values('2', '2', '2', '2', '2', 2, 3, 1, '01/02/2003', '01/02/2005', '1', '1', '1', '1', '1', 0)
	commit tran t2
end try
begin catch
	print N'Lỗi'
end catch
end
go

exec sp_phantom_dsNha2

---------------------------------------------

create procedure sp_phantom_lsXem2
as
begin
begin try
	begin tran t2
		select * from Xem
		insert into Xem values('2', '1', '1', '01/02/2018');
	commit tran t2
end try
begin catch
	print N'Lỗi'
end catch
end
go

exec sp_phantom_lsXem2

---------------------------------------------

CREATE PROCEDURE sp_lostUpdate_nhanXet2
AS
BEGIN
declare @nd nvarchar(255)
Begin try
	set @nd = 'ABCD'
	begin Tran t2
		select * from ChiTietNhanXet WITH (XLOCK, ROWLOCK) where MaNhanXet = '1'
		update ChiTietNhanXet set NoiDung = N'ABCD' where MaNhanXet = '1'	
		
	commit Tran t2
end try
begin catch
	print N'Lỗi'
end catch
END
GO
Select * from ChiTietNhanXet where MaNhanXet = '1'
exec sp_lostUpdate_nhanXet2
drop proc sp_lostUpdate_nhanXet2
----------------------------------------------------------------

CREATE PROCEDURE sp_lostUpdate_sdt2
AS
BEGIN
declare @sdt nchar(10)
Begin try
	set @sdt = '12345'
	begin Tran t2
		select * from ChuNha WITH (XLOCK, ROWLOCK) where MaChuNha = '1'
		update ChuNha set SoDienThoai = @sdt where MaChuNha = '1'	
	commit Tran t2
end try
begin catch
	print N'Lỗi'
end catch
END
GO
Select * from ChuNha where MaChuNha = '1'
exec sp_lostUpdate_sdt2
drop procedure sp_lostUpdate_sdt2
----------------------------------------------------------------

CREATE PROCEDURE sp_lostUpdate_luotXem2
AS
BEGIN
declare @SLX int
Begin try
	
	begin Tran t2
		select @SLX = SoLuotXem from Nha WITH (XLOCK, ROWLOCK) where MaNha = '1'
		Set @SLX = @SLX + 1
		update Nha set SoLuotXem = @SLX where MaNha = '1'
		
	commit Tran t2
end try
begin catch
	print N'Lỗi'
end catch
END
GO
select * from Nha where MaNha = '1'	
exec sp_lostUpdate_luotXem2
drop proc sp_lostUpdate_luotXem2