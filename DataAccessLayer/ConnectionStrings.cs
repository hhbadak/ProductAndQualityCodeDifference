using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ConnectionStrings
    {
        public static SqlConnection sqlCon = new SqlConnection(@"Data Source=192.168.0.24,1433;Initial Catalog=esvit2020;User ID=esvit2021;Password=s3ss1st3m1;");
    }
}
