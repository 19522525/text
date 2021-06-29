using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.DTO
{
    public class RutTien
    {
        string iD;
        string iDNV;
        string iDKH;
        string iDMaSo;
        DateTime ngayRut;
        double tienRut;
        public string ID { get => iD; set => iD = value; }
        public string IDNV { get => iDNV; set => iDNV = value; }
        public string IDKH { get => iDKH; set => iDKH = value; }
        public string IDMaSo { get => iDMaSo; set => iDMaSo = value; }
        public DateTime NgayRut { get => ngayRut; set => ngayRut = value; }
        public double TienRut { get => tienRut; set => tienRut = value; }

        public RutTien(DataRow row)
        {
            this.ID = row["MaRT"].ToString();
            this.IDNV = row["MaNV"].ToString();
            this.IDKH = row["MaKH"].ToString();
            this.IDMaSo = row["MaSo"].ToString();
            this.NgayRut = (DateTime)row["NgayRut"];
            this.TienRut = Convert.ToDouble(row["TienRut"]);
        }
    }
}
