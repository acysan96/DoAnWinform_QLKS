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
    public class User_DAL
    {
        // Khai báo database
        clsDatabase db = new clsDatabase();
        // Hàm login
        public DataTable login(User_DTO obj)
        {
            DataTable dtLogin = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("SP_Login", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@User_name", obj.Account);
            sqlCommand.Parameters.AddWithValue("@Password", obj.Password);
            SqlDataAdapter daLogin = new SqlDataAdapter(sqlCommand);
            daLogin.Fill(dtLogin);
            return dtLogin;
        }
        // Hàm lấy tất cả 
        public DataTable layToanBoUser()
        {
            DataTable data = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("LayToanBoUsers", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(data);
            return data;
        }
        // Hàm lấy 1
        public DataTable layMotUser(User_DTO obj)
        {
            DataTable data = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("LayMotUser", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", obj.Id);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(data);
            return data;
        }
        // Hàm thêm
        public int themUser(User_DTO obj)
        {
            int iKQ = 0;
            SqlCommand sqlCommand = new SqlCommand("ThemUser", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", obj.Id);
            sqlCommand.Parameters.AddWithValue("@Permission", obj.Permission);
            sqlCommand.Parameters.AddWithValue("@Full_name", obj.Ten);
            sqlCommand.Parameters.AddWithValue("@Gender", obj.GioiTinh);
            sqlCommand.Parameters.AddWithValue("@Birthday", obj.NgaySinh);
            sqlCommand.Parameters.AddWithValue("@Address", obj.DiaChi);
            sqlCommand.Parameters.AddWithValue("@Phone", obj.Phone);
            sqlCommand.Parameters.AddWithValue("@User_name", obj.Account);
            sqlCommand.Parameters.AddWithValue("@Password", obj.Password);
            iKQ = sqlCommand.ExecuteNonQuery();
            return iKQ;
        }
        // Hàm sửa
        public int suaUser(User_DTO obj)
        {
            int iKQ = 0;
            SqlCommand sqlCommand = new SqlCommand("SuaUser", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", obj.Id);
            sqlCommand.Parameters.AddWithValue("@Permission", obj.Permission);
            sqlCommand.Parameters.AddWithValue("@Full_name", obj.Ten);
            sqlCommand.Parameters.AddWithValue("@Gender", obj.GioiTinh);
            sqlCommand.Parameters.AddWithValue("@Birthday", obj.NgaySinh);
            sqlCommand.Parameters.AddWithValue("@Address", obj.DiaChi);
            sqlCommand.Parameters.AddWithValue("@Phone", obj.Phone);
            sqlCommand.Parameters.AddWithValue("@User_name", obj.Account);
            sqlCommand.Parameters.AddWithValue("@Password", obj.Password);
            iKQ = sqlCommand.ExecuteNonQuery();
            return iKQ;
        }
        // Hàm xóa
        public int xoaUser(User_DTO obj)
        {
            int iKQ = 0;
            SqlCommand sqlCommand = new SqlCommand("XoaUser", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", obj.Id);
            iKQ = sqlCommand.ExecuteNonQuery();
            return iKQ;
        }
    }
}
