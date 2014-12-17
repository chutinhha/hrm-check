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
			//string strConn = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=HRM_CHECKER;Data Source=QUYDA-PC;Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=QUYDA-PC;Use Encryption for Data=False;Tag with column collation when possible=False";			 		    strConn = ConfigurationSettings.AppSettings["ConnectionString"]; 			if(strConn!=null && strConn != "") 			{ 				StrConn = strConn; 			} 			else 			{ 				//Xu ly sau 			} 			 						
		}

		public DataSet LoadPersonal()
		{
			 			//SqlDataReader reader =  SqlHelper.ExecuteReader(conn,CommandType.Text,"Select * from tblKhachHang"); 			SqlConnection conn = new SqlConnection(StrConn); 			DataSet ds = SqlHelper.ExecuteDataset(conn,CommandType.Text,"Select * from tblKhachHang"); 			if(ds!=null) 			{ 				return ds; 			} 			else 			{ 				return null; 			} 			//dtgKhachHang.DataSource = ds.Tables[0];

		}

		public void LoadPersonalById(string personalID)
		{
			
		}
		
	}
}
