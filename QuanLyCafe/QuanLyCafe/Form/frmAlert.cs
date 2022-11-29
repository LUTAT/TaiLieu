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
    public partial class frmAlert : Form
    {
        public frmAlert()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Color BackColorAlert
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
        public Color ColorAlert
        {
            get { return LinArler.BackColor; }
            set { LinArler.BackColor = txtTitleArlert.ForeColor = txtTextArlert.ForeColor = value; }
        }
        public Image IconAlert
        {
            get { return picIcon.Image; }
            set { picIcon.Image = value; }
        }
        public String TitleAlert
        {
            get { return txtTitleArlert.Text; }
            set { txtTitleArlert.Text = value; }
        }
        public String TextAlert
        {
            get { return txtTextArlert.Text; }
            set { txtTextArlert.Text = value; }
        }
        private void PositionAlert()
        {
            int xPos = 0;
            int yPos = 0;
            xPos = Screen.GetWorkingArea(this).Width;
            yPos = Screen.GetWorkingArea(this).Height;
            this.Location = new Point(xPos - this.Width, yPos - this.Height);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LinArler.Width = LinArler.Width + 5;
            if (LinArler.Width == 500)
            {
                this.Close();
            }
        }
        private void frmAlert_Load(object sender, EventArgs e)
        {
            PositionAlert();
            for (int i = 0; i < 500; i++)
                timer1.Start();
        }
    }
}
