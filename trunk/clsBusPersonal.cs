﻿using System;
using System.Data; using System.Data.SqlClient;
using System.Configuration;

namespace HRM_CHECKER
{
	/// <summary>
	/// Summary description for clsBusPersonal.
	/// </summary>
	public class clsBusPersonal
	{

		//string strConn = "Server=QUYDA-PC;Database=HRM_CHECKER;Trusted_Connection=True";
		string strConn = "Server=QUYDA-PC;Database=HRM_CHECKER;Trusted_Connection=True";
		public string StrConn
		{
			get
			{
				return strConn;
			}
			set
			{
				strConn = value;
			}
		}		
		public clsBusPersonal()
		{
			//
			// TODO: Add constructor logic here
			//
			//string strConn = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=HRM_CHECKER;Data Source=QUYDA-PC;Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=QUYDA-PC;Use Encryption for Data=False;Tag with column collation when possible=False";			 			strConn = ConfigurationSettings.AppSettings["ConnectionString"]; 			if(strConn!=null && strConn != "") 			{ 				StrConn = strConn; 			} 			else 			{ 				//Xu ly sau 			} 			 						
		}

		public DataSet LoadPersonal()
		{
			 			//SqlDataReader reader =  SqlHelper.ExecuteReader(conn,CommandType.Text,"Select * from tblKhachHang"); 			SqlConnection conn = new SqlConnection(StrConn); 			DataSet ds = SqlHelper.ExecuteDataset(conn,CommandType.Text,"Select * from tblKhachHang"); 			if(ds!=null) 			{ 				ds.Tables[0].TableName = "tblKhachHang"; 				return ds; 			} 			else 			{ 				return null; 			} 			//dtgKhachHang.DataSource = ds.Tables[0];

		}

		public void LoadPersonalById(string personalID)
		{
			
		}

		/// <summary>
		/// Thêm khách hàng vào cở sở dữ liệu
		/// </summary>
		public void InsertPersonal(string HoTen,string TenTat,string NgaySinh,int GioiTinh,string QuocTich,string CMND,string HoChieu,string SoKhac,string ngayCap,string noiCap,string dcLienHe,string dcThuongTru,string dcNuocNgoai,string dtNha,string dtDiDong,string HopThu,int DiHoc,int DiLam,int tuKinhDoanh,int nghiHuu,string nganhNghe,string chucVu,string dtCoQuan,string tenCoQuan,string ttHonNhan,string ttHocVan,string thuNhap,int maTK,ref string pError)
		{
			try
			{
				DateTime dtNgaySinh = DateTime.Parse(NgaySinh);
				DateTime dtNgayCapCMT = DateTime.Parse(ngayCap);
				string strInsert = @"INSERT INTO [HRM_CHECKER].[dbo].[tblKhachHang]
				([HoTen]
				,[TenVietTat]
				,[NgaySinh]
				,[GioiTinh]
				,[QuocTich]
				,[CMND]
				,[HoChieu]
				,[SoKhac]
				,[NgayCapCMND]
				,[NoiCapCMND]
				,[DiaChiLienHe]
				,[DiaChiThuongTru]
				,[DiaChiNuocNgoai]
				,[DienThoaiNha]
				,[DienThoaiDiDong]
				,[HopThu]
				,[IsDiHoc]
				,[IsDiLam]
				,[IsTuKinhDoanh]
				,[IsNghiHuu]
				,[NganhNghe]
				,[ChucVu]
				,[DienThoaiCoQuan]
				,[TenCoQuan]
				,[TinhTrangHonNhan]
				,[TrinhDoHocVan]
				,[ThuNhap]
				)
				VALUES
				(N'"+HoTen+"',N'"+TenTat+"','"+NgaySinh+"',"+GioiTinh+",N'"+QuocTich+"',N'"+CMND+"',N'"+HoChieu+"',N'"+SoKhac+"','"+dtNgayCapCMT.ToString("yyyy-MM-dd")+"'"+",N'"+noiCap+"'"+",N'"+dcLienHe+"'"+",N'"+dcThuongTru+"'"+",N'"+dcNuocNgoai+"'"+",N'"+dtNha+"'"+",N'"+dtDiDong+"'"+",N'"+HopThu+"'"+","+DiHoc+","+DiLam+","+tuKinhDoanh+","+nghiHuu+",N'"+nganhNghe+"',N'"+chucVu+"'"+",N'"+dtCoQuan+"'"+",N'"+tenCoQuan+"'"+",N'"+ttHonNhan+"'"+",N'"+ttHocVan+"'"+",N'"+thuNhap+"')";
				string strQueryFill = strInsert.Replace("\r\n\t\t\t\t"," ");
				SqlConnection conn = new SqlConnection(StrConn); 				int kq = SqlHelper.ExecuteNonQuery(conn,CommandType.Text,strQueryFill);
				pError = "";
			}
			catch(Exception ex)
			{
				pError = ex.Message;
			}
		
		 			//			if(ds!=null) 			//			{ 			//				ds.Tables[0].TableName = "tblKhachHang"; 			//				return ds; 			//			} 			//			else 			//			{ 			//				return null; 			//			}

			//			,<NgayCapCMND, date,>
			//			,<NoiCapCMND, nvarchar(256),>
			//			,<DiaChiLienHe, nvarchar(256),>
			//			,<DiaChiThuongTru, nvarchar(256),>
			//			,<DiaChiNuocNgoai, nvarchar(256),>
			//			,<DienThoaiNha, nchar(15),>
			//			,<DienThoaiDiDong, nchar(15),>
			//			,<HopThu, nchar(256),>
			//			,<IsDiHoc, bit,>
			//			,<IsDiLam, bit,>
			//			,<IsTuKinhDoanh, bit,>
			//			,<IsNghiHuu, bit,>
			//			,<NganhNghe, nvarchar(256),>
			//			,<ChucVu, nvarchar(256),>
			//			,<DienThoaiCoQuan, nchar(10),>
			//			,<TenCoQuan, nvarchar(256),>
			//			,<TinhTrangHonNhan, nvarchar(50),>
			//			,<TrinhDoHocVan, nvarchar(50),>
			//			,<ThuNhap, nvarchar(50),>
			//			,<MaTaiKhoan, int,>)";

		}		
	}
}
