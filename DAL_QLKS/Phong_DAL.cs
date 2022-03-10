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
    public class Phong_DAL
    {
        // Khai báo database
        clsDatabase db = new clsDatabase();
        // Hàm lấy tất cả 
        public DataTable layToanBoPhong()
        {
            DataTable data = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("LayToanBoPhong", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(data);
            return data;
        }
        // Hàm lấy 1
        public DataTable layMotPhong(Phong_DTO obj)
        {
            DataTable data = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("LayMotPhong", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", obj.Id);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(data);
            return data;
        }
        // Hàm thêm
        public int themPhong(Phong_DTO obj)
        {
            int iKQ = 0;
            SqlCommand sqlCommand = new SqlCommand("ThemPhong", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", obj.Id);
            sqlCommand.Parameters.AddWithValue("@Num_of_beds", obj.NumOfBeds);
            sqlCommand.Parameters.AddWithValue("@Price_per_night", obj.PricePerNight);
            sqlCommand.Parameters.AddWithValue("@Status", obj.Status);
            iKQ = sqlCommand.ExecuteNonQuery();
            return iKQ;
        }
        // Hàm sửa
        public int suaPhong(Phong_DTO obj)
        {
            int iKQ = 0;
            SqlCommand sqlCommand = new SqlCommand("SuaPhong", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", obj.Id);
            sqlCommand.Parameters.AddWithValue("@Num_of_beds", obj.NumOfBeds);
            sqlCommand.Parameters.AddWithValue("@Price_per_night", obj.PricePerNight);
            sqlCommand.Parameters.AddWithValue("@Status", obj.Status);
            iKQ = sqlCommand.ExecuteNonQuery();
            return iKQ;
        }
        // Hàm xóa
        public int xoaPhong(Phong_DTO obj)
        {
            int iKQ = 0;
            SqlCommand sqlCommand = new SqlCommand("XoaPhong", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", obj.Id);
            iKQ = sqlCommand.ExecuteNonQuery();
            return iKQ;
        }
    }
}
