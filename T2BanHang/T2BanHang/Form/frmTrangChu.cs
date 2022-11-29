using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T2BanHang.Class;

namespace T2BanHang
{
    public partial class frmTrangChu : Form
    {
        private bool IsCollap = true;

        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn thoát Không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
               Application.Exit();
            }
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #region sự kiện API
        private void AbrirFormEnPanel(Form form)
        {
            Form[] child = this.MdiChildren;
            foreach (Form childForm in child)
            {
                childForm.Close();
            }
            if (!pnShowForm.Controls.Contains(form))
            {
                if (pnShowForm.Controls.Count > 0)
                {
                    pnShowForm.Controls.Clear();
                }
                form.TopLevel = false;
                pnShowForm.Controls.Add(form);
                form.Dock = DockStyle.Fill;
                form.Show();
                form.BringToFront();
            }
            else
            {
                form.BringToFront();
            }
        }
        #endregion

        
    }
}
