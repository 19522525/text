using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.DTO
{
    public class LoaiTK
    {
        int loai;
        string tenLoai;
        bool giaoDich, moSo, baoCao, listNV, listKH, capTK, listSTK, thayDoi, phanQuyen;

        public int Loai { get => loai; set => loai = value; }
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
        public bool GiaoDich { get => giaoDich; set => giaoDich = value; }
        public bool MoSo { get => moSo; set => moSo = value; }
        public bool BaoCao { get => baoCao; set => baoCao = value; }
        public bool ListNV { get => listNV; set => listNV = value; }
        public bool ListKH { get => listKH; set => listKH = value; }
        public bool CapTK { get => capTK; set => capTK = value; }
        public bool ListSTK { get => listSTK; set => listSTK = value; }
        public bool ThayDoi { get => thayDoi; set => thayDoi = value; }
        public bool PhanQuyen { get => phanQuyen; set => phanQuyen = value; }

        public LoaiTK(DataRow row)
        {
            this.loai = Convert.ToInt32(row["Loai"]);
            this.tenLoai = row["TenLoai"].ToString();
            this.giaoDich = Convert.ToBoolean(row["GiaoDich"]);
            this.moSo = Convert.ToBoolean(row["MoSo"]);
            this.baoCao = Convert.ToBoolean(row["BaoCao"]);
            this.listNV = Convert.ToBoolean(row["ListNV"]);
            this.listKH = Convert.ToBoolean(row["ListKH"]);
            this.capTK = Convert.ToBoolean(row["CapTK"]);
            this.thayDoi = Convert.ToBoolean(row["ThayDoi"]);
            this.listSTK = Convert.ToBoolean(row["ListSTK"]);
            this.phanQuyen = Convert.ToBoolean(row["PhanQuyen"]);
        }
    }
}
