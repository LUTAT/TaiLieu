using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCafe.BUS;
using System.Drawing;
using System.Xml.Linq;

namespace QuanLyCafe.Data
{
    internal class NhanVienData
    {

        DataProvider cls = new DataProvider();

        public int GetID()
        {
            string select = "SELECT MaNV ",
                from = "FROM tb_NhanVien ",
                orderBy = "ORDER BY MaNV DESC";
            SqlCommand cmd = new SqlCommand(select + from + orderBy);
            return cls.GetID(cmd);
        }
        public DataSet LayDSMotDong(string username)
        {
            SqlCommand cmd = new SqlCommand("select * from tb_NhanVien where UserName=@username");

            cmd.Parameters.Add("username", SqlDbType.NVarChar).Value = username;

            return cls.LayDuLieu(cmd);
        }
        public DataSet LayDSNhanVien()
        {
            SqlCommand sqlcmd = new SqlCommand("select MaNV, UserName, HoTen, NgaySinh, DiaChi, SDT, CMND, TenQuyen, GhiChu, Avata from tb_NhanVien, tb_Quyen where tb_NhanVien.MaQuyen = tb_Quyen.MaQuyen");
            return cls.LayDuLieu(sqlcmd);
        }
        public DataSet LayDSNV()
        {
            SqlCommand sqlcmd = new SqlCommand("select * from tb_NhanVien");
            return cls.LayDuLieu(sqlcmd);
        }
        public int Them(NhanVien nv)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into tb_NhanVien (MaNV,UserName,PassWord,HoTen,NgaySinh,DiaChi,SDT,CMND,GhiChu,MaQuyen,Avata) values(@manv,@username,@password,@hoten,@ngaysinh,@diachi,@sdt,@cmnd,@ghichu,@maquyen,@avatar)";
            cmd.Parameters.Add("manv", SqlDbType.Int).Value = nv.MaNV;
            cmd.Parameters.Add("username", SqlDbType.NVarChar).Value = nv.UserName;
            cmd.Parameters.Add("password", SqlDbType.NVarChar).Value = nv.PassWord;
            cmd.Parameters.Add("hoten", SqlDbType.NVarChar).Value = nv.HoTen;
            cmd.Parameters.Add("ngaysinh", SqlDbType.Date).Value = nv.NgaySinh;
            cmd.Parameters.Add("diachi", SqlDbType.NVarChar).Value = nv.DiaChi;
            cmd.Parameters.Add("sdt", SqlDbType.VarChar).Value = nv.SDT;
            cmd.Parameters.Add("cmnd", SqlDbType.NVarChar).Value = nv.CMND;
            cmd.Parameters.Add("ghichu", SqlDbType.NVarChar).Value = nv.GhiChu;
            cmd.Parameters.Add("avatar", SqlDbType.Image).Value = nv.AVatar;
            cmd.Parameters.Add("maquyen", SqlDbType.Int).Value = nv.MaQuyen;
            return cls.CapNhatDL(cmd);
        }
        public int Sua(NhanVien nv)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update tb_NhanVien set HoTen=@hoten,NgaySinh=@ngaysinh, DiaChi=@diachi, SDT=@sdt,cmnd=@cmnd, GhiChu=@ghichu, MaQuyen=@maquyen, Avata=@avatar where UserName=@username";
            cmd.Parameters.Add("username", SqlDbType.NVarChar).Value = nv.UserName;
            cmd.Parameters.Add("hoten", SqlDbType.NVarChar).Value = nv.HoTen;
            cmd.Parameters.Add("ngaysinh", SqlDbType.Date).Value = nv.NgaySinh;
            cmd.Parameters.Add("diachi", SqlDbType.NVarChar).Value = nv.DiaChi;
            cmd.Parameters.Add("sdt", SqlDbType.VarChar).Value = nv.SDT;
            cmd.Parameters.Add("cmnd", SqlDbType.VarChar).Value = nv.CMND;
            cmd.Parameters.Add("ghichu", SqlDbType.NVarChar).Value = nv.GhiChu;
            cmd.Parameters.Add("avatar", SqlDbType.Image).Value = nv.AVatar;
            cmd.Parameters.Add("maquyen", SqlDbType.Int).Value = nv.MaQuyen;
            return cls.CapNhatDL(cmd);
        }
        public int Xoa(string username)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM tb_NhanVien WHERE UserName = @username";
            cmd.Parameters.Add("username", SqlDbType.NVarChar).Value = username;
            return cls.CapNhatDL(cmd);
        }
        public bool KiemTraTonTai(string username)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from tb_NhanVien where UserName=@username";
            cmd.Parameters.Add("username", SqlDbType.NVarChar).Value = username;
            return (cls.LayDuLieu(cmd).Tables[0].Rows.Count > 0);
        }
    }
}
