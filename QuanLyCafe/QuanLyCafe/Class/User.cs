using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace QuanLyCafe
{
    public class User
    {
        private string userName;
        private string hoTen;
        private int phanQuyen;
        private Image aVaTar;

        public string UserName { get => userName; set => userName = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public int PhanQuyen { get => phanQuyen; set => phanQuyen = value; }
        public Image AVaTar { get => aVaTar; set => aVaTar = value; }

        public User()
        {
        }

        public User(User user)
        {
            this.UserName = user.UserName;
            this.HoTen = user.HoTen;
            this.PhanQuyen = user.PhanQuyen;
            this.AVaTar = user.AVaTar;
        }

        //Hàm gán giá trị user sau khi đăng xuất.
        public void DangXuat()
        {
            this.UserName = "";
            this.HoTen = "";
            this.PhanQuyen = 0;
            
        }
    }
}
