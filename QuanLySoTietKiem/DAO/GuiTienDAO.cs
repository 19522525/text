using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.DAO
{
    public class GuiTienDAO
    {
        private static GuiTienDAO instance;

        public static GuiTienDAO Instance { get { if (instance == null) instance = new GuiTienDAO(); return instance; } set => instance = value; }

        public bool insertGoiTien(string idNV, string idKH, string idMaSo, DateTime ngayGoi, double tienGoi)
        {
            return ExecuteQuery.Instance.ExecuteNoneQuery("insertGoiTien @maNV , @maSo , @ngayGoi , @tienGoi", new object[] { idNV, idMaSo, ngayGoi, tienGoi }) > 0;
        }
        
        public DataTable getGoiTienByDay(DateTime date)
        {
            return ExecuteQuery.Instance.ExecuteReader("select MaGui [Mã gửi], TienGui [Tiền gửi], MaSo [Mã sổ], MaNV [Mã nhân viên], NgayGui [Ngày gửi] from GUITIEN where NgayGui =" + date.ToString("MM/dd/yyyy"));
        }

        public bool DeleteGoiTienByIdCus(int id)
        {
            return ExecuteQuery.Instance.ExecuteNoneQuery("DELETE GUITIEN where MaKH =" + id) > 0;
        }
    }
}
