﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySoTietKiem
{
    public partial class ftransaction : Form
    {
        public ftransaction()
        {
            InitializeComponent();
        }

       

        private void label8_Click(object sender, EventArgs e)
        {
          
        }

        private void MSbutton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MStextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void RTbutton3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GTbutton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGuiTien_Click(object sender, EventArgs e)
        {
            if(DAO.GuiTienDAO.Instance.insertGoiTien(tbMaNV_G.Text, tbMaKH_G.Text, tbMaSo_G.Text, dtNgayGui.Value, Convert.ToDouble(tbTienGui.Text)))
            {
                StatusLabel_G.Text = "";
                this.Close();
            }
            else
            {
                StatusLabel_G.Text = "Error";
            }
        }

        private void btRutTien_Click(object sender, EventArgs e)
        {
            if (DAO.RutTienDAO.Instance.insertRutTien(tbMaNV_R.Text, tbMaKH_R.Text, tbMaSo_R.Text, dtNgayRut.Value, Convert.ToDouble(tbTienRut.Text)))
            {
                StatusLabel_R.Text = "";
                this.Close();
            }
            else
            {
                StatusLabel_R.Text = "Error";
            }
        }
    }
}
