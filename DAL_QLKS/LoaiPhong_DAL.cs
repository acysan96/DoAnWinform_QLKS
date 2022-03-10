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
    public class LoaiPhong_DAL
    {
        // Khai báo database
        clsDatabase db = new clsDatabase();
        // Hàm lấy tất cả 
        public DataTable layToanBoLoaiPhong()
        {
            DataTable data = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("LayToanBoLoaiPhong", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(data);
            return data;
        }
        // Hàm lấy 1
        public DataTable layMotLoaiPhong(LoaiPhong_DTO obj)
        {
            DataTable data = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("LayMotLoaiPhong", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", obj.Id);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(data);
            return data;
        }
        // Hàm thêm
        public int themLoaiPhong(LoaiPhong_DTO obj)
        {
            int iKQ = 0;
            SqlCommand sqlCommand = new SqlCommand("ThemLoaiPhong", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", obj.Id);
            sqlCommand.Parameters.AddWithValue("@Name", obj.Name);
            sqlCommand.Parameters.AddWithValue("@Room_for_rent", obj.RoomForRent);
            sqlCommand.Parameters.AddWithValue("@Room_ready", obj.RoomReady);
            iKQ = sqlCommand.ExecuteNonQuery();
            return iKQ;
        }
        // Hàm sửa
        public int suaLoaiPhong(LoaiPhong_DTO obj)
        {
            int iKQ = 0;
            SqlCommand sqlCommand = new SqlCommand("SuaLoaiPhong", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", obj.Id);
            sqlCommand.Parameters.AddWithValue("@Name", obj.Name);
            sqlCommand.Parameters.AddWithValue("@Room_for_rent", obj.RoomForRent);
            sqlCommand.Parameters.AddWithValue("@Room_ready", obj.RoomReady);
            iKQ = sqlCommand.ExecuteNonQuery();
            return iKQ;
        }
        // Hàm xóa
        public int xoaLoaiPhong(LoaiPhong_DTO obj)
        {
            int iKQ = 0;
            SqlCommand sqlCommand = new SqlCommand("XoaLoaiPhong", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", obj.Id);
            iKQ = sqlCommand.ExecuteNonQuery();
            return iKQ;
        }
    }
}
