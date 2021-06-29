using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.DTO
{
    public class Staff
    {
        private int iD;
        private String hoTen;
        private String diaChi;
        private String sDT;
        private String cmnd;

        public int ID { get => iD; set => iD = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }

        public Staff(DataRow row)
        {
            this.ID = Convert.ToInt32(row["MaNV"]);
            this.HoTen = row["HoTen"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.SDT = row["SDT"].ToString();
            this.Cmnd = row["Cmnd"].ToString();
        }
    }
}
