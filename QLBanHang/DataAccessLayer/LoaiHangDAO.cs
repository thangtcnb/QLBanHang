//Lớp này dùng để thao tác với bảng LoaiHang
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Các thư viện thêm vào
using System.Data;
using System.Data.SqlClient;
using ValueObject;
namespace DataAccessLayer
{
    class LoaiHangDAO
    {
        dbConnect db = new dbConnect();
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            dt = db.GetData("sp_LoaiHang_SelectAll", null);
            return dt;
        }
        /*
         public DataTable GetData()
         {
            return db.GetData("sp_LoaiHang_SelectAll", null);
         }
         * */
    }
}
