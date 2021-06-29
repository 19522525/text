using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.DTO
{
    public class Account
    {
        string displayName, username;
        int loaiTK;
        public int LoaiTK { get => loaiTK; set => loaiTK = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string Username { get => username; set => username = value; }

        public Account(DataRow row)
        {
            this.username = row["TenDN"].ToString();
            this.displayName = row["TenHienThi"].ToString();
            this.loaiTK = Convert.ToInt32(row["LoaiTK"]);
        }
    }
}
