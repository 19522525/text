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
    public partial class flogin : Form
    {
        public flogin()
        {
            InitializeComponent();
            StatusLabel.ForeColor = Color.White;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn thật sự muốn thoát?","Thông Báo", MessageBoxButtons.OKCancel)!=System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Tên đăng nhập" || tbUsername.Text == "")
            {

                StatusLabel.Text = "Tên đăng nhập không được để trống.";
                tbUsername.Focus();
                return;
            }
            if (tbPassword.Text == "Mật khẩu" || tbPassword.Text == "")
            {
                StatusLabel.Text = "Mật khẩu không được để trống.";
                tbPassword.Focus();
                return;
            }
            try
            {
                bool LoginSuccessful = DAO.Account.Instance.Login(tbUsername.Text, tbPassword.Text);
                if (LoginSuccessful)
                {
                    LoginButton.Focus();
                    StatusLabel.Text = "Đang đăng nhập...";
                    fmanage f = new fmanage(new DTO.Account(DAO.Account.Instance.GetInfoAcc(tbUsername.Text)));
                    this.Hide();
                    f.ShowDialog();
                    StatusLabel.Text = "";
                    this.Show();
                    //tbUsername.ReadOnly = true;
                    //tbPassword.ReadOnly = true;
                }
                else
                {
                    StatusLabel.Text = "Đăng nhập thất bại";
                    return;
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.ToString()== "Return")
            {
                this.LoginButton_Click(sender, new EventArgs());
            }
        }

        private void tbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                tbPassword.Focus();
            }
        }
    }
}
