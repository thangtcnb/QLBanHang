using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//các thư viện thêm vào
using DataAccessLayer;
using System.Data;
using ValueObject;

namespace BusinessLogicLayer
{
    public class LoaiHangBus
    {
        private LoaiHangDAO dao = new LoaiHangDAO();

        public DataTable GetData()
        {
            return dao.GetData();
        }

        public DataTable GetDataByID(string id)
        {
            return dao.GetDaTaByID(id);
        }

        public int Insert(LoaiHang obj)
        {
            return dao.Insert(obj);
        }

        public int Update(LoaiHang obj)
        {
            return dao.Update(obj);
        }

        public int Delete(string ID)
        {
            return dao.Delete(ID);
        }
    }
}