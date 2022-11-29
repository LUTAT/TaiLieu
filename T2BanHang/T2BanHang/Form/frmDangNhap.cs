using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T2BanHang
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            lbThongBao.Visible = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "" || txtPassWord.Text == "")
            {
                lbThongBao.Visible = true;
                lbThongBao.Text = "UserName hoặc PassWord không được để trống";
            }
            else if(txtUserName.Text == "quangthien" && txtPassWord.Text == "12345")
            {
                lbThongBao.Visible = true;
                lbThongBao.Text = "Đăng nhập thành công";
            }
            else
            {
                lbThongBao.Visible = true;
                lbThongBao.Text = "Đăng nhập thất bại";
            }
        }
    }
}
