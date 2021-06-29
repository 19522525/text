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
    public partial class fmanage : Form
    {
        ftransaction transaction;
        fopen open;
        finformation information;
        fcustomer customer;
        fstaff staff;
        fchange change;
        faccount account;
        freport report;
        //public int LoaiTk;
        
        public fmanage(DTO.Account account)
        {
            InitializeComponent();
            DTO.LoaiTK loaiTK = new DTO.LoaiTK(DAO.Account.Instance.GetPhanQuyen(account.LoaiTK));
            btChange.Enabled = loaiTK.ThayDoi;
            btAccount.Enabled = loaiTK.CapTK;
            btCustomer.Enabled = loaiTK.ListKH;
            btStaff.Enabled = loaiTK.ListNV;
            btTransaction.Enabled = loaiTK.GiaoDich;
            btReport.Enabled = loaiTK.BaoCao;
            btOpen.Enabled = loaiTK.MoSo;
            btInfomation.Enabled = loaiTK.ListSTK;
        }


        private void transaction_Click(object sender, EventArgs e)
        {
            transaction = new ftransaction();
            transaction.GuiTien += f_transaction;
            transaction.RutTien += f_transaction;
            transaction.Show();
        }

        private void f_transaction(object sender, EventArgs e)
        {
            if(customer != null) customer.LoadCustomer();
            if (information != null) information.LoadSoTietKiem();
            if (report != null) report.LoadReport();
        }

        private void fmanage_Load(object sender, EventArgs e)
        {
        
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btopen_Click(object sender, EventArgs e)
        {
            open = new fopen();
            open.Show();
        }

        private void btinformation_Click(object sender, EventArgs e)
        {
            information = new finformation();
            information.Show();
        }

        private void btcustomer_Click(object sender, EventArgs e)
        {
            customer = new fcustomer();
            customer.Show();
        }

        private void btstaff_Click(object sender, EventArgs e)
        {
            staff = new fstaff();
            staff.Show();
        }

        private void btchange_Click(object sender, EventArgs e)
        {
            change = new fchange();
            change.Show();
        }

        private void btaccount_Click(object sender, EventArgs e)
        {
            account = new faccount();
            account.Show();
        }

        private void btreport_Click_1(object sender, EventArgs e)
        {
            report = new freport();
            report.Show();
        }
    }
}
