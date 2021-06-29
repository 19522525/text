using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.DAO
{
    public class LoaiSoDAO
    {
        private static LoaiSoDAO instance;

        public static LoaiSoDAO Instance { get { if (instance == null) instance = new LoaiSoDAO(); return instance; } set => instance = value; }
        
        public DataTable GetListLoaiSo()
        {
            return ExecuteQuery.Instance.ExecuteReader("select * from LOAISO");
        }

        public bool UpdateLS(DTO.LoaiSo loai)
        {
            return ExecuteQuery.Instance.ExecuteNoneQuery(String.Format("update LOAISO set TenLS = N'{0}', ToiThieu = {1}, ThoiHan = {2}, LaiSuat = {3}, TienGuiTT = {4}, ThoiGianTT = {5} where MaLS = {6}", loai.TenLS, loai.ToiThieu, loai.ThoiHan, loai.LaiSuat, loai.TienGuiTT, loai.ThoiHanTT, loai.MaLS)) > 0;
        }

        public DataRow GetLoaiSoById(double id)
        {
            return ExecuteQuery.Instance.ExecuteReader("select * from LOAISO where MaLS = " + id).Rows[0];
        }

        public DataRow GetKhongKyHan()
        {
            return ExecuteQuery.Instance.ExecuteReader("select * from LOAISO where ThoiHan = 0").Rows[0];
        }
    }
}
