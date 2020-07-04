using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;

namespace AppChamCong.CT
{
    public partial class DoiMatKhau : UserControl
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }
        TaiKhoan_BUL taikhoan = new TaiKhoan_BUL();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMKC.Text))
            {
                if (!string.IsNullOrEmpty(txtMKM.Text))
                {
                    if (!string.IsNullOrEmpty(txtNL.Text))
                    {
                        if (txtMKM.Text == txtNL.Text)
                        {
                            if (taikhoan.ChangePass(lblTaiKhoan.Text,txtMKM.Text)==true)
                            {
                                if (MessageBox.Show("Khởi Động Lại Phần Mềm Để Hoàn Tất Cập Nhật Mật Khẩu?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                                {
                                    label5_err.Text = null;
                                    label7_err.Text = null;
                                    label8_err.Text = null;
                                    Application.Restart();
                                }
                            }
                            else
                            {
                                label5_err.Text = "Sai Mật Khẩu!!";
                                label7_err.Text = null;
                                label8_err.Text = null;
                                txtMKC.Focus();
                            }
                        }
                        else
                        {
                            label8_err.Text = "Mật Khẩu Nhập Lại Không Giống!!";
                            label7_err.Text = null;
                            label5_err.Text = null;
                            txtNL.Focus();
                        }
                    }
                    else
                    {
                        label8_err.Text = "Lỗi!!";
                        label7_err.Text = null;
                        label5_err.Text = null;
                        txtNL.Focus();
                    }
                }
                else
                {
                    label7_err.Text = "Lỗi!!";
                    label8_err.Text = null;
                    label5_err.Text = null;
                    txtNL.Focus();
                }
            }
            else
            {
                label5_err.Text = "Lỗi!!";
                label7_err.Text = null;
                label8_err.Text = null;
                txtMKC.Focus();
            }
        }

    }
}
