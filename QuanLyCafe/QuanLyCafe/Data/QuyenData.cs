using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.Data
{
    internal class QuyenData
    {
        DataProvider cls = new DataProvider();
        public DataSet LayDSQuyen()
        {
            SqlCommand sqlcmd = new SqlCommand("select * from tb_Quyen");
            return cls.LayDuLieu(sqlcmd);
        }

    }
}
