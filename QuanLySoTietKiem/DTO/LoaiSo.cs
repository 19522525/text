using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.DTO
{
    public class LoaiSo
    {
        double maLS, thoiHan, toiThieu, tienGuiTT, thoiHanTT;
        double laiSuat;
        string tenLS;

        public double LaiSuat { get => laiSuat; set => laiSuat = value; }
        public string TenLS { get => tenLS; set => tenLS = value; }
        public double MaLS { get => maLS; set => maLS = value; }
        public double ThoiHan { get => thoiHan; set => thoiHan = value; }
        public double ToiThieu { get => toiThieu; set => toiThieu = value; }
        public double TienGuiTT { get => tienGuiTT; set => tienGuiTT = value; }
        public double ThoiHanTT { get => thoiHanTT; set => thoiHanTT = value; }

        public LoaiSo(double maLS, double thoiHan, double toiThieu, double laiSuat, string tenLS, double tienGuiTT, double thoiGianTT)
        {
            this.MaLS = maLS;
            this.ThoiHan = thoiHan;
            this.ToiThieu = toiThieu;
            this.laiSuat = laiSuat;
            this.tenLS = tenLS;
            this.tienGuiTT = tienGuiTT;
            this.thoiHanTT = thoiGianTT;
        }

        public LoaiSo(DataRow row)
        {
            this.MaLS = Convert.ToDouble(row["MaLS"]);
            this.ThoiHan = Convert.ToDouble(row["ThoiHan"]);
            this.ToiThieu = Convert.ToDouble(row["ToiThieu"]);
            this.laiSuat = Convert.ToDouble(row["LaiSuat"]);
            this.thoiHanTT = Convert.ToDouble(row["ThoiGianTT"]);
            this.tienGuiTT = Convert.ToDouble(row["TienGuiTT"]);
            this.tenLS = row["TenLS"].ToString();
        }

        public LoaiSo()
        {

        }
    }
}
