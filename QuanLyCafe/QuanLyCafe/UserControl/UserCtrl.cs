using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCafe.Controller;

namespace QuanLyCafe
{
    public partial class UserCtrl : UserControl
    {
        User user = new User();
        NhanVienController nvController = new NhanVienController();
        private static UserCtrl _instance;
        public static UserCtrl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserCtrl();
                }
                return _instance;
            }
        }
        public UserCtrl()
        {
            InitializeComponent();
        }
        public UserCtrl(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        private Image avtar;
        private string hoTen;
        private string sDT;
        public Image Avtar
        {
            get { return avtar; }
            set { avtar = value; picAvatar.Image = value; }
        }
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; lbName.Text = value; }
        }
        public string SDT
        {
            get { return sDT; }
            set { sDT = value; lbChucVu.Text = value; }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (user.UserName == lbChucVu.Text)
            {
                ThongBao(Color.LightPink, Color.DarkRed, "Thất Bại", "Tài Khoản này đang được sử dụng", Properties.Resources.warning);
            }
            else
            {
                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == System.Windows.Forms.DialogResult.Yes)
                {
                    string username = lbChucVu.Text;
                    nvController.Xoa(username);
                    frmNhanVien.Instance.ShowConTrol();
                    ThongBao(Color.LightGray, Color.SeaGreen, "Thành Công", "Xóa Thành Công", Properties.Resources._checked);
                }
            }
        }
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
    }
}
