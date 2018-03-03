//Lớp này dùng để thao tác với bảng LoaiHang

//Các thư viện thêm vào
using System.Data;
using System.Data.SqlClient;
using ValueObject;

namespace DataAccessLayer
{
    public class LoaiHangDAO
    {
        private dbConnect db = new dbConnect();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            dt = db.GetData("sp_LoaiHang_SelectAll", null);//null là tham số truyền vào
            return dt;
        }

        /*
         public DataTable GetData()
         {
            return db.GetData("sp_LoaiHang_SelectAll", null);
         }
         * */

        public DataTable GetDaTaByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDLoaiHang", ID)
            };
            return db.GetData("sp_LoaiHang_Select_ByID", para);
        }

        public int Insert(LoaiHang obj)
        {
            SqlParameter[] para =
             {
                new SqlParameter("IDLoaiHang", obj.IDLoaiHang),
                new SqlParameter("TenLoaiHang", obj.TenLoai),
                new SqlParameter("MoTa", obj.Mota)
             };
            return db.ExcuteSQL("sp_LoaiHang_Insert", para);
        }

        public int Update(LoaiHang obj)
        {
            SqlParameter[] para =
             {
                new SqlParameter("IDLoaiHang", obj.IDLoaiHang),
                new SqlParameter("TenLoaiHang", obj.TenLoai),
                new SqlParameter("MoTa", obj.Mota)
             };
            return db.ExcuteSQL("sp_LoaiHang_Insert", para);
        }

        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDLoaiHang", ID)
            };
            return db.ExcuteSQL("sp_LoaiHang_Delete", para);
        }
    }
}