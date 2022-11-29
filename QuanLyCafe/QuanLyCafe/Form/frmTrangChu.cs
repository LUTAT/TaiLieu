using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class frmTrangChu : Form
    {
        private bool isCollapsed = true;
        User user = new User();
        public frmTrangChu(User user)
        {
            InitializeComponent();
            AnPnl();
            this.user = user;
            timeGio.Start();
            lbNgay.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbUserName.Text = user.HoTen;
            lbConTrol.Visible = false;
        }
        public frmTrangChu()
        {
            InitializeComponent();
            
        }
        #region Close
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Minimized
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        #endregion

        #region Click Khu Vực
        private void btnShowKhuVuc_Click(object sender, EventArgs e)
        {
            timeKhuVuc.Start();
        }
        private void timeKhuVuc_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                pnKhuVuc.Height += 10;
                if (pnKhuVuc.Size == pnKhuVuc.MaximumSize)
                {
                    timeKhuVuc.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                pnKhuVuc.Height -= 10;
                if (pnKhuVuc.Size == pnKhuVuc.MinimumSize)
                {
                    timeKhuVuc.Stop();
                    isCollapsed = true;
                }
            }
        }

        #endregion

        #region click Thực Đơn
        private void btnShowThucDon_Click(object sender, EventArgs e)
        {
            timeThucDon.Start();
        }
        private void timeThucDon_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                pnThucDon.Height += 10;
                if (pnThucDon.Size == pnThucDon.MaximumSize)
                {
                    timeThucDon.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                pnThucDon.Height -= 10;
                if (pnThucDon.Size == pnThucDon.MinimumSize)
                {
                    timeThucDon.Stop();
                    isCollapsed = true;
                }
            }
        }

        #endregion

        #region Click Kho Hàng
        private void btnShowKho_Click(object sender, EventArgs e)
        {
            timeKhoHang.Start();
        }
        private void timeKhoHang_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                pnKho.Height += 10;
                if (pnKho.Size == pnKho.MaximumSize)
                {
                    timeKhoHang.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                pnKho.Height -= 10;
                if (pnKho.Size == pnKho.MinimumSize)
                {
                    timeKhoHang.Stop();
                    isCollapsed = true;
                }
            }
        }

        #endregion

        #region Load Ngày Giờ
        private void timeGio_Tick(object sender, EventArgs e)
        {
            lbGio.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        #endregion

        #region Click LogOut
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn LogOut Không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == System.Windows.Forms.DialogResult.Yes)
            {
                user.DangXuat();
                frmDangNhap frm = new frmDangNhap();
                this.Hide();
                frm.Show();
            }
        }
        #endregion

        #region Xử Lý Chọn Button
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = pnShowForm.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnShowForm.Controls.Add(formulario);
                pnShowForm.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {
                formulario.BringToFront();
            }
        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["frmHeThong"] == null)
                pnHeThong.Visible = false;
            if (Application.OpenForms["frmNhanVien"] == null)
                pnNhanVien.Visible = false;
            if (Application.OpenForms["frmThucDon"] == null)
                pnlThucDon.Visible = false;
            if (Application.OpenForms["frmKhoHang"] == null)
                pnlKhoHang.Visible = false;
            if (Application.OpenForms["frmKhuVuc"] == null)
                pnlKhuVuc.Visible = false;
            if (Application.OpenForms["frmThuChi"] == null)
                pnlThuChi.Visible = false;
            if (Application.OpenForms["frmBaoCao"] == null)
                pnlBaoCao.Visible = false;
            if (Application.OpenForms["frmDSBan"] == null)
                pnlGoiBan.Visible = false;
        }
        private void AnPnl()
        {
            pnHeThong.Visible = false;
            pnNhanVien.Visible = false;
            pnlThucDon.Visible = false;
            pnlKhoHang.Visible = false;
            pnlKhuVuc.Visible = false;
            pnlThuChi.Visible = false;
            pnlBaoCao.Visible = false;
            pnlGoiBan.Visible = false;
        }
        #endregion

        #region Click Nhân Viên
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmNhanVien>();
            lbConTrol.Text = "Nhân Viên";
            lbConTrol.Visible = true;
            pnNhanVien.Visible = true;
        }
        #endregion
    }
}
