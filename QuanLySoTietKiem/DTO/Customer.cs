﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.DTO
{
    public class Customer
    {
        String iD;
        String hoTen;
        String diaChi;
        String sDT;
        String cmnd;
        double soDu;

        public string ID { get => iD; set => iD = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public double SoDu { get => soDu; set => soDu = value; }

        public Customer(DataRow row)
        {
            this.ID = row["MaNV"].ToString();
            this.HoTen = row["HoTen"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.SDT = row["SDT"].ToString();
            this.Cmnd = row["CMNN_or_HoChieu"].ToString();
            this.SoDu = Convert.ToDouble(row["SoDu"].ToString());
        }
    }
}