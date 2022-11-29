using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2BanHang.Class
{
    public class User
    {

        private string userName;
        private string hoTen;
        private string sDT;
        private string cCCD;
        private string diaChi;
        private DateTime ngaySinh;
        private string ghiChu;

        public string UserName { get => userName; set => userName = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string CCCD { get => cCCD; set => cCCD = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }

        public User()
        {
            this.UserName = "quangthien";
            this.HoTen = "Trần Quang Thiện";
            this.NgaySinh = Convert.ToDateTime("30/07/1999");
            this.SDT = "0327869533";
            this.CCCD = "0774821442";
            this.DiaChi = "Quốc Lộ 1A";
            this.GhiChu = "";
        }

        public User(User user)
        {
            this.UserName = user.UserName;
            this.HoTen = user.HoTen;
            this.NgaySinh = user.NgaySinh;
            this.SDT = user.SDT;
            this.CCCD = user.CCCD;
            this.DiaChi = user.DiaChi;
            this.GhiChu = user.GhiChu;
        }

        //Hàm gán giá trị user sau khi đăng xuất.
        public void dangXuat()
        {
            this.UserName = "";
            this.HoTen = "";
            this.NgaySinh = Convert.ToDateTime("30/07/1999");
            this.SDT = "";
            this.CCCD = "";
            this.DiaChi = "";
            this.GhiChu = "";
        }

    }
}
