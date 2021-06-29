using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySoTietKiem
{
    public partial class fopen : Form
    {
        public fopen()
        {
            InitializeComponent();
        }

        DTO.LoaiSo loai;

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMoSo_Click(object sender, EventArgs e)
        {
            int idCus = -1;

            if(tbMaKH.Text != "")
            {

                if (!DAO.DoanhThuDAO.Instance.CheckDoanhThu(loai.MaLS, dtMoSo.Value))
                {
                    DAO.DoanhThuDAO.Instance.InsertDoanhThu(loai.MaLS, dtMoSo.Value);
                }

                DataRowView rowView = (DataRowView)cbIdNV.SelectedItem;

                DTO.Staff staff = new DTO.Staff(rowView.Row);

                Double tiengoi;
                if (Double.TryParse(tbTienGoi.Text, out tiengoi))
                {
                    if (tiengoi >= loai.ToiThieu)
                    {
                        if (DAO.SoTietKiemDAO.Instance.insertSoTietKiem(staff.ID.ToString(), tbMaKH.Text, loai.MaLS, dtMoSo.Value, tiengoi))
                        {
                            this.Close();
                        }
                        else
                        {
                            StatusLabel.Text = "Error";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tiền gửi tối thiểu là " + loai.ToiThieu);
                    }
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void MSbutton2_Click(object sender, EventArgs e)
        {

        }

        private void cbLoaiSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView data = (DataRowView) cbLoaiSo.SelectedItem;
            loai = new DTO.LoaiSo(data.Row);
            tbLaiSuat.Text = (loai.LaiSuat * 100).ToString("0.00");
        }

        private void tbMaKH_Leave(object sender, EventArgs e)
        {
            if(tbMaKH.Text != "")
            {
                if(DAO.CustomerDAO.Instance.GetCustomerInfo(tbMaKH.Text) != null)
                {
                    if (DAO.CustomerDAO.Instance.CheckCustomer(tbMaKH.Text))
                    {
                        DTO.Customer customer = new DTO.Customer(DAO.CustomerDAO.Instance.GetCustomerInfo(tbMaKH.Text).Rows[0]);
                        tbTenKH.Text = customer.HoTen;
                        tbSdt.Text = customer.SDT;
                        tbDiaChi.Text = customer.DiaChi;
                        tbCmnd.Text = customer.Cmnd;
                        cbIdNV.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Khách hàng không tồn tại");
                    }
                }
            }
        }

        private void tbMaKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                SendKeys.Send("{TAB}");
            }
        }


        private void fopen_Load(object sender, EventArgs e)
        {
            cbIdNV.DataSource = DAO.StaffDAO.Instance.GetList();
            cbIdNV.DisplayMember = "MaNV";
            cbTenNV.DataSource = DAO.StaffDAO.Instance.GetList();
            cbTenNV.DisplayMember = "HoTen";
            cbLoaiSo.DataSource = DAO.LoaiSoDAO.Instance.GetListLoaiSo();
            cbLoaiSo.DisplayMember = "TenLS";
            DataRowView data = (DataRowView)cbLoaiSo.SelectedItem;
            loai = new DTO.LoaiSo(data.Row);
        }

        private void cbListNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTenNV.DataSource != null)
                if(cbIdNV.SelectedIndex != -1)
                    cbTenNV.SelectedIndex = cbIdNV.SelectedIndex;
        }

        private void cbTenNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbIdNV.DataSource != null)
                if (cbTenNV.SelectedIndex != -1)
                    cbIdNV.SelectedIndex = cbTenNV.SelectedIndex;
        }
    }
}
