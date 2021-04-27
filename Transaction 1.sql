USE qlnd;
GO
CREATE PROCEDURE addBD
(
     @MaNha nchar(10), --tu tren xuong nhu db Diagrams
	 @Duong nvarchar(30),
	 @Quan nvarchar(30),
	 KhuVuc nvarchar(30),
	 ThanhPho nvarchar(30),
	 SoLuotXem int,
	 TinhTrang int,
	 SoPhong int,
	 NgayDang datetime,
	 @add10 datetime,
	 @add11 int,
	 @add12 int,
	 @add13 nchar(10),
	 @add14 nchar(10),
	 @add15 nchar(10),
	 @add16 int
)
AS
BEGIN
	SET NOCOUNT ON;
    BEGIN TRANSACTION T1;
		BEGIN TRY
			INSERT INTO dbo.Nha (MaNha, Duong, Quan, KhuVuc, ThanhPho, SoLuotXem, TinhTrang,SoPhong, NgayDang, NgayHetHan, GiaChoThueMotThang, GiaBan, MaChiNhanh, MaChuNha,MaLoaiNha, daXoa)
			VALUES (@MaNha, @add2, @add3, @add4, @add5, @add6, @add7, @add8, @add9, @add10, @add11, @add12, @add13, @add14, @add15, @add16);
		COMMIT TRANSACTION T1
	END TRY
       BEGIN CATCH
              -- if error, roll back any chanegs done by any of the sql statements
              ROLLBACK TRANSACTION T1
       END CATCH
END

GO
CREATE PROCEDURE updateBD
(
	 @add1 nchar(10), --tu tren xuong nhu db Diagrams
	 @add2 nvarchar(30),
	 @add3 nvarchar(30),
	 @add4 nvarchar(30),
	 @add5 nvarchar(30),
	 @add6 int,
	 @add7 int,
	 @add8 int,
	 @add9 datetime ,
	 @add10 datetime,
	 @add11 int,
	 @add12 int,
	 @add13 nchar(10),
	 @add14 nchar(10),
	 @add15 nchar(10),
	 @add16 int
)
AS
BEGIN
	SET NOCOUNT ON;
    BEGIN TRANSACTION T2;
		BEGIN TRY
			UPDATE dbo.Nha 
			SET Duong = @add2, 
				Quan = @add3,
				KhuVuc = @add4, 
				ThanhPho = @add5,
				SoLuotXem = @add6, 
				TinhTrang = @add7,
				SoPhong = @add8, 
				NgayDang = @add9, 
				NgayHetHan = @add10, 
				GiaChoThueMotThang = @add11, 
				GiaBan = @add12, 
				MaChiNhanh = @add13, 
				MaChuNha = @add14,
				MaLoaiNha = @add15, 
				daXoa = @add16
			WHERE MaNha = @add1; 
		COMMIT TRANSACTION T2
	END TRY
       BEGIN CATCH
              -- if error, roll back any chanegs done by any of the sql statements
              ROLLBACK TRANSACTION T2
       END CATCH
END

GO 
CREATE PROCEDURE addHD
(
	@add1 nchar(10),
	@add2 nchar(10),
	@add3 nchar(10),
	@add4 nchar(10),
	@add5 nchar(10),
	@add6 datetime,
	@add7 int,
	@add8 int
)
AS
BEGIN
	SET NOCOUNT ON;
    BEGIN TRANSACTION T3;
		BEGIN TRY
			INSERT INTO dbo.HopDong(MaHopDong, MaNhanVien, MaNha, MaChuNha,MaKhachHang, NgayLap, ThoiHan, TrangThaiHieuLuc) 
			VALUES (@add1, @add2, @add3, @add4, @add5, @add6, @add7, @add8)
			
			UPDATE Nha
			SET TinhTrang = 2
			WHERE MaNha = @add3;
		COMMIT TRANSACTION T3
	END TRY
       BEGIN CATCH
              -- if error, roll back any chanegs done by any of the sql statements
              ROLLBACK TRANSACTION T3
       END CATCH
