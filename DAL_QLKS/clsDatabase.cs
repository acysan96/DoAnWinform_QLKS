using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLKS
{
    class clsDatabase
    {
        public SqlConnection sql = new SqlConnection();
        string sConn = @"Data Source=DESKTOP-R5VP0BU\SQLEXPRESS;Initial Catalog=Database_QLKS;Integrated Security=True";
        public clsDatabase()
        {
            try
            {
                sql.ConnectionString = sConn;
                sql.Open();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
