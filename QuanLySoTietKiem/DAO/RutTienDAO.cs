using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.DAO
{
    public class RutTienDAO
    {
        private static RutTienDAO instance;

        public static RutTienDAO Instance { get { if (instance == null) instance = new RutTienDAO(); return instance; } set => instance = value; }

        public bool insertRutTien(string idNV, string idKH, string idMaSo, DateTime ngayRut, double tienRut)
        {
            return ExecuteQuery.Instance.ExecuteNoneQuery("insertRutTien @maNV , @maKH , @maSo , @ngayRut , @tienRut", new object[] { idNV, idKH, idMaSo, ngayRut, tienRut }) > 0;
        }
        public DataTable getRutTienByDay(DateTime date)
        {
            return ExecuteQuery.Instance.ExecuteReader("select * from RUTTIEN where NgayRut =" + date.ToString("MM/dd/yyyy"));
        }
        public bool DeleteRutTienByIdCus(int id)
        {
            return ExecuteQuery.Instance.ExecuteNoneQuery("DELETE RUTTIEN where MaKH =" + id) > 0;
        }
    }
}
