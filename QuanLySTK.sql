create database QuanLySTK

use QuanLySTK

USE [QuanLySTK]
GO

/****** Object:  Table [dbo].[DANGNHAP]    Script Date: 6/29/2021 6:53:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

USE [QuanLySTK]
GO

/****** Object:  Table [dbo].[PHANQUYEN]    Script Date: 6/29/2021 6:54:40 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PHANQUYEN](
	[Loai] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
	[GiaoDich] [bit] NULL,
	[MoSo] [bit] NULL,
	[BaoCao] [bit] NULL,
	[ListNV] [bit] NULL,
	[ListKH] [bit] NULL,
	[CapTK] [bit] NULL,
	[ListSTK] [bit] NULL,
	[ThayDoi] [bit] NULL,
	[PhanQuyen] [bit] NULL,
 CONSTRAINT [PK_PHANQUYEN] PRIMARY KEY CLUSTERED 
(
	[Loai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO



CREATE TABLE [dbo].[DANGNHAP](
	[TenDN] [varchar](50) NOT NULL,
	[MatKhau] [varchar](50) NOT NULL,
	[TenHienThi] [nvarchar](50) NULL,
	[LoaiTK] [int] NOT NULL,
 CONSTRAINT [PK_DANGNHAP] PRIMARY KEY CLUSTERED 
(
	[TenDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[DANGNHAP]  WITH CHECK ADD  CONSTRAINT [FK_DANGNHAP_PHANQUYEN] FOREIGN KEY([LoaiTK])
REFERENCES [dbo].[PHANQUYEN] ([Loai])
GO

ALTER TABLE [dbo].[DANGNHAP] CHECK CONSTRAINT [FK_DANGNHAP_PHANQUYEN]
GO

USE [QuanLySTK]
GO

/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 6/29/2021 6:54:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Cmnd] [varchar](50) NULL,
	[SDT] [varchar](50) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QuanLySTK]
GO

/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 6/29/2021 6:54:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Cmnd] [varchar](50) NULL,
	[SDT] [varchar](50) NULL,
	[SoDu] [money] NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QuanLySTK]
GO

/****** Object:  Table [dbo].[LOAISO]    Script Date: 6/29/2021 6:54:27 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[LOAISO](
	[MaLS] [int] IDENTITY(1,1) NOT NULL,
	[TenLS] [nvarchar](50) NULL,
	[ToiThieu] [money] NULL,
	[ThoiHan] [int] NULL,
	[LaiSuat] [real] NULL,
	[TienGuiTT] [money] NULL,
	[ThoiGianTT] [int] NULL,
 CONSTRAINT [PK_LOAISO] PRIMARY KEY CLUSTERED 
(
	[MaLS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QuanLySTK]
GO

/****** Object:  Table [dbo].[GUITIEN]    Script Date: 6/29/2021 6:55:01 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

USE [QuanLySTK]
GO

/****** Object:  Table [dbo].[SOTIETKIEM]    Script Date: 6/29/2021 6:57:37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SOTIETKIEM](
	[MaSo] [int] IDENTITY(1,1) NOT NULL,
	[MaLS] [int] NULL,
	[MaKH] [int] NULL,
	[MaNV] [int] NULL,
	[NgayMo] [smalldatetime] NULL,
	[TienGui] [money] NULL,
 CONSTRAINT [PK_SOTIETKIEM] PRIMARY KEY CLUSTERED 
(
	[MaSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[SOTIETKIEM]  WITH CHECK ADD  CONSTRAINT [FK_SOTIETKIEM_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO

ALTER TABLE [dbo].[SOTIETKIEM] CHECK CONSTRAINT [FK_SOTIETKIEM_KHACHHANG]
GO

ALTER TABLE [dbo].[SOTIETKIEM]  WITH CHECK ADD  CONSTRAINT [FK_SOTIETKIEM_LOAISO] FOREIGN KEY([MaLS])
REFERENCES [dbo].[LOAISO] ([MaLS])
GO

ALTER TABLE [dbo].[SOTIETKIEM] CHECK CONSTRAINT [FK_SOTIETKIEM_LOAISO]
GO

ALTER TABLE [dbo].[SOTIETKIEM]  WITH CHECK ADD  CONSTRAINT [FK_SOTIETKIEM_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO

ALTER TABLE [dbo].[SOTIETKIEM] CHECK CONSTRAINT [FK_SOTIETKIEM_NHANVIEN]
GO



CREATE TABLE [dbo].[GUITIEN](
	[MaGui] [int] IDENTITY(1,1) NOT NULL,
	[TienGui] [money] NULL,
	[MaSo] [int] NULL,
	[MaNV] [int] NULL,
	[NgayGui] [smalldatetime] NULL,
 CONSTRAINT [PK_GUITIEN] PRIMARY KEY CLUSTERED 
(
	[MaGui] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[GUITIEN]  WITH CHECK ADD  CONSTRAINT [FK_GUITIEN_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO

ALTER TABLE [dbo].[GUITIEN] CHECK CONSTRAINT [FK_GUITIEN_NHANVIEN]
GO

ALTER TABLE [dbo].[GUITIEN]  WITH CHECK ADD  CONSTRAINT [FK_GUITIEN_SOTIETKIEM] FOREIGN KEY([MaSo])
REFERENCES [dbo].[SOTIETKIEM] ([MaSo])
GO

ALTER TABLE [dbo].[GUITIEN] CHECK CONSTRAINT [FK_GUITIEN_SOTIETKIEM]
GO

USE [QuanLySTK]
GO

/****** Object:  Table [dbo].[RUTTIEN]    Script Date: 6/29/2021 6:55:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RUTTIEN](
	[MaRut] [int] NOT NULL,
	[MaSo] [int] NULL,
	[TienRut] [money] NULL,
	[NgayRut] [smalldatetime] NULL,
	[MaNV] [int] NULL,
 CONSTRAINT [PK_RUTTIEN] PRIMARY KEY CLUSTERED 
(
	[MaRut] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[RUTTIEN]  WITH CHECK ADD  CONSTRAINT [FK_RUTTIEN_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO

ALTER TABLE [dbo].[RUTTIEN] CHECK CONSTRAINT [FK_RUTTIEN_NHANVIEN]
GO

ALTER TABLE [dbo].[RUTTIEN]  WITH CHECK ADD  CONSTRAINT [FK_RUTTIEN_SOTIETKIEM] FOREIGN KEY([MaSo])
REFERENCES [dbo].[SOTIETKIEM] ([MaSo])
GO

ALTER TABLE [dbo].[RUTTIEN] CHECK CONSTRAINT [FK_RUTTIEN_SOTIETKIEM]
GO

USE [QuanLySTK]
GO

/****** Object:  Table [dbo].[BAOCAO]    Script Date: 6/29/2021 6:55:20 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BAOCAO](
	[MaBC] [int] IDENTITY(1,1) NOT NULL,
	[Ngay] [smalldatetime] NULL,
	[MaLS] [int] NOT NULL,
	[TongThu] [money] NULL,
	[TongChi] [money] NULL,
	[SoMo] [int] NULL,
	[SoDong] [int] NULL,
	[ChenhLech] [money] NULL,
 CONSTRAINT [PK_BAOCAO] PRIMARY KEY CLUSTERED 
(
	[MaBC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[BAOCAO]  WITH CHECK ADD  CONSTRAINT [FK_BAOCAO_LOAISO] FOREIGN KEY([MaLS])
REFERENCES [dbo].[LOAISO] ([MaLS])
GO

ALTER TABLE [dbo].[BAOCAO] CHECK CONSTRAINT [FK_BAOCAO_LOAISO]
GO



USE [QuanLySTK]
GO

INSERT INTO [dbo].[LOAISO] ([TenLS],[ToiThieu],[ThoiHan],[LaiSuat],[TienGuiTT],[ThoiGianTT])
     VALUES (N'Kỳ hạn 3 tháng', 1000000, 3, 0.05, 100000, 0)
GO

INSERT INTO [dbo].[LOAISO] ([TenLS],[ToiThieu],[ThoiHan],[LaiSuat],[TienGuiTT],[ThoiGianTT])
     VALUES (N'Kỳ hạn 6 tháng', 1000000, 6, 0.055, 100000, 0)
GO

INSERT INTO [dbo].[LOAISO] ([TenLS],[ToiThieu],[ThoiHan],[LaiSuat],[TienGuiTT],[ThoiGianTT])
     VALUES (N'Không kỳ hạn', 1000000, 0, 0.005, 100000, 15)
GO

USE [QuanLySTK]
GO

INSERT INTO [dbo].[DANGNHAP]([TenDN],[MatKhau],[TenHienThi],[LoaiTK])VALUES ('admin','ISMvKXpXpadDiUoOSoAfww==','admin',1)
GO

USE [QuanLySTK]
GO

INSERT INTO [dbo].[PHANQUYEN]
           ([TenLoai]
           ,[GiaoDich]
           ,[MoSo]
           ,[BaoCao]
           ,[ListNV]
           ,[ListKH]
           ,[CapTK]
           ,[ListSTK]
           ,[ThayDoi])
     VALUES
           ('Admin',1,1,1,1,1,1,1,1)
GO

USE [QuanLySTK]
GO

--INSERT INTO [dbo].[BAOCAO] ([Ngay],[MaLS],[TongThu],[TongChi],[SoMo],[SoDong]) VALUES ('{0}',{1},0,0,0,0)
--GO

select LOAISO.MaLS [Mã loại sổ], TongThu [Tổng thu], TongChi [Tổng chi], SoMo [Sổ mở], SoDong [Sổ đóng], LOAISO.TenLS [Tên loại sổ] from BAOCAO, LOAISO where LOAISO.MaLS = BAOCAO.MaLS

USE [QuanLySTK]
GO

SELECT MaGui [Mã gửi], TienGui [Tiền gửi], MaSo [Mã sổ], MaNV [Mã nhân viên], NgayGui [Ngày gửi]
  FROM [dbo].[GUITIEN]
  where NgayGui = ''
GO

USE [QuanLySTK]
GO

--INSERT INTO [dbo].[SOTIETKIEM]([MaLS],[MaKH],[MaNV],[NgayMo],[TienGui])VALUES({0},{1},{2},'{3}',{4})
GO

alter TRIGGER TRG_InsertSTK
on SOTIETKIEM
for insert
as
begin
	Declare @MaLS int
	Declare @ngayMo smalldatetime
	Declare @maKH int
	Declare @tienGui money

	select @MaLS = MaLS, @maKH = MaKH, @ngayMo = NgayMo, @tienGui = TienGui from inserted

	update BAOCAO
	set TongThu = TongThu + @tienGui, SoMo = SoMo + 1, ChenhLech = ChenhLech + @tienGui
	where @MaLS = MaLS and Day(@ngayMo) = Day(Ngay) and month(@ngayMo) = month(Ngay) and year(@ngayMo) = year(Ngay)

	update KHACHHANG
	set SoDu = SoDu + @tienGui
	where @maKH = MaKH
end
go
select * from LOAISO

USE [QuanLySTK]
GO

--INSERT INTO [dbo].[PHANQUYEN]([TenLoai],[GiaoDich],[MoSo],[BaoCao],[ListNV],[ListKH],[CapTK],[ListSTK],[ThayDoi],[PhanQuyen])VALUES('admin',1,1,1,1,1,1,1,1,1)
--GO

select * from PHANQUYEN
select * from DANGNHAP
go

--select count(*) from DANGNHAP where TenDN = 'admin'

--select MaSo [Mã sổ], MaNV [Mã nhân viên], MaKH [Mã khách hàng], LOAISO.TenLS [Loại sổ], NgayMo [Ngày mở], TienGui [Tiền gửi] from SOTIETKIEM, LOAISO where SOTIETKIEM.MaLS = LOAISO.MaLS

--select count (*) from BAOCAO where MaLS = 1 and DAY(Ngay) = and MONTH(Ngay) = YEAR(Ngay) = 

--select * from KHACHHANG where MaKH = 1
--go

create trigger TRG_deleteSTK
on SOTIETKIEM
for delete
as 
begin
	Declare @maSo int
	select @maSo = MaSo from deleted

	Delete from RUTTIEN where @maSo = MaSo
	Delete from GUITIEN where @maSo = MaSo
end
go

--update LOAISO set TenLS = N'{0}', ToiThieu = {1}, ThoiHan = {2}, LaiSuat = {3}, TienGuiTT = {4}, ThoiGianTT = {5} where MaLS = {6}

create trigger TG_insertGoiTien
on GUITIEN for insert
as 
begin
	declare @maKH int
	declare @tienGoi money
	declare @maSo int

	select @maKH = MaKH from inserted,SOTIETKIEM where inserted.MaSo = SOTIETKIEM.MaSo
	select @maSo = MaSo from inserted
	select @tienGoi = TienGui from inserted

	update KHACHHANG
	set SoDu = SoDu + @tienGoi
	where @maKH = MaKH

	update SOTIETKIEM
	set TienGui = TienGui + @tienGoi
	where @maKH = MaKH and @maSo = MaSo

	update BAOCAO
	set TongThu = TongThu + @tienGoi, ChenhLech = ChenhLech + @tienGoi
	where MaLS in (select stk.MaLS from SOTIETKIEM stk where stk.MaSo = @maSo)
end
go

create proc [dbo].[insertGoiTien] 
@maNV int, @maSo int, @ngayGoi smalldatetime, @tienGoi money
as
begin
	insert into GUITIEN (MaNV, MaSo, NgayGui, TienGui)
	values (
		@maNV, @maSo, @ngayGoi, @tienGoi
	);
end;
GO