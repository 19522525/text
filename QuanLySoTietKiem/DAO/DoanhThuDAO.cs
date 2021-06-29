using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.DAO
{
    public class DoanhThuDAO
    {
        private static DoanhThuDAO instance;

        public static DoanhThuDAO Instance { get { if (instance == null) instance = new DoanhThuDAO(); return instance; } set => instance = value; }

        public bool InsertDoanhThu(double loai, DateTime day)
        {
            return ExecuteQuery.Instance.ExecuteNoneQuery(String.Format("INSERT INTO [dbo].[BAOCAO] ([Ngay],[MaLS],[TongThu],[TongChi],[SoMo],[SoDong],[ChenhLech]) VALUES ('{0}',{1},0,0,0,0,0)", day, loai)) > 0;
        }

        public int GetIdNewLS()
        {
            return (int)ExecuteQuery.Instance.ExecuteScalar("SELECT MAX(MaLS) FROM [dbo].[BAOCAO]");
        }

        public bool CheckDoanhThu(double loaiso, DateTime date)
        {
            ///return Name, birthday, PhoneNumber, Sex, IdentityNumber, Passport, Addr, Note, ArrivalDate
            return (int)ExecuteQuery.Instance.ExecuteScalar("select count (*) from BAOCAO where MaLS = @maLS and DAY(Ngay) = @ngay and MONTH(Ngay) = @thang and YEAR(Ngay) = @nam", new object[] { loaiso, date.Day, date.Month, date.Year }) == 1;
        }

        public DataRow GetDoanhThu(double loaiso, DateTime date)
        {
            ///return Name, birthday, PhoneNumber, Sex, IdentityNumber, Passport, Addr, Note, ArrivalDate
            return ExecuteQuery.Instance.ExecuteReader("select * from BAOCAO where MaLS = @maLS and DAY(Ngay) = @ngay and MONTH(Ngay) = @thang and YEAR(Ngay) = @nam", new object[] { loaiso, date.Day, date.Month, date.Year }).Rows[0];
        }

        public DataTable GetDoanhThuNgay(DateTime day)
        {
            return ExecuteQuery.Instance.ExecuteReader("select LOAISO.MaLS [Mã loại sổ], TongThu [Tổng thu], TongChi [Tổng chi], SoMo [Sổ mở], SoDong [Sổ đóng], LOAISO.TenLS [Tên loại sổ] from BAOCAO, LOAISO where LOAISO.MaLS = BAOCAO.MaLS and DAY(Ngay) = @ngay and MONTH(Ngay) = @thang and YEAR(Ngay) = @nam", new object[] { day.Day, day.Month, day.Year});
        }

        public DataTable GetDoanhThuThang(DateTime dt)
        {
            return ExecuteQuery.Instance.ExecuteReader(string.Format("select LOAISO.MaLS [Mã loại sổ], TongThu [Tổng thu], TongChi [Tổng chi], SoMo [Sổ mở], SoDong [Sổ đóng], LOAISO.TenLS [Tên loại sổ] from BAOCAO, LOAISO where LOAISO.MaLS = BAOCAO.MaLS and MONTH(Ngay) = {0} and YEAR(Ngay) = {1}", dt.Month, dt.Year));
        }

        public bool UpdateDoanhThu(DTO.DoanhThu dt)
        {
            return ExecuteQuery.Instance.ExecuteNoneQuery(string.Format("update BAOCAO set Ngay = '{0}', MaLS = {1}, TongThu = {2}, TongChi = {3}, SoMo = {4}, SoDong = {5}, ChenhLech = {6} where MaBC = {7}", dt.Date, dt.MaLS, dt.TongThu, dt.TongChi, dt.SoMo, dt.SoDong, dt.ChenhLech, dt.ID)) > 0;
        }

        public DataTable GetDoanhThuThangLoaiSo(DateTime dt, string idLS)
        {
            return ExecuteQuery.Instance.ExecuteReader(string.Format("select LOAISO.MaLS [Mã loại sổ], TongThu [Tổng thu], TongChi [Tổng chi], SoMo [Sổ mở], SoDong [Sổ đóng], LOAISO.TenLS [Tên loại sổ] from BAOCAO, LOAISO where LOAISO.MaLS = BAOCAO.MaLS and MONTH(Ngay) = {0} and YEAR(Ngay) = {1} and MaLS = {2}", dt.Month, dt.Year, idLS));
        }
    }
}
