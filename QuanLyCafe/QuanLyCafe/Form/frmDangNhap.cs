using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class frmDangNhap : Form
    {
        #region Khai Báo
        Login log = new Login();
        User user = new User();
        #endregion
        public frmDangNhap()
        {
            InitializeComponent();
            txtUserName.Select();
            
        }

        #region Thông Báo
            void ThongBao(Color backcolor, Color color, string title, string text, Image icon)
            {
                frmAlert frm = new frmAlert();
                frm.BackColor = backcolor;
                frm.ColorAlert = color;
                frm.TitleAlert = title;
                frm.TextAlert = text;
                frm.IconAlert = icon;
                frm.ShowDialog();
            }
        #endregion

        #region CLick Thoát
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region CLick Đăng Nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassWord.Text == "")
            {
                ThongBao(Color.LightPink, Color.DarkRed, "Thất Bại", "Vui lòng nhập đầy đủ thông tin", Properties.Resources.warning);
            }
            else if (log.DangNhap(txtUserName.Text, txtPassWord.Text, user))
            {
                ThongBao(Color.LightGray, Color.SeaGreen, "Thành Công", "Bạn Đã Đăng Nhập Thành Công", Properties.Resources._checked);
                frmTrangChu frm = new frmTrangChu(user);
                this.Hide();
                frm.Show();
            }
            else
            {
                ThongBao(Color.LightPink, Color.DarkRed, "Thất Bại", "Sai UserName Hoặc Mật Khẩu", Properties.Resources.warning);
            }
        }

        #endregion

    }
}