END

GO
CREATE PROCEDURE updateHD
(
	@add1 nchar(10),
	@add2 nchar(10),
	@add3 nchar(10),
	@add4 nchar(10),
	@add5 nchar(10),
	@add6 datetime,
	@add7 int,
	@add8 int
)
AS
BEGIN
	SET NOCOUNT ON;
    BEGIN TRANSACTION T4;
		BEGIN TRY
			UPDATE dbo.HopDong
			SET MaNhanVien = @add2,
				MaNha = @add3,
				MaChuNha = @add4,
				MaKhachHang = @add5,
				NgayLap = @add6,
				ThoiHan = @add7,
				TrangThaiHieuLuc = @add8
			WHERE MaHopDong = @add1;
			
		COMMIT TRANSACTION T4
	END TRY
       BEGIN CATCH
              -- if error, roll back any chanegs done by any of the sql statements
              ROLLBACK TRANSACTION T4
       END CATCH
END
GO
/*
CREATE Role nvien
GRANT create table, create view TO nvien;

ALTER LOGIN nvien
WITH PASSWORD = 'nvien123';
*/
/*
CREATE LOGIN cnhanh
WITH PASSWORD = 'cnhanh' MUST_CHANGE, 
DEFAULT_DATABASE = qlnd,
CHECK_EXPIRATION = ON;


ALTER LOGIN cnhanh;
WITH PASSWORD = 'cnhanh';
*/

create procedure sp_insertLichSuThue
(
		@malichsu nchar(10),
		@makhachhang nchar(10),
		@manha nchar(10),
		@ngaythue datetime
)
as
begin
	begin transaction t1;
		begin try
			insert into LichSuThue values (@malichsu, @makhachhang, @manha, @ngaythue);
		end try
		begin catch
			rollback transaction t1;
		end catch
	commit transaction t1;
end

go

create procedure sp_insertLichSuBan
		@malichsu nchar(10),
		@makhachhang nchar(10),
		@manha nchar(10),
		@ngayban datetime
as
begin
	begin transaction t1
		begin try
			insert into LichSuBan values(@malichsu, @makhachhang, @manha, @ngayban)
		end try
		begin catch
			rollback transaction t1
		end catch
	commit transaction t1
end

go

create procedure sp_updateLichSuThue
		@malichsu nchar(10),
		@makhachhang nchar(10),
		@manha nchar(10),
		@ngaythue datetime
as
begin
	begin transaction t1
		begin try
			if exists(Select MaLichSuThue from LichSuThue where MaLichSuThue = @malichsu)
			begin
				update LichSuThue set MaKhachHang = @makhachhang, MaNha = @manha, NgayThue = @ngaythue
							  where MaLichSuThue = @malichsu
			end
		end try
		begin catch
			rollback transaction t1
		end catch
	commit transaction t1
end

go

create procedure sp_updateLichSuBan
		@malichsu nchar(10),
		@makhachhang nchar(10),
		@manha nchar(10),
		@ngayban datetime
as
begin
	begin transaction t1
		begin try
			if exists(Select MaLichSuBan from LichSuBan where MaLichSuBan = @malichsu)
			begin
				update LichSuThue set MaKhachHang = @makhachhang, MaNha = @manha, NgayThue = @ngayban
							  where MaLichSuThue = @malichsu
			end
		end try
		begin catch
			rollback transaction t1
		end catch
	commit transaction t1
end

go
/* 1.2.4 */
create procedure sp_insertNhanXet
		@manx nchar(10),
		@manha nchar(10),
		@makhachhang nchar(10),
		@noidung nvarchar(255)
as
begin
	begin transaction t1
		begin try
			insert into ChiTietNhanXet values(@manx, @manha, @makhachhang, @noidung)
		end try
		begin catch
			rollback transaction t1
		end catch
	commit transaction t1
end

