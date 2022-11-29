using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCafe.Controller;
using QuanLyCafe.Data;

namespace QuanLyCafe
{
    public partial class frmNhanVien : Form
    {
        NhanVienController NVcontroller = new NhanVienController();
        private static frmNhanVien _instance;
        public static frmNhanVien Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new frmNhanVien();
                }
                return _instance;
            }
        }
        public frmNhanVien()
        {
            InitializeComponent();
            ShowConTrol();
            if (pnShow.Controls.Count == 0)
            {
                MessageBox.Show("Không Có Nhân Viên!");
            }
        }

        public void ShowConTrol()
        {
            pnShow.Controls.Clear();
            DataTable dt = NVcontroller.GetItems();
            if (dt != null)
            {
                if (dt.Rows.Count > 0) // also has some records in it
                { 
                    UserCtrl[] listItems = new UserCtrl[dt.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listItems[i] = new UserCtrl();
                            MemoryStream ms = new MemoryStream((byte[])row["Avata"]);
                            listItems[i].Avtar = new Bitmap(ms);
                            listItems[i].HoTen = row["HoTen"].ToString();
                            listItems[i].SDT = row["UserName"].ToString();
                            pnShow.Controls.Add(listItems[i]);
                            //listItems[i].Click += new System.EventHandler(this.userCtrl1_Click);
                        }
                    }
                }

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmAddUser frm = new frmAddUser();
            frm.LoadNhanVien += new frmAddUser.DoEvent(ShowConTrol);
            frm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
