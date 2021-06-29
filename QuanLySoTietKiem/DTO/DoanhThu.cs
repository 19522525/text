using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.DTO
{
    public class DoanhThu
    {
        double iD, maLS, soMo, soDong;
        double tongThu, tongChi, chenhLech;
        DateTime date;

        public double ID { get => iD; set => iD = value; }
        public double MaLS { get => maLS; set => maLS = value; }
        public double SoMo { get => soMo; set => soMo = value; }
        public double SoDong { get => soDong; set => soDong = value; }
        public double TongThu { get => tongThu; set => tongThu = value; }
        public double TongChi { get => tongChi; set => tongChi = value; }
        public double ChenhLech { get => chenhLech; set => chenhLech = value; }
        public DateTime Date { get => date; set => date = value; }

        public DoanhThu(DataRow row)
        {
            this.iD = Convert.ToDouble(row["MaBC"]);
            this.date = (DateTime)row["Ngay"];
            this.tongChi = Convert.ToDouble(row["TongChi"]);
            this.tongThu = Convert.ToDouble(row["TongThu"]);
            this.soMo = Convert.ToDouble(row["SoMo"]);
            this.soDong = Convert.ToDouble(row["SoDong"]);
            this.chenhLech = Convert.ToDouble(row["ChenhLech"]);
        }
    }
}