go

create procedure sp_updateNhanXet
		@manx nchar(10),
		@manha nchar(10),
		@makhachhang nchar(10),
		@noidung nvarchar(255)
as
begin
	begin transaction t1
		begin try
			if exists(Select MaNhanXet from ChiTietNhanXet where MaNhanXet = @manx)
			begin
				update ChiTietNhanXet set MaKhachHang = @makhachhang, MaNha = @manha, NoiDung = @noidung
							  where MaNhanXet = @manx
			end
		end try
		begin catch
			rollback transaction t1
		end catch
	commit transaction t1
end

go

create procedure sp_deleteNhanXet
		@manx nchar(10),
		@manha nchar(10)
as
begin
	begin transaction t1
		begin try
			if exists(Select * from Nha where MaNha = @manha and daXoa = 1)
			begin
				delete from ChiTietNhanXet where MaNhanXet = @manx
			end
		end try
		begin catch
			rollback transaction t1
		end catch
	commit transaction t1
end

go
/* 1.2.5 */
create procedure sp_insertLichSuXem
		@malichsu nchar(10),
		@makhachhang nchar(10),
		@manha nchar(10),
		@ngayxem datetime
as
begin
	begin transaction t1
		begin try
			insert into Xem values(@malichsu, @makhachhang, @manha, @ngayxem)
		end try
		begin catch
			rollback transaction t1
		end catch
	commit transaction t1
end

go

create procedure sp_updateLichSuXem
		@malichsu nchar(10),
		@makhachhang nchar(10),
		@manha nchar(10),
		@ngayxem datetime
as
begin
	begin transaction t1
		begin try
			if exists(Select MaXem from Xem where MaXem = @malichsu)
			begin
				update Xem set MaKhachHang = @makhachhang, MaNha = @manha, NgayXem = @ngayxem
							  where MaXem = @malichsu
			end
		end try
		begin catch
			rollback transaction t1
		end catch
	commit transaction t1
end

go
/* 1.2.6 */
create procedure sp_insertChuNha
		@machunha nchar(10),
		@tenchunha nvarchar(30),
		@sdt nchar(10),
		@duong nvarchar(30),
		@quan nvarchar(30),
		@tp nvarchar(30),
		@khuvuc nvarchar(30),
		@daxoa int
as
begin
	begin transaction t1
		begin try
			insert into ChuNha values(@machunha, @tenchunha, @sdt, @duong, @quan, @tp, @khuvuc, @daxoa)
		end try
		begin catch
			rollback transaction t1
		end catch
	commit transaction t1
end

go

create procedure sp_updateChuNha
		@machunha nchar(10),
		@tenchunha nvarchar(30),
		@sdt nchar(10),
		@duong nvarchar(30),
		@quan nvarchar(30),
		@tp nvarchar(30),
		@khuvuc nvarchar(30),
		@daxoa int
as
begin
	begin transaction t1
		begin try
			if exists (select * from ChuNha where MaChuNha = @machunha)
			begin
				update ChuNha set TenChuNha = @tenchunha, SoDienThoai = @sdt, Duong = @duong, Quan = @quan, ThanhPho = @tp, KhuVuc = @khuvuc, daXoa = @daxoa
							  where MaChuNha = @machunha
			end
		end try
		begin catch
			rollback transaction t1
		end catch
	commit transaction t1
end
go

CREATE PROCEDURE sp_addnv
(
	@add1 nchar(10), --ten truong tuong ung voi trong bang add1 - MaNhanVien, add2 - TenNhanVien
	@add2 nvarchar(30),
	@add3 date,
	@add4 nvarchar(10),
	@add5 nvarchar(30),
	@add6 nvarchar(30),
	@add7 nvarchar(30),
	@add8 nvarchar(30),
	@add9 nchar(10),
	@add10 nchar(10),
	@add11 int
)
AS
BEGIN
	BEGIN TRAN T1;
	INSERT INTO dbo.NhanVien(MaNhanVien, TenNhanVien, NgaySinh, GioiTinh, Duong, Quan, ThanhPho, KhuVuc, SoDienThoai, MaChiNhanh, daXoa) 
	VALUES (@add1, @add2, @add3, @add4, @add5, @add6, @add7, @add8, @add9, @add10, @add11) 
	COMMIT TRAN T1;
