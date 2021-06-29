using System;
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
    public partial class fstaff : Form
    {
        BindingSource listStaff = new BindingSource();
        public fstaff()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fstaff_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = listStaff;
            LoadListStaff();
            AddBindingData();
        }

        private void LoadListStaff()
        {
            listStaff.DataSource = DAO.StaffDAO.Instance.ListNhanVien();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {

        }

        private void AddBindingData()
        {
            tbCmnd.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "CMND", true, DataSourceUpdateMode.Never));
            tbDiaChi.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never));
            tbSdt.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Số điện thoại", true, DataSourceUpdateMode.Never));
            tbTenNV.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Họ tên", true, DataSourceUpdateMode.Never));
            tbID.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Mã nhân viên", true, DataSourceUpdateMode.Never));
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if(tbTenNV.Text == "" || tbCmnd.Text == "")
            {
                StatusLabel.Text = "Không để trống Họ tên và Cmnd";
                timer1.Enabled = true;
                return;
            }
            else
            {
                if(DAO.StaffDAO.Instance.InsertStaff(tbTenNV.Text,tbDiaChi.Text, tbSdt.Text, tbCmnd.Text))
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                    LoadListStaff();
                }
                else
                {
                    MessageBox.Show("Lỗi! Thêm nhân viên không thành công!");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StatusLabel.Text = "";
            timer1.Enabled = false;
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            
        }

        private void btModify_Click(object sender, EventArgs e)
        {
            if(DAO.StaffDAO.Instance.UpdateStaffInfo(tbID.Text, tbTenNV.Text, tbDiaChi.Text, tbSdt.Text, tbCmnd.Text))
            {
                MessageBox.Show("Sửa thông tin nhân viên thành công");
                LoadListStaff();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thông tin nhân viên");
            }
        }
    }
}
