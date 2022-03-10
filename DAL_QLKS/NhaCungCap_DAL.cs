using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_QLKS;

namespace DAL_QLKS
{
    public class NhaCungCap_DAL
    {
        // Khai báo database
        clsDatabase db = new clsDatabase();
        // Hàm lấy tất cả 
        public DataTable layToanBoNhaCungCap()
        {
            DataTable data = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("LayToanBoNhaCungCap", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(data);
            return data;
        }
        // Hàm lấy 1
        public DataTable layMotNhaCungCap(NhaCungCap_DTO obj)
        {
            DataTable data = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("LayMotNhaCungCap", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", obj.Id);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(data);
            return data;
        }
        // Hàm thêm
        public int themNhaCungCap(NhaCungCap_DTO obj)
        {
            int iKQ = 0;
            SqlCommand sqlCommand = new SqlCommand("ThemNhaCungCap", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", obj.Id);
            sqlCommand.Parameters.AddWithValue("@Name", obj.Name);
            sqlCommand.Parameters.AddWithValue("@Phone", obj.Phone);
            sqlCommand.Parameters.AddWithValue("@Address", obj.Address);
            iKQ = sqlCommand.ExecuteNonQuery();
            return iKQ;
        }
        // Hàm sửa
        public int suaNhaCungCap(NhaCungCap_DTO obj)
        {
            int iKQ = 0;
            SqlCommand sqlCommand = new SqlCommand("SuaNhaCungCap", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", obj.Id);
            sqlCommand.Parameters.AddWithValue("@Name", obj.Name);
            sqlCommand.Parameters.AddWithValue("@Phone", obj.Phone);
            sqlCommand.Parameters.AddWithValue("@Address", obj.Address);
            iKQ = sqlCommand.ExecuteNonQuery();
            return iKQ;
        }
        // Hàm xóa
        public int xoaNhaCungCap(NhaCungCap_DTO obj)
        {
            int iKQ = 0;
            SqlCommand sqlCommand = new SqlCommand("XoaNhaCungCap", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", obj.Id);
            iKQ = sqlCommand.ExecuteNonQuery();
            return iKQ;
        }
    }
}