END
GO

CREATE PROCEDURE sp_updatenv
(
	@add1 nchar(10), --ten truong tuong ung voi trong bang add1 - MaNhanVien, add2 - TenNhanVien
	@add2 nvarchar(30),
	@add3 date,
	@add4 nvarchar(10),
	@add5 nvarchar(30),
	@add6 nvarchar(30),
	@add7 nvarchar(30),
	@add8 nvarchar(30),
	@add9 nchar(10),
	@add10 nchar(10),
	@add11 int
)
AS
BEGIN
	BEGIN TRAN T1;
	UPDATE NhanVien
	SET TenNhanVien = @add2, NgaySinh = @add3, GioiTinh = @add4, Duong = @add5, Quan = @add6, ThanhPho = @add7, KhuVuc = @add8, SoDienThoai = @add9, MaChiNhanh = @add10, daXoa = @add11 
	WHERE MaNhanVien = @add1;
	COMMIT TRAN T1;
END
GO

CREATE PROCEDURE sp_addkh
(
	@add1 nchar(10), --ten truong tuong ung voi trong bang add1 - MaNhanVien, add2 - TenNhanVien
	@add2 nvarchar(30),
	@add3 nvarchar(30),
	@add4 nvarchar(30),
	@add5 nvarchar(30),
	@add6 nvarchar(30),
	@add7 nchar(10),
	@add8 nvarchar(30),
	@add9 nvarchar(30),
	@add10 nchar(10),
	@add11 nchar(10),
	@add12 int
)
AS
BEGIN
	BEGIN TRAN T1;
	INSERT INTO dbo.KhachHang(MaKhachHang, TenKhachHang, Duong, Quan, ThanhPho, KhuVuc, SoDienThoai, ThongTinNhaYeuCau, TieuChi, MaChiNhanh, MaNhanVien, daXoa) 
	VALUES (@add1, @add2, @add3, @add4, @add5, @add6, @add7, @add8, @add9, @add10, @add11, @add12) 
	COMMIT TRAN T1;
END
GO

CREATE PROCEDURE sp_updatekh
(
	@add1 nchar(10), --ten truong tuong ung voi trong bang add1 - MaNhanVien, add2 - TenNhanVien
	@add2 nvarchar(30),
	@add3 nvarchar(30),
	@add4 nvarchar(30),
	@add5 nvarchar(30),
	@add6 nvarchar(30),
	@add7 nchar(10),
	@add8 nvarchar(30),
	@add9 nvarchar(30),
	@add10 nchar(10),
	@add11 nchar(10),
	@add12 int
)
AS
BEGIN
	BEGIN TRAN T1;
	UPDATE KhachHang
	SET TenKhachHang = @add2, Duong = @add3, Quan = @add4, ThanhPho = @add5, KhuVuc = @add6, SoDienThoai = @add7, ThongTinNhaYeuCau = @add8, TieuChi = @add9, MaChiNhanh = @add10, MaNhanVien = @add11, daXoa = @add12 
	WHERE MaKhachHang = @add1;
	COMMIT TRAN T1;
END
GO


CREATE PROCEDURE sp_xemkh
AS
BEGIN
	BEGIN TRAN T1;
	SELECT * FROM KhachHang
	COMMIT TRAN T1;
END
GO

CREATE PROCEDURE sp_xemlsthue
AS
BEGIN
	BEGIN TRAN T1;
	SELECT * FROM LichSuThue
	COMMIT TRAN T1;
END
GO

CREATE PROCEDURE sp_xemln
AS
BEGIN
	BEGIN TRAN T1;
	SELECT * FROM LoaiNha
	COMMIT TRAN T1;
