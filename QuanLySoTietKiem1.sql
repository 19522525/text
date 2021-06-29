create database QuanLySoTietKiem1
go

USE [QuanLySoTietKiem1]
GO

/****** Object:  Table [dbo].[DANGNHAP]    Script Date: 6/11/2021 1:39:11 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DANGNHAP](
	[TenHienThi] [nvarchar](100) NOT NULL,
	[TenDN] [varchar](100) NOT NULL,
	[MatKhau] [varchar](100) NOT NULL,
	[Loai] [int] NOT NULL,
 CONSTRAINT [DANGNHAP_pk] PRIMARY KEY CLUSTERED 
(
	[TenDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QuanLySoTietKiem1]
GO

/****** Object:  Table [dbo].[DOANHTHU]    Script Date: 6/11/2021 1:39:21 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DOANHTHU](
	[MaLS] int identity NOT NULL,
	[LoaiSo] [varchar](50) NOT NULL,
	[TongThu] [money] NULL,
	[TongChi] [money] NULL,
	[ChenhLechThuChi] [money] NULL,
	[SoMo] [int] NULL,
	[SoDong] [int] NULL,
	[ChenhLechSoMD] [int] NULL,
	[Ngay] [smalldatetime] NOT NULL,
 CONSTRAINT [MaLS_pk] PRIMARY KEY CLUSTERED 
(
	[MaLS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QuanLySoTietKiem1]
GO

/****** Object:  Table [dbo].[GOITIEN]    Script Date: 6/11/2021 1:39:29 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[GOITIEN](
	[MaGT] int identity NOT NULL,
	[MaNV] int NULL,
	[MaKH] int NULL,
	[MaSo] int NULL,
	[NgayGoi] [smalldatetime] NOT NULL,
	[TienGoi] [money] NOT NULL,
 CONSTRAINT [GoiTien_pk] PRIMARY KEY CLUSTERED 
(
	[MaGT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[GOITIEN]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO

ALTER TABLE [dbo].[GOITIEN]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO

ALTER TABLE [dbo].[GOITIEN]  WITH CHECK ADD FOREIGN KEY([MaSo])
REFERENCES [dbo].[SOTIETKIEM] ([MaSo])
GO

USE [QuanLySoTietKiem1]
GO

/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 6/11/2021 1:39:57 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] int identity NOT NULL,
	[HoTen] [varchar](50) NOT NULL,
	[DiaChi] [varchar](100) NOT NULL,
	[SDT] [varchar](20) NOT NULL,
	[CMNN_or_HoChieu] [varchar](50) NOT NULL,
	[SoDu] [money] NULL,
 CONSTRAINT [KhachHang_pk] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QuanLySoTietKiem1]
GO

/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 6/11/2021 1:40:04 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] int identity NOT NULL,
	[HoTen] [varchar](50) NOT NULL,
	[DiaChi] [varchar](100) NOT NULL,
	[SDT] [varchar](20) NOT NULL,
	[CMNN_or_HoChieu] [varchar](50) NOT NULL,
	[LamViec] [bit] NULL,
 CONSTRAINT [NhanVien_pk] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QuanLySoTietKiem1]
GO

/****** Object:  Table [dbo].[RUTTIEN]    Script Date: 6/11/2021 1:40:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RUTTIEN](
	[MaRT] int identity NOT NULL,
	[MaNV] int NULL,
	[MaKH] int NULL,
	[MaSo] int NULL,
	[NgayRut] [smalldatetime] NOT NULL,
	[TienRut] [money] NOT NULL,
 CONSTRAINT [RutTien_pk] PRIMARY KEY CLUSTERED 
(
	[MaRT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[RUTTIEN]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO

ALTER TABLE [dbo].[RUTTIEN]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO

ALTER TABLE [dbo].[RUTTIEN]  WITH CHECK ADD FOREIGN KEY([MaSo])
REFERENCES [dbo].[SOTIETKIEM] ([MaSo])
GO

USE [QuanLySoTietKiem1]
GO

/****** Object:  Table [dbo].[SOTIETKIEM]    Script Date: 6/11/2021 1:40:18 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SOTIETKIEM](
	[MaSo] int identity NOT NULL,
	[MaNV] int NULL,
	[MaKH] int NULL,
	[MaLS] int NULL,
	[LoaiSo] [varchar](50) NOT NULL,
	[NgayMoSo] [smalldatetime] NOT NULL,
	[NgayHetHan] [smalldatetime] NOT NULL,
	[TienGoi] [money] NOT NULL,
 CONSTRAINT [SoTietKiem_pk] PRIMARY KEY CLUSTERED 
(
	[MaSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[SOTIETKIEM]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO

ALTER TABLE [dbo].[SOTIETKIEM]  WITH CHECK ADD FOREIGN KEY([MaLS])
REFERENCES [dbo].[DOANHTHU] ([MaLS])
GO

ALTER TABLE [dbo].[SOTIETKIEM]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO

USE [QuanLySoTietKiem1]
GO

/****** Object:  StoredProcedure [dbo].[insertAccount]    Script Date: 6/10/2021 1:27:58 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[insertAccount]
@tenHienThi varchar(50), @tenDN varchar(50), @matKhau varchar(50), @loai int
as
begin
	declare @countAccount int;
	select @countAccount = count(*) from DANGNHAP where TenDN = @tenDN

	if(@countAccount = 0)
	begin
		insert into DANGNHAP (TenHienThi, TenDN, MatKhau, Loai)
		values (
			@tenHienThi, @tenDN, @matKhau, @loai
		);
	end
end;
GO


insert into DANGNHAP (TenDN, TenHienThi, MatKhau)
values ('admin', 'admin', 'ISMvKXpXpadDiUoOSoAfww==')

USE [QuanLySoTietKiem1]
GO

/****** Object:  StoredProcedure [dbo].[searchAccount]    Script Date: 6/9/2021 10:36:52 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[searchAccount]
@tenDN varchar(50), @matKhau varchar(50)
as
begin
	select count(*) from DANGNHAP dn where dn.TenDN = @tenDN and dn.MatKhau = @matKhau
end;
GO



USE [QuanLySoTietKiem1]
GO

/****** Object:  StoredProcedure [dbo].[insertCustomer]    Script Date: 6/9/2021 10:37:35 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[insertCustomer]
@hoTen varchar(50), @diaChi varchar(50), @sDT varchar(50), @cmnd varchar(50), @soDu money
as
begin
	insert into KHACHHANG(HoTen, DiaChi, SDT, CMNN_or_HoChieu, SoDu)
	values (
		@hoTen, @diaChi, @sDT, @cmnd, @soDu
	);
end;
GO


USE [QuanLySoTietKiem1]
GO

/****** Object:  StoredProcedure [dbo].[searchCustomer]    Script Date: 6/9/2021 10:37:18 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[searchCustomer]
@maKH int
as 
begin 
	select * from KHACHHANG where MaKH = @maKH
end;
GO



USE [QuanLySoTietKiem1]
GO

/****** Object:  StoredProcedure [dbo].[insertSoTietKiem]    Script Date: 6/9/2021 10:35:32 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[insertSoTietKiem] 
@maNV varchar(50), @maKH varchar(50), @maLS varchar(50), @loaiSo varchar(50), @ngayMoSo smallDatetime, @ngayHetHan smallDatetime, @tienGoi money
as
begin 
	insert into SOTIETKIEM(MaNV, MaKH, MaLS, LoaiSo, NgayMoSo, NgayHetHan, TienGoi)
	values (
		@maNV, @maKH, @maLS, @loaiSo, @ngayMoSo, @ngayHetHan, @tienGoi
	)
	update DOANHTHU
	set SoMo = SoMo + 1, TongThu = TongThu + @tienGoi, ChenhLechThuChi = ChenhLechThuChi + @tienGoi
	where @maLS = MaLS

	update KHACHHANG
	set SoDu = SoDu + @tienGoi
	where @maKH = MaKH
end;
GO

USE [QuanLySoTietKiem1]
GO

/****** Object:  StoredProcedure [dbo].[insertStaff]    Script Date: 6/10/2021 1:28:58 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[insertStaff] 
@hoTen varchar(50), @diaChi varchar(50), @sdt varchar(50), @cmnd varchar(50)
as
begin
	insert into NHANVIEN(HoTen, DiaChi, SDT, CMNN_or_HoChieu, LamViec)
	values (
		@hoTen, @diaChi, @sdt, @cmnd, 1
	);
end;
GO



USE [QuanLySoTietKiem1]
GO

/****** Object:  StoredProcedure [dbo].[insertGoiTien]    Script Date: 6/10/2021 1:29:09 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[insertGoiTien] 
@maNV int, @maKH int, @maSo int, @ngayGoi smalldatetime, @tienGoi money
as
begin
	insert into GOITIEN (MaNV, MaKH, MaSo, NgayGoi, TienGoi)
	values (
		@maNV, @maKH, @maSo, @ngayGoi, @tienGoi
	);
end;
GO

create trigger TG_insertGoiTien
on GOITIEN for insert
as 
begin
	declare @maKH int
	declare @tienGoi money
	declare @maSo int

	select @maKH = MaKH from inserted
	select @maSo = MaSo from inserted
	select @tienGoi = TienGoi from inserted

	update KHACHHANG
	set SoDu = SoDu + @tienGoi
	where @maKH = MaKH

	update SOTIETKIEM
	set TienGoi = TienGoi + @tienGoi
	where @maKH = MaKH and @maSo = MaSo

	update DOANHTHU
	set TongThu = TongThu + @tienGoi, ChenhLechThuChi = ChenhLechThuChi + @tienGoi
	where MaLS in (select stk.MaLS from SOTIETKIEM stk where stk.MaSo = @maSo)
end
go


USE [QuanLySoTietKiem1]
GO

/****** Object:  StoredProcedure [dbo].[insertRutTien]    Script Date: 6/10/2021 1:29:25 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[insertRutTien] 
@maNV varchar(50), @maKH varchar(50), @maSo varchar(50), @ngayRut smalldatetime, @tienRut money
as
begin
	declare @soDu money;

	select @soDu = SoDu from KHACHHANG where MaKH = @maKH

	if(@soDu - @tienRut > 0)
	begin
		insert into RUTTIEN (MaNV, MaKH, MaSo, NgayRut, TienRut)
		values (
			@maNV, @maKH, @maSo, @ngayRut, @tienRut
		);
		update KHACHHANG
		set SoDu = SoDu - @tienRut
		where @maKH = MaKH

		update DOANHTHU
		set TongChi = TongChi + @tienRut, ChenhLechThuChi = ChenhLechThuChi - @tienRut
		where MaLS in (select stk.MaLS from SOTIETKIEM stk where stk.MaSo = @maSo)
	end

end;
GO

USE [QuanLySoTietKiem1]
GO

/****** Object:  StoredProcedure [dbo].[GetStaffInfo]    Script Date: 6/10/2021 1:29:36 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[GetStaffInfo]
@maNV int
as 
begin
	select * from NHANVIEN where @maNV = MaNV
end;
go

CREATE proc insertDoanhThu
@loaiSo varchar(50), @ngay smalldatetime
as
begin
	declare @count int
	select @count = count(*) from DOANHTHU where @ngay = Ngay
	if(@count = 0)
	begin
		insert into DOANHTHU (LoaiSo, TongThu, TongChi, ChenhLechThuChi, SoMo, SoDong, ChenhLechSoMD, Ngay)
		values (
			@loaiSo, 0, 0, 0, 0, 0, 0, @ngay
		)
	end
end;
go


create proc removeStaff
@maNV varchar(50)
as 
begin
	update NHANVIEN
	set LamViec = 0
	where MaNV = @maNV
end;
go

--select Loai from DANGNHAP where TenDN = 'admin'