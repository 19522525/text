using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.DTO
{
    public class GoiTien
    {
        string iD;
        string iDNV;
        string iDKH;
        string iDMaSo;
        DateTime ngayGoi;
        double tienGoi;
        public string ID { get => iD; set => iD = value; }
        public string IDNV { get => iDNV; set => iDNV = value; }
        public string IDKH { get => iDKH; set => iDKH = value; }
        public string IDMaSo { get => iDMaSo; set => iDMaSo = value; }
        public DateTime NgayGoi { get => ngayGoi; set => ngayGoi = value; }
        public double TienGoi { get => tienGoi; set => tienGoi = value; }

        public GoiTien(DataRow row)
        {
            this.ID = row["MaGT"].ToString();
            this.IDNV = row["MaNV"].ToString();
            this.IDKH = row["MaKH"].ToString();
            this.IDMaSo = row["MaSo"].ToString();
            this.NgayGoi = (DateTime)row["NgayGoi"];
            this.TienGoi = Convert.ToDouble(row["TienGoi"]);
        }
    }
}