END
GO

CREATE PROCEDURE sp_xemctnx
AS
BEGIN
	BEGIN TRAN T1;
	SELECT * FROM ChiTietNhanXet
	COMMIT TRAN T1;
END
GO

CREATE PROCEDURE sp_xemxn
AS
BEGIN
	BEGIN TRAN T1;
	SELECT * FROM Xem
	COMMIT TRAN T1;
END
GO

CREATE PROCEDURE sp_xemlsban
AS
BEGIN
	BEGIN TRAN T1;
	SELECT * FROM LichSuBan
	COMMIT TRAN T1;
END
GO

CREATE PROCEDURE sp_xemnha
AS
BEGIN
	BEGIN TRAN T1;
	SELECT * FROM Nha
	COMMIT TRAN T1;
END
GO

CREATE PROCEDURE sp_xemnv
AS
BEGIN
	BEGIN TRAN T1;
	SELECT * FROM NhanVien
	COMMIT TRAN T1;
END
GO

CREATE PROCEDURE sp_xemcn
AS
BEGIN
	BEGIN TRAN T1;
	SELECT * FROM ChuNha
	COMMIT TRAN T1;
END
GO

CREATE PROCEDURE sp_xemhd
AS
BEGIN
	BEGIN TRAN T1;
	SELECT * FROM HopDong
	COMMIT TRAN T1;
END
GO

CREATE PROCEDURE sp_xemlsdang
AS
BEGIN
	BEGIN TRAN T1;
	SELECT * FROM LichSuDang
	COMMIT TRAN T1;
END
GO
--------------------------------------------------------
CREATE PROCEDURE sp_dirtyRead_trangThai
AS
BEGIN
Begin try
	begin Tran t1
		Update Nha set TinhTrang = 4 where MaNha = '1'
		waitfor delay '00:00:10'
		rollback tran t1
end try
begin catch
	print N'Lỗi'
end catch

END
GO
select * from Nha where MaNha = '1'
exec sp_dirtyRead_trangThai

----------------------------------------------------------------

CREATE PROCEDURE sp_dirtyRead_lichSuXem
AS
BEGIN
Begin try
	begin Tran t1
		Update Xem set NgayXem = '01/01/2000' where MaXem = '1'
		waitfor delay '00:00:10'
		rollback tran t1
end try
begin catch
	print N'Lỗi'
end catch

END
GO
exec sp_dirtyRead_lichSuXem
select * from Xem where MaXem = '1'

drop proc sp_dirtyRead_lichSuXem

----------------------------------------------------------------

CREATE PROCEDURE sp_dirtyRead_chuNha
AS
BEGIN
Begin try
	begin Tran t1
		Update ChuNha set TenChuNha = N'Khoa' where MaChuNha = '1'
		waitfor delay '00:00:10'
		rollback tran t1
end try
begin catch
	print N'Lỗi'
end catch

END
GO
exec sp_dirtyRead_chuNha
select * from ChuNha where MaChuNha = '1'

----------------------------------------------------------------

CREATE PROCEDURE sp_unrepeatableRead_sdt
AS
BEGIN
Begin try
	begin Tran t1
		select * from ChuNha where MaChuNha = '1'
		waitfor delay '00:00:10'
		select * from ChuNha where MaChuNha = '1'
		commit tran t1
end try
begin catch
	print N'Lỗi'
end catch
END

set transaction isolation level repeatable read
exec sp_unrepeatableRead_sdt

----------------------------------------------------------------

CREATE PROCEDURE sp_unrepeatableRead_diaChi
AS
BEGIN
Begin try
	begin Tran t1
		select * from KhachHang where MaKhachHang = '1'
		waitfor delay '00:00:10'
		select * from KhachHang where MaKhachHang = '1'
		commit tran t1
end try
begin catch
	print N'Lỗi'
end catch
END

