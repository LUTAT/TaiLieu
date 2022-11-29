using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCafe.Data;

namespace QuanLyCafe.Controller
{
    internal class QuyenController
    {
        QuyenData quyenData = new QuyenData();
        public void HienThiCbo(ComboBox cbo)
        {
            cbo.DataSource = quyenData.LayDSQuyen().Tables[0];
            cbo.DisplayMember = "TenQuyen";
            cbo.ValueMember = "MaQuyen";
        }

    }
}
