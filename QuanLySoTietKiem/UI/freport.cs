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
    public partial class freport : Form
    {
        BindingSource listReportDay = new BindingSource();
        BindingSource listReportMonth = new BindingSource();
        public freport()
        {
            InitializeComponent();
            dataDay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataMonth.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BCTbutton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadReport()
        {
            LoadDoanhThuNgay();
            if (cbLoaiSo.SelectedIndex != -1)
                LoadDoanhThuThangLoaiSo();
            else
                LoadDoanhThuThang();
        }

        private void LoadDoanhThuNgay()
        {
            listReportDay.DataSource = DAO.DoanhThuDAO.Instance.GetDoanhThuNgay(dtDay.Value);
        }

        private void LoadDoanhThuThang()
        {
            listReportMonth.DataSource = DAO.DoanhThuDAO.Instance.GetDoanhThuThang(dtMonth.Value);
        }

        private void LoadDoanhThuThangLoaiSo()
        {
            listReportMonth.DataSource = DAO.DoanhThuDAO.Instance.GetDoanhThuThangLoaiSo(dtMonth.Value, cbLoaiSo.SelectedIndex.ToString());
        }

        private void freport_Load(object sender, EventArgs e)
        {
            dataDay.DataSource = listReportDay;
            dataMonth.DataSource = listReportMonth;
            LoadReport();
        }

        private void cbLoaiSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiSo.SelectedIndex != -1)
                LoadDoanhThuThangLoaiSo();
            else
                LoadDoanhThuThang();
        }
    }
}
