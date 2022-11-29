using QuanLyCafe.BUS;
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
using System.IO;
using Guna.UI2.WinForms;
using System.Drawing.Imaging;


namespace QuanLyCafe
{
    public partial class frmAddUser : Form
    {
        NhanVienController nvController = new NhanVienController();
        QuyenController quyenCtrl = new QuyenController();
        public frmAddUser()
        {
            InitializeComponent();
            quyenCtrl.HienThiCbo(cbQuyen);
        }
        public delegate void DoEvent();
        public event DoEvent LoadNhanVien;
        #region Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
        #endregion

        #region Lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            if (KiemTraNhap() == true)
            {
                NhanVien nv = new NhanVien();
                nv.MaNV = nvController.GetID() + 1;
                nv.UserName = txtUserName.Text;
                nv.PassWord = txtPassWord.Text;
                nv.HoTen = txtHoTen.Text;
                nv.NgaySinh = Convert.ToDateTime(dtNgaySinh.Value);
                nv.DiaChi = txtDiaChi.Text;
                nv.SDT = txtSDT.Text;
                nv.CMND = txtCMND.Text;
                nv.GhiChu = txtGhiChu.Text;
                nv.MaQuyen = Convert.ToInt32(cbQuyen.SelectedValue);
                nv.AVatar = ConvertImageToBytes(picAvatar.Image);
                switch (nvController.Them(nv))
                {
                    case -1:
                        ThongBao(Color.LightPink, Color.DarkRed, "Thất Bại", "Tên Đăng Nhập Đã Tồn Tại", Properties.Resources.warning);
                        break;
                    case 0:
                        ThongBao(Color.LightPink, Color.DarkRed, "Thất Bại", "Số Điện Thoại Không Hợp Lệ", Properties.Resources.warning);
                        break;
                    case 1:
                        ThongBao(Color.LightGray, Color.SeaGreen, "Thành Công", "Thêm Tài Khoản Thành Công Thành Công", Properties.Resources._checked);
                        LoadNhanVien();
                        LamMoi();
                        break;
                }
            }    
        }

        #endregion

        #region Load Avatar
        private void btnLoadAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            { 
                Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
            };
                if (open.ShowDialog() == DialogResult.OK)
                {
                    picAvatar.Image = Image.FromFile(open.FileName);
                     
                }
        }
        byte[] ConvertImageToBytes(Image img)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }    
        }
       
        #endregion

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

        private bool KiemTraNhap()
        {
            if(picAvatar.Image == null)
            {
                ThongBao(Color.LightPink, Color.DarkRed, "Thất Bại", "Vui Lòng Thêm Ảnh", Properties.Resources.warning);
                return false;
            }    
            else if(txtUserName.Text == "")
            {
                ThongBao(Color.LightPink, Color.DarkRed, "Thất Bại", "Vui Lòng Nhập UserName", Properties.Resources.warning);
                return false;
            }
            else if (txtPassWord.Text == "")
            {
                ThongBao(Color.LightPink, Color.DarkRed, "Thất Bại", "Vui Lòng Nhập PassWord", Properties.Resources.warning);
                return false;
            }
            else if (txtHoTen.Text == "")
            {
                ThongBao(Color.LightPink, Color.DarkRed, "Thất Bại", "Vui Lòng Nhập Họ Tên", Properties.Resources.warning);
                return false;
            }
            else if (txtSDT.Text == "")
            {
                ThongBao(Color.LightPink, Color.DarkRed, "Thất Bại", "Vui Lòng Nhập SĐT", Properties.Resources.warning);
                return false;
            }
            else if (cbQuyen.SelectedValue == "")
            {
                ThongBao(Color.LightPink, Color.DarkRed, "Thất Bại", "Vui Lòng chọn Quyền", Properties.Resources.warning);
                return false;
            }
            return true;
        }

        void LamMoi()
        {

            txtMaNV.Clear();
            txtUserName.Clear();
            txtPassWord.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtCMND.Clear();
            txtGhiChu.Clear(); 
        } 
        #endregion


    }
}
