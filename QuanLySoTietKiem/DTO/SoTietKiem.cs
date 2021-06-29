using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.DTO
{
    public class SoTietKiem
    {
        double iD;
        double iDNhanVien;
        double iDKhachHang;
        double iDLS;
        DateTime ngayMoSo;
        double tienGoi;

        public double ID { get => iD; set => iD = value; }
        public double IDNhanVien { get => iDNhanVien; set => iDNhanVien = value; }
        public double IDKhachHang { get => iDKhachHang; set => iDKhachHang = value; }
        public double IDLS { get => iDLS; set => iDLS = value; }
        public DateTime NgayMoSo { get => ngayMoSo; set => ngayMoSo = value; }
        public double TienGoi { get => tienGoi; set => tienGoi = value; }

        public SoTietKiem(DataRow row)
        {
            this.ID = Convert.ToDouble(row["MaSo"]);
            this.IDNhanVien = Convert.ToDouble(row["MaNV"]);
            this.IDKhachHang = Convert.ToDouble(row["MaKH"]);
            this.IDLS = Convert.ToDouble(row["MaLS"]);
            this.NgayMoSo = (DateTime)row["NgayMo"];
            this.tienGoi = Convert.ToDouble(row["TienGui"]);
        }

        public SoTietKiem(double id, double idNv, double idKh, double idLs, DateTime ngaymo, double tiengoi)
        {
            this.ID = id;
            this.IDNhanVien = idNv;
            this.IDKhachHang = idKh;
            this.IDLS = idLs;
            this.NgayMoSo = ngaymo;
            this.TienGoi = tiengoi;
        }
    }
}
