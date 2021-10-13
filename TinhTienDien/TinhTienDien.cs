using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTienDien
{
    public partial class frTinhTienDien : Form
    {
        public frTinhTienDien()
        {
            InitializeComponent();
            txtDinhMuc.Enabled = false;
            txtDGTDM.Enabled = false;
            txtDGNDM.Enabled = false;
        }
        
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            float TotalKgDiEN = 0;
            float TotalTienDien = 0;
           
            
            if (txtTenChuHo.Text == "")
            {
                MessageBox.Show("Chưa có thông tin chủ hộ!", "Thông báo", MessageBoxButtons.RetryCancel);
            }
            else if (txtChiSoCu.Text == "" || txtChiSoMoi.Text == "")
            {
                MessageBox.Show("Chỉ số nhập Thiếu!", "Thông báo", MessageBoxButtons.RetryCancel);
            }
            else if (float.Parse(txtChiSoMoi.Text) < float.Parse(txtChiSoCu.Text))
            {
                MessageBox.Show("Chỉ số nhập sai!", "Thông báo", MessageBoxButtons.RetryCancel);
            }

            else
            {
                if (cbHinhThucTieuThu.SelectedIndex == 0)
                {
                    TotalKgDiEN = (float.Parse(txtChiSoMoi.Text) - float.Parse(txtChiSoCu.Text));
                    if (TotalKgDiEN >= 100)
                    {
                        float TotalKgDienVuotNgoai = TotalKgDiEN - 100;
                        TotalTienDien = 100 * 450 + TotalKgDienVuotNgoai * 1020;
                    }
                    else
                    {
                        TotalTienDien = TotalKgDiEN * 450;
                    }
                    string ct = "";
                    ct += "Ông/Bà: " + txtTenChuHo.Text + "\n";
                    ct += "Đã sử dụng KW điện là: " + TotalKgDiEN.ToString() + "\n";
                    ct += "Thuộc hình thức tiêu thụ: " + cbHinhThucTieuThu.SelectedItem + "\n";
                    ct += "Với tổng số tiền là: " + TotalTienDien.ToString();
                    lbKeQua.Text = ct;
                }
                else if (cbHinhThucTieuThu.SelectedIndex == 1)
                {
                    TotalKgDiEN = (float.Parse(txtChiSoMoi.Text) - float.Parse(txtChiSoCu.Text));
                    if (TotalKgDiEN >= 500)
                    {
                        float TotalKgDienVuotNgoai = TotalKgDiEN - 500;
                        TotalTienDien = 500 * 550 + TotalKgDienVuotNgoai * 1100;
                    }
                    else
                    {
                        TotalTienDien = TotalKgDiEN * 550;
                    }
                    string ct = "";
                    ct += "Ông/Bà: " + txtTenChuHo.Text + "\n";
                    ct += "Đã sử dụng KW điện là: " + TotalKgDiEN.ToString() + "\n";
                    ct += "Thuộc hình thức tiêu thụ: " + cbHinhThucTieuThu.SelectedItem + "\n";
                    ct += "Với tổng số tiền là: " + TotalTienDien.ToString();
                    lbKeQua.Text = ct;
                }
                else if (cbHinhThucTieuThu.SelectedIndex == 2)
                {
                    TotalKgDiEN = (float.Parse(txtChiSoMoi.Text) - float.Parse(txtChiSoCu.Text));
                    if (TotalKgDiEN >= 350)
                    {
                        float TotalKgDienVuotNgoai = TotalKgDiEN - 350;
                        TotalTienDien = 350 * 780 + TotalKgDienVuotNgoai * 1550;
                    }
                    else
                    {
                        TotalTienDien = TotalKgDiEN * 780;
                    }
                    string ct = "";
                    ct += "Ông/Bà: " + txtTenChuHo.Text + "\n";
                    ct += "Đã sử dụng KW điện là: " + TotalKgDiEN.ToString() + "\n";
                    ct += "Thuộc hình thức tiêu thụ: " + cbHinhThucTieuThu.SelectedItem + "\n";
                    ct += "Với tổng số tiền là: " + TotalTienDien.ToString();
                    lbKeQua.Text = ct;
                }
            }
        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbHinhThucTieuThu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dinhmuc;
            int dgtdm;
            int dgndm;
            if (cbHinhThucTieuThu.SelectedIndex == 0)
            {
                dinhmuc = 100;
                dgtdm = 450;
                dgndm = 1020;
                txtDinhMuc.Text = dinhmuc.ToString();
                txtDGTDM.Text = dgtdm.ToString();
                txtDGNDM.Text = dgndm.ToString();
            }
            else if (cbHinhThucTieuThu.SelectedIndex == 1)
            {
                dinhmuc = 500;
                dgtdm = 550;
                dgndm = 1100;
                txtDinhMuc.Text = dinhmuc.ToString();
                txtDGTDM.Text = dgtdm.ToString();
                txtDGNDM.Text = dgndm.ToString();
            }
            else if (cbHinhThucTieuThu.SelectedIndex == 2)
            {
                dinhmuc = 350;
                dgtdm = 780;
                dgndm = 1550;
                txtDinhMuc.Text = dinhmuc.ToString();
                txtDGTDM.Text = dgtdm.ToString();
                txtDGNDM.Text = dgndm.ToString();
            }
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
