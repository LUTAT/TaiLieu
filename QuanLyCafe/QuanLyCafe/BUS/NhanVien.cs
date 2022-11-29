using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace QuanLyCafe.BUS
{
    internal class NhanVien
    {

        private int maNV;
        private string userName;
        private string passWord;
        private string hoTen;
        private DateTime ngaySinh;
        private string sDT;
        private string cMND;
        private string diaChi;
        private string ghiChu;
        private int maQuyen;
        private byte[] aVatar;

        public int MaNV { get => maNV; set => maNV = value; }
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string CMND { get => cMND; set => cMND = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public int MaQuyen { get => maQuyen; set => maQuyen = value; }
        public byte[] AVatar { get => aVatar; set => aVatar = value; }
    }
}
