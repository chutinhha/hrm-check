USE [HRM_CHECKER]
GO
/****** Object:  Table [dbo].[tblTaiKhoan]    Script Date: 10/15/2014 18:38:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTaiKhoan](
	[MaTaiKhoan] [int] IDENTITY(1,1) NOT NULL,
	[LoaiTaiKhoan] [nvarchar](256) NULL,
	[LoaiTien] [nvarchar](256) NULL,
 CONSTRAINT [PK_tblTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaTaiKhoan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhachHang]    Script Date: 10/15/2014 18:38:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhachHang](
	[MaKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](256) NOT NULL,
	[TenVietTat] [nvarchar](256) NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [bit] NULL,
	[QuocTich] [nvarchar](256) NULL,
	[CMND] [nchar](15) NULL,
	[HoChieu] [nchar](15) NULL,
	[SoKhac] [nchar](15) NULL,
	[NgayCapCMND] [date] NULL,
	[NoiCapCMND] [nvarchar](256) NULL,
	[DiaChiLienHe] [nvarchar](256) NULL,
	[DiaChiThuongTru] [nvarchar](256) NULL,
	[DiaChiNuocNgoai] [nvarchar](256) NULL,
	[DienThoaiNha] [nchar](15) NULL,
	[DienThoaiDiDong] [nchar](15) NULL,
	[HopThu] [nchar](256) NULL,
	[IsDiHoc] [bit] NULL,
	[IsDiLam] [bit] NULL,
	[IsTuKinhDoanh] [bit] NULL,
	[IsNghiHuu] [bit] NULL,
	[NganhNghe] [nvarchar](256) NULL,
	[ChucVu] [nvarchar](256) NOT NULL,
	[DienThoaiCoQuan] [nchar](10) NULL,
	[TenCoQuan] [nvarchar](256) NULL,
	[TinhTrangHonNhan] [nvarchar](50) NULL,
	[TrinhDoHocVan] [nvarchar](50) NULL,
	[ThuNhap] [nvarchar](50) NULL,
	[MaTaiKhoan] [int] NULL,
 CONSTRAINT [PK_tblKhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_tblKhachHang_tblTaiKhoan]    Script Date: 10/15/2014 18:38:11 ******/
ALTER TABLE [dbo].[tblKhachHang]  WITH CHECK ADD  CONSTRAINT [FK_tblKhachHang_tblTaiKhoan] FOREIGN KEY([MaTaiKhoan])
REFERENCES [dbo].[tblTaiKhoan] ([MaTaiKhoan])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblKhachHang] CHECK CONSTRAINT [FK_tblKhachHang_tblTaiKhoan]
GO
