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
    public partial class fcustomer : Form
    {
        BindingSource listCustomer = new BindingSource();
        public fcustomer()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void KHbutton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fcustomer_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = listCustomer;
            LoadCustomer();
            AddBindingData();
        }

        private void AddBindingData()
        {
            tbCmnd.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "CMND", true, DataSourceUpdateMode.Never));
            tbDiaChi.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never));
            tbSdt.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Số điện thoại", true, DataSourceUpdateMode.Never));
            tbTenKH.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Họ Tên", true, DataSourceUpdateMode.Never));
            tbMaKH.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Mã khách hàng", true, DataSourceUpdateMode.Never));
            tbSodu.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Số dư", true, DataSourceUpdateMode.Never));
        }

        public void LoadCustomer()
        {
            listCustomer.DataSource = DAO.CustomerDAO.Instance.GetAllCustomerInfo();
        }

        private void KHSbutton1_Click(object sender, EventArgs e)
        {

        }

        private void KHSbutton3_Click(object sender, EventArgs e)
        {
            int idCus;
            if(int.TryParse(tbMaKH.Text, out idCus))
            {
                //DAO.GuiTienDAO.Instance.DeleteGoiTienByIdCus(idCus);
                //DAO.RutTienDAO.Instance.DeleteRutTienByIdCus(idCus);
                DAO.SoTietKiemDAO.Instance.DeleteSTKbyIdCus(idCus);

                if (DAO.CustomerDAO.Instance.DeleteCustomer(idCus))
                {
                    MessageBox.Show("Xóa khách hàng thành công");
                    LoadCustomer();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa khách hàng");
                }
            }
        }

        private void tbSodu_TextChanged(object sender, EventArgs e)
        {
            float Sodu;
            if(float.TryParse(tbSodu.Text, out Sodu))
            {
                CultureInfo culture = new CultureInfo("vi-VN");
                tbSodu.Text = Sodu.ToString("c", culture);
            }
        }

        private void btModify_Click(object sender, EventArgs e)
        {
            if(tbMaKH.Text == "")
            {
                return;
            }
            else
            {
                if(DAO.CustomerDAO.Instance.UpdateCustomer(tbTenKH.Text, tbDiaChi.Text, tbSdt.Text, tbCmnd.Text, Convert.ToInt32(tbMaKH.Text)))
                {
                    MessageBox.Show("Chỉnh sửa thông tin khách hàng thành công");
                    LoadCustomer();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi chỉnh sửa thông tin khách hàng");
                    return;
                }
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if(tbTenKH.Text != "" && tbCmnd.Text != "")
            {
                DAO.CustomerDAO.Instance.InsertCustomer(tbTenKH.Text, tbDiaChi.Text, tbSdt.Text, tbCmnd.Text, 0);
                LoadCustomer();
            }
        }
    }
}
