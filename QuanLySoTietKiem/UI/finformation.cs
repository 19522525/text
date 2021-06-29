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
    public partial class finformation : Form
    {
        BindingSource listSTK = new BindingSource();
        public finformation()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TTSbutton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TTSbutton3_Click(object sender, EventArgs e)
        {

        }

        private void finformation_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = listSTK;
            cbLoaiSo.DataSource = DAO.LoaiSoDAO.Instance.GetListLoaiSo();
            LoadSoTietKiem();
            AddBindingData();
        }

        private void AddBindingData()
        {
            cbLoaiSo.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Loại sổ", true, DataSourceUpdateMode.Never));
            cbLoaiSo.DisplayMember = "TenLS";
            tbMaSo.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Mã sổ", true, DataSourceUpdateMode.Never));
            tbMaNV.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Mã nhân viên", true, DataSourceUpdateMode.Never));
            tbSoDu.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Tiền gửi", true, DataSourceUpdateMode.Never));
            tbMaKH.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Mã khách hàng", true, DataSourceUpdateMode.Never));
        }

        public void LoadSoTietKiem()
        {
            listSTK.DataSource = DAO.SoTietKiemDAO.Instance.listSoTietKiem();
        }

        private void TTSbutton1_Click(object sender, EventArgs e)
        {

        }

        private void tbMaSo_TextChanged(object sender, EventArgs e)
        {
            //DataGridViewRow data = dataGridView1.SelectedRows[0];
            //data.
        }
    }
}
