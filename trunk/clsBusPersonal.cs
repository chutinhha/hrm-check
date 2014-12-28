using System;
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
			 			//SqlDataReader reader =  SqlHelper.ExecuteReader(conn,CommandType.Text,"Select * from tblKhachHang"); 			SqlConnection conn = new SqlConnection(StrConn); 			DataSet ds = SqlHelper.ExecuteDataset(conn,CommandType.Text,"Select * from tblKhachHang"); 			if(ds!=null) 			{ 				ds.Tables[0].TableName = "tblKhachHangs"; 				return ds; 			} 			else 			{ 				return null; 			} 			//dtgKhachHang.DataSource = ds.Tables[0];

		}

		public DataSet LoadPersonalById(string personalID)
		{
			SqlConnection conn = new SqlConnection(StrConn); 			DataSet ds = SqlHelper.ExecuteDataset(conn,CommandType.Text,"Select * from tblKhachHang where makhachhang =N'"+personalID+"'"); 			if(ds!=null) 			{ 				ds.Tables[0].TableName = "tblKhachHang"; 				return ds; 			} 			else 			{ 				return null; 			}
			
		}

		
		/// <summary>
		/// Thêm khách hàng vào cở sở dữ liệu
		/// </summary>
		public void InsertPersonal(string HoTen,string TenTat,string NgaySinh,int GioiTinh,string QuocTich,string CMND,string HoChieu,string SoKhac,string ngayCap,string noiCap,string dcLienHe,string dcThuongTru,string dcNuocNgoai,string dtNha,string dtDiDong,string HopThu,int DiHoc,int DiLam,int tuKinhDoanh,int nghiHuu,string nganhNghe,string chucVu,string dtCoQuan,string tenCoQuan,string ttHonNhan,string ttHocVan,string thuNhap,int maTK, string CMNDMoi_MatTruoc, string CMNDMoi_MatSau, string CMNDMoi_VanTay1, string CMNDMoi_VanTay2, string CMNDCu_MatTruoc, string CMNDCu_MatSau, string CMNDCu_VanTay1, string CMNDCu_VanTay2, ref string pError)
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
				,[CMNDMoi_MatTruoc]
				,[CMNDMoi_MatSau]
				,[CMNDMoi_VanTay1]
				,[CMNDMoi_VanTay2]
				,[CMNDCu_MatTruoc]
				,[CMNDCu_MatSau]
				,[CMNDCu_VanTay1]
				,[CMNDCu_VanTay2]
				)
				VALUES
				(N'"+HoTen+"',N'"+TenTat+"','"+NgaySinh+"',"+GioiTinh+",N'"+QuocTich+"',N'"+CMND+"',N'"+HoChieu+"',N'"+SoKhac+"','"+dtNgayCapCMT.ToString("yyyy-MM-dd")+"'"+",N'"+noiCap+"'"+",N'"+dcLienHe+"'"+",N'"+dcThuongTru+"'"+",N'"+dcNuocNgoai+"'"+",N'"+dtNha+"'"+",N'"+dtDiDong+"'"+",N'"+HopThu+"'"+","+DiHoc+","+DiLam+","+tuKinhDoanh+","+nghiHuu+",N'"+nganhNghe+"',N'"+chucVu+"'"+",N'"+dtCoQuan+"'"+",N'"+tenCoQuan+"'"+",N'"+ttHonNhan+"'"+",N'"+ttHocVan+"'"+",N'"+thuNhap+"',N'"+CMNDMoi_MatTruoc+"',N'"+CMNDMoi_MatSau+"',N'"+CMNDMoi_VanTay1+"',N'"+CMNDMoi_VanTay2+"',N'"+CMNDCu_MatTruoc+"',N'"+CMNDCu_MatSau+"',N'"+CMNDCu_VanTay1+"',N'"+CMNDCu_VanTay2+"')";
				string strQueryFill = strInsert.Replace("\r\n\t\t\t\t"," ");
				SqlConnection conn = new SqlConnection(StrConn); 				int kq = SqlHelper.ExecuteNonQuery(conn,CommandType.Text,strQueryFill);
				pError = "";
			}
			catch(Exception ex)
			{
				pError = ex.Message;
			}				

		}		

		/// <summary>
		/// Sửa thông tin khách hàng
		/// </summary>
		public void UpdatePersonal(string ma_Khang,string HoTen,string TenTat,string NgaySinh,int GioiTinh,string QuocTich,string CMND,string HoChieu,string SoKhac,string ngayCap,string noiCap,string dcLienHe,string dcThuongTru,string dcNuocNgoai,string dtNha,string dtDiDong,string HopThu,int DiHoc,int DiLam,int tuKinhDoanh,int nghiHuu,string nganhNghe,string chucVu,string dtCoQuan,string tenCoQuan,string ttHonNhan,string ttHocVan,string thuNhap , string CMNDMoi_MatTruoc, string CMNDMoi_MatSau, string CMNDMoi_VanTay1, string CMNDMoi_VanTay2, string CMNDCu_MatTruoc, string CMNDCu_MatSau, string CMNDCu_VanTay1, string CMNDCu_VanTay2,ref string pError)
		{
			try
			{
				DateTime dtNgaySinh = DateTime.Parse(NgaySinh);
				DateTime dtNgayCapCMT = DateTime.Parse(ngayCap);
				string strUpdate = @"Update [HRM_CHECKER].[dbo].[tblKhachHang] SET [HoTen] = N'"+HoTen+"',[TenVietTat] = N'"+TenTat+"',[NgaySinh] ='"+NgaySinh+"',[GioiTinh] = "+GioiTinh+",[QuocTich] = N'"+QuocTich+"',[CMND] = N'"+CMND+"',[HoChieu] = N'"+HoChieu+"',[SoKhac] = N'"+SoKhac+"',[NgayCapCMND] = '"+dtNgayCapCMT.ToString("yyyy-MM-dd")+"'"+",[NoiCapCMND] = N'"+noiCap+"'"+",[DiaChiLienHe] = N'"+dcLienHe+"'"+",[DiaChiThuongTru] = N'"+dcThuongTru+"'"+",[DiaChiNuocNgoai] = N'"+dcNuocNgoai+"'"+",[DienThoaiNha] = N'"+dtNha+"'"+",[DienThoaiDiDong] = N'"+dtDiDong+"'"+",[HopThu] = N'"+HopThu+"'"+",[IsDiHoc] = "+DiHoc+",[IsDiLam] ="+DiLam+",[IsTuKinhDoanh] = "+tuKinhDoanh+",[IsNghiHuu] = "+nghiHuu+",[NganhNghe] = N'"+nganhNghe+"',[ChucVu] = N'"+chucVu+"'"+",[DienThoaiCoQuan] = N'"+dtCoQuan+"'"+",[TenCoQuan] = N'"+tenCoQuan+"'"+",[TinhTrangHonNhan] = N'"+ttHonNhan+
					@"'"+",[TrinhDoHocVan] = N'"+ttHocVan+"'"+",[ThuNhap] = N'"+thuNhap+
				
					@"'"+",[CMNDMoi_MatTruoc] = N'"+CMNDMoi_MatTruoc+
					@"'"+",[CMNDMoi_MatSau] = N'"+CMNDMoi_MatSau+
					@"'"+",[CMNDMoi_VanTay1] = N'"+CMNDMoi_VanTay1+
					@"'"+",[CMNDMoi_VanTay2] = N'"+CMNDMoi_VanTay2+
					@"'"+",[CMNDCu_MatTruoc] = N'"+CMNDCu_MatTruoc+
					@"'"+",[CMNDCu_MatSau] = N'"+CMNDCu_MatSau+
					@"'"+",[CMNDCu_VanTay1] = N'"+CMNDCu_VanTay1+
					@"'"+",[CMNDCu_VanTay2] = N'"+CMNDCu_VanTay2+

					@"' Where MaKhachHang = '"+ma_Khang+"'";
				string strQueryFill = strUpdate.Replace("\r\n\t\t\t\t"," ");
				SqlConnection conn = new SqlConnection(StrConn); 				int kq = SqlHelper.ExecuteNonQuery(conn,CommandType.Text,strQueryFill);
				pError = "";
			}
			catch(Exception ex)
			{
				pError = ex.Message;
			}				

		}		

		/// <summary>
		/// Xóa thông tin khách hàng
		/// </summary>
		/// <param name="maKH"></param>
		/// <param name="strError"></param>
		public void DeletePersonal(string maKH,ref string strError)
		{
			try
			{
				string strQuery = @"DELETE FROM [HRM_CHECKER].[dbo].[tblKhachHang] WHERE MaKhachHang = "+maKH+"";
				SqlConnection conn = new SqlConnection(StrConn); 				int kq = SqlHelper.ExecuteNonQuery(conn,CommandType.Text,strQuery);
				strError = "";
				
			}
			catch(Exception ex)
			{
				strError = ex.Message;				
			}
		}
	}
}
