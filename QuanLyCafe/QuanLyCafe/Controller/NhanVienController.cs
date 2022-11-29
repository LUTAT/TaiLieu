using QuanLyCafe.BUS;
using QuanLyCafe.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe.Controller
{
    internal class NhanVienController
    {
        NhanVienData nvData = new NhanVienData();
        public int GetID()
        {
            return nvData.GetID();
        }
        public void HienThiDGV(DataGridView dgv)
        {
            dgv.DataSource = nvData.LayDSNhanVien().Tables[0];
        }

        public DataTable GetItems()
        {
            try
            {
                return nvData.LayDSNV().Tables[0];
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }

        public int Them(NhanVien nv)
        {
            if (!KiemTraSDT(nv.SDT))
                return 0;
            if (KiemTraTonTai(nv.UserName))
                return -1;
            return nvData.Them(nv);
        }
        public int Xoa(string username)
        {
            return nvData.Xoa(username);
        }

        public int Luu(NhanVien nv)
        {
            if (!KiemTraSDT(nv.SDT))
                return 0;
            return nvData.Sua(nv);
        }
        private bool KiemTraSDT(string sdt)
        {
            long k = 0;
            if (!long.TryParse(sdt, out k))
                return false;
            if (sdt.Length > 11)
                return false;
            return true;
        }
        public bool KiemTraTonTai(string username)
        {
            return nvData.KiemTraTonTai(username);
        }
    }
}
