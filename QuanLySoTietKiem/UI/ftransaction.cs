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
    public partial class ftransaction : Form
    {
        public ftransaction()
        {
            InitializeComponent();
            tbDay_R.Text = DateTime.Today.ToString("dd/MM/yyyy");
            tbDay_G.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private event EventHandler guiTien;
        public event EventHandler GuiTien
        {
            add => guiTien += value;
            remove => guiTien -= value;
        }
        private event EventHandler rutTien;
        public event EventHandler RutTien
        {
            add => rutTien += value;
            remove => rutTien -= value;
        }


        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGuiTien_Click(object sender, EventArgs e)
        {
            if (!CheckInput(tbMaKH_G.Text, tbMaSo_G.Text, tbTienGui.Text))
                return;

            Double tiengoi;
            if (Double.TryParse(tbTienGui.Text, out tiengoi))
            {
                if(tiengoi >= 100000)
                {
                    DataRowView rowView = (DataRowView)cbIdNV.SelectedItem;

                    DTO.Staff staff = new DTO.Staff(rowView.Row);
                    if (DAO.GuiTienDAO.Instance.insertGoiTien(staff.ID.ToString(), tbMaKH_G.Text, tbMaSo_G.Text, DateTime.Today, tiengoi))
                    {
                        StatusLabel_G.Text = "";
                        if (guiTien != null)
                            guiTien(this, new EventArgs());
                    }
                    else
                    {
                        StatusLabel_G.Text = "Error";
                    }
                }
                else
                {
                    MessageBox.Show("Tiền gửi phải >= 100.000VND");
                }
            }
        }

        private bool CheckInput(string MaKH, string MaSo, string Tien)
        {
            
            if (!DAO.SoTietKiemDAO.Instance.GetIdSTKbyIdCus(MaSo))
            {
                MessageBox.Show("Sổ không tồn tại");
                return false;
            }
            else
            {
                float i;
                if (float.TryParse(Tien, out i))
                    return true;
                else
                {
                    MessageBox.Show("Nhập số tiền cần gửi/rút");
                    return false;
                }
            }
        }

        DTO.SoTietKiem stk;
        DTO.LoaiSo loaiSo;


        private void btRutTien_Click(object sender, EventArgs e)
        {
            if (!CheckInput(tbMaKH_R.Text, tbMaSo_R.Text, tbTienRut.Text))
                return;
            

            if (loaiSo.ThoiHan == 0)
            {
                if (stk.NgayMoSo.AddDays(loaiSo.ThoiHanTT) <= DateTime.Now)
                {
                    Double tienrut;
                    if (Double.TryParse(tbTienGui.Text, out tienrut))
                    {
                        if(tienrut <= stk.TienGoi)
                        {
                            DataRowView rowView = (DataRowView)cbIdNV2.SelectedItem;

                            DTO.Staff staff = new DTO.Staff(rowView.Row);
                            if (DAO.RutTienDAO.Instance.insertRutTien(staff.ID.ToString(), tbMaKH_R.Text, tbMaSo_R.Text, DateTime.Today, Convert.ToDouble(tbTienRut.Text)))
                            {
                                StatusLabel_R.Text = "";
                                if (rutTien != null)
                                    rutTien(this, new EventArgs());
                            }
                            else
                            {
                                StatusLabel_R.Text = "Error";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Số dư không đủ");
                        }
                    }
                }
                else
                {
                    MessageBox.Show(String.Format("Chưa đủ {0} ngày gửi tiết kiệm", loaiSo.ThoiHanTT));
                }
            }
            else
            {
                if(stk.NgayMoSo.AddDays(loaiSo.ThoiHan) <= DateTime.Now)
                {
                    // DAO.SoTietKiemDAO.Instance.DeleteSTKbyIdCus();
                    DAO.SoTietKiemDAO.Instance.DeleteSTK(stk.ID);
                    if (!DAO.DoanhThuDAO.Instance.CheckDoanhThu(loaiSo.MaLS, DateTime.Now))
                        DAO.DoanhThuDAO.Instance.InsertDoanhThu(loaiSo.MaLS, DateTime.Now);

                    DTO.DoanhThu doanhThu = new DTO.DoanhThu(DAO.DoanhThuDAO.Instance.GetDoanhThu(loaiSo.MaLS, DateTime.Now));

                    doanhThu.TongChi += Convert.ToDouble(tbTienRut.Text);
                    doanhThu.SoDong++;

                    DAO.DoanhThuDAO.Instance.UpdateDoanhThu(doanhThu);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Chưa đến kỳ hạn rút tiền");
                }
            }
        }

        private void btNhapLai_G_Click(object sender, EventArgs e)
        {
            tbMaKH_G.Text = tbMaSo_G.Text = tbTenKH_G.Text = tbTienGui.Text = "";
        }
        private void cbListNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTenNV.DataSource != null)
                if (cbIdNV.SelectedIndex != -1)
                    cbTenNV.SelectedIndex = cbIdNV.SelectedIndex;
        }

        private void cbTenNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIdNV.DataSource != null)
                if (cbTenNV.SelectedIndex != -1)
                    cbIdNV.SelectedIndex = cbTenNV.SelectedIndex;
        }

        private void cbListNV2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTenNV2.DataSource != null)
                if (cbIdNV2.SelectedIndex != -1)
                    cbTenNV2.SelectedIndex = cbIdNV2.SelectedIndex;
        }

        private void cbTenNV2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIdNV2.DataSource != null)
                if (cbTenNV2.SelectedIndex != -1)
                    cbIdNV2.SelectedIndex = cbTenNV2.SelectedIndex;
        }

        private void ftransaction_Load(object sender, EventArgs e)
        {
            cbIdNV.DataSource = DAO.StaffDAO.Instance.GetList();
            cbIdNV.DisplayMember = "MaNV";
            cbTenNV.DataSource = DAO.StaffDAO.Instance.GetList();
            cbTenNV.DisplayMember = "HoTen";
            cbIdNV2.DataSource = DAO.StaffDAO.Instance.GetList();
            cbIdNV2.DisplayMember = "MaNV";
            cbTenNV2.DataSource = DAO.StaffDAO.Instance.GetList();
            cbTenNV2.DisplayMember = "HoTen";
        }

        private void tbMaKH_R_Leave(object sender, EventArgs e)
        {
            if(tbMaKH_R.Text != "")
            {
                if (DAO.CustomerDAO.Instance.CheckCustomer(tbMaKH_R.Text))
                {
                    DTO.Customer customer = new DTO.Customer(DAO.CustomerDAO.Instance.GetCustomerInfo(tbMaKH_R.Text).Rows[0]);
                    tbTenKH_R.Text = customer.HoTen;
                }
                else
                {
                    MessageBox.Show("Thông tin khách hàng không có trong database");
                }
            }
        }

        private void tbMaKH_G_TextChanged(object sender, EventArgs e)
        {
            if (tbMaKH_G.Text != "")
            {
                if (DAO.CustomerDAO.Instance.CheckCustomer(tbMaKH_G.Text))
                {
                    DTO.Customer customer = new DTO.Customer(DAO.CustomerDAO.Instance.GetCustomerInfo(tbMaKH_G.Text).Rows[0]);
                    tbTenKH_G.Text = customer.HoTen;
                }
                else
                {
                    MessageBox.Show("Thông tin khách hàng không có trong database");
                }
            }
        }

        private void tbMaSo_R_Leave(object sender, EventArgs e)
        {
            if (DAO.SoTietKiemDAO.Instance.GetIdSTKbyIdCus(tbMaSo_R.Text))
            {
                stk = new DTO.SoTietKiem(DAO.SoTietKiemDAO.Instance.GetSTKbyID(Convert.ToDouble(tbMaSo_R.Text)));

                loaiSo = new DTO.LoaiSo(DAO.LoaiSoDAO.Instance.GetLoaiSoById(stk.IDLS));

                if (loaiSo.ThoiHan != 0)
                {
                    tbTienRut.ReadOnly = true;
                    double money = stk.TienGoi;
                    int day = ToIntDate(DateTime.Now) - ToIntDate(stk.NgayMoSo);
                    int ls = (int)(day / loaiSo.ThoiHan);
                    if (ls > 0)
                    {
                        double LaiSuatKkh = Convert.ToDouble(DAO.LoaiSoDAO.Instance.GetKhongKyHan()["LaiSuat"]) ;
                        money *= (1.0 + loaiSo.LaiSuat);
                        money += (day - loaiSo.ThoiHan) / 30 * LaiSuatKkh * money;
                    }
                    tbTienRut.Text = money.ToString("0.0");
                }
                else
                {
                    tbTienRut.ReadOnly = false;
                }
            }
        }

        private int ToIntDate(DateTime date)
        {
            return date.Month * 30 + date.Year * 365 + date.Day;
        }

        private void tbMaSo_G_TextChanged(object sender, EventArgs e)
        {
            if (DAO.SoTietKiemDAO.Instance.GetIdSTKbyIdCus(tbMaSo_G.Text))
            {
                stk = new DTO.SoTietKiem(DAO.SoTietKiemDAO.Instance.GetSTKbyID(Convert.ToDouble(tbMaSo_G.Text)));

                loaiSo = new DTO.LoaiSo(DAO.LoaiSoDAO.Instance.GetLoaiSoById(stk.IDLS));
            }
        }
    }
}