set transaction isolation level repeatable read
exec sp_unrepeatableRead_diaChi

----------------------------------------------------------------

CREATE PROCEDURE sp_unrepeatableRead_tinhTrang
AS
BEGIN
Begin try
	begin Tran t1
		select * from Nha where MaNha = '1'
		waitfor delay '00:00:10'
		select * from Nha where MaNha = '1'
		commit tran t1
end try
begin catch
	print N'Lỗi'
end catch
END

set transaction isolation level repeatable read
exec sp_unrepeatableRead_tinhTrang

----------------------------------------------------------------

CREATE PROCEDURE sp_phantom_nhanXet
AS
BEGIN
Begin try
	begin Tran t1
		select * from ChiTietNhanXet where MaNha = '1'
		insert into ChiTietNhanXet values('4', '1', '1', 'Nhan xet 3')
		waitfor delay '00:00:10'
		select * from ChiTietNhanXet where MaNha = '1'
	commit tran t1
end try
begin catch
	print N'Lỗi'
end catch

END
GO

set transaction isolation level serializable
exec sp_phantom_nhanXet

----------------------------------------------------------------

CREATE PROCEDURE sp_phantom_dsNha
AS
BEGIN
Begin try
	begin Tran t1
		select * from Nha 
		waitfor delay '00:00:10'
		select * from Nha
	commit tran t1
end try
begin catch
	print N'Lỗi'
end catch

END
GO

set transaction isolation level serializable
exec sp_phantom_dsNha

----------------------------------------------------------------

CREATE PROCEDURE sp_phantom_lsXem
AS
BEGIN
Begin try
	begin Tran t1
		select * from Xem 
		waitfor delay '00:00:10'
		select * from Xem
	commit tran t1
end try
begin catch
	print N'Lỗi'
end catch

END
GO

set transaction isolation level serializable
exec sp_phantom_lsXem

----------------------------------------------------------------

CREATE PROCEDURE sp_lostUpdate_nhanXet
AS
BEGIN
declare @nd nvarchar(255)
Begin try
	set @nd = 'ABCDEF'
	begin Tran t	
		select * from ChiTietNhanXet WITH (XLOCK, ROWLOCK) where MaNhanXet = '1'
		waitfor delay '00:00:10'
		update ChiTietNhanXet set NoiDung = @nd where MaNhanXet = '1'	
	commit Tran t1
	
end try
begin catch
	print N'Lỗi'
end catch
END
GO
Select * from ChiTietNhanXet where MaNhanXet = '1'
exec sp_lostUpdate_nhanXet
drop proc sp_lostUpdate_nhanXet
----------------------------------------------------------------

CREATE PROCEDURE sp_lostUpdate_sdt
AS
BEGIN
declare @sdt nchar(10)
Begin try
	set @sdt = '1234'
	begin Tran t1	
		select * from ChuNha WITH (XLOCK, ROWLOCK) where MaChuNha = '1' 
		waitfor delay '00:00:10'
		update ChuNha set SoDienThoai = @sdt where MaChuNha = '1'
			
	commit Tran t1
end try
begin catch
	print N'Lỗi'
end catch
END
GO
Select * from ChuNha where MaChuNha = '1'
exec sp_lostUpdate_sdt
drop procedure sp_lostUpdate_sdt
----------------------------------------------------------------

CREATE PROCEDURE sp_lostUpdate_luotXem
AS
BEGIN
declare @SLX int
Begin try
	begin Tran t1
		select @SLX = SoLuotXem from Nha WITH (XLOCK, ROWLOCK) where MaNha = '1'
		Set @SLX = @SLX + 1
		waitfor delay '00:00:10'
		update Nha set SoLuotXem = @SLX where MaNha = '1'		
	commit Tran t1
end try
begin catch
	print N'Lỗi'
end catch
END
GO
select * from Nha where MaNha = '1'	
exec sp_lostUpdate_luotXem
drop proc sp_lostUpdate_luotXem