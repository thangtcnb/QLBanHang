using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Thư viện thêm vào
using System.Data.SqlClient;
using System.Data;
namespace DataAccessLayer
{
    public class dbConnect //Nếu ko để public qua các class khác ko thấy
    {
        //Tạo đối tượng kết nối
        private SqlConnection conn;

        //Tạo phương thức kết nối
        public dbConnect()
        {
            conn = new SqlConnection("Server=NT;Database=QuanLyBanHang;Trusted_Connection=True;");
        }
        //Phương thức lấy dữ liệu thông qua DataTable
        public DataTable GetData(string strSQL)//Phương thức này dùng để Select
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);
            conn.Open();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        //Phương thức lấy dữ liệu thông qua StoreProcedure
        public DataTable GetData(string procName, SqlParameter[]para)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = procName;
            cmd.CommandType = CommandType.StoredProcedure;
            if (para != null)
                cmd.Parameters.AddRange(para);
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            conn.Open();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public int ExcuteSQL(string strSQL)
        {
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            conn.Open();
            int row = cmd.ExecuteNonQuery();
            conn.Close();
            return row;
        }
        public int ExcuteSQL(string procName, SqlParameter[]para)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = procName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            if (para != null)
                cmd.Parameters.AddRange(para);
            conn.Open();
            int row = cmd.ExecuteNonQuery();
            conn.Close();
            return row;
        }
    }
}
