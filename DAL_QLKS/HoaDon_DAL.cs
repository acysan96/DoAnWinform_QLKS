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
    public class HoaDon_DAL
    {
        // Khai báo database
        clsDatabase db = new clsDatabase();
        // Hàm lấy tất cả 
        public DataTable layToanBoHoaDon()
        {
            DataTable data = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("LayToanBoHoaDon", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(data);
            return data;
        }
        // Hàm lấy 1
        public DataTable layMotHoaDon(HoaDon_DTO obj)
        {
            DataTable data = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("LayMotHoaDon", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", obj.Id);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(data);
            return data;
        }
        // Hàm thêm
        public int themHoaDon(HoaDon_DTO obj)
        {
            int iKQ = 0;
            SqlCommand sqlCommand = new SqlCommand("ThemHoaDon", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", obj.Id);
            sqlCommand.Parameters.AddWithValue("@Id_user", obj.IdUser);
            sqlCommand.Parameters.AddWithValue("@Id_room", obj.IdRoom);
            sqlCommand.Parameters.AddWithValue("@Id_guest", obj.IdGuest);
            sqlCommand.Parameters.AddWithValue("@Date_checkin", obj.Checkin);
            sqlCommand.Parameters.AddWithValue("@Date_checkout", obj.Checkout);
            sqlCommand.Parameters.AddWithValue("@Payment_method", obj.PaymentMethod);
            sqlCommand.Parameters.AddWithValue("@Total_price", obj.TotalPrice);
            iKQ = sqlCommand.ExecuteNonQuery();
            return iKQ;
        }
        // Hàm sửa
        public int suaHoaDon(HoaDon_DTO obj)
        {
            int iKQ = 0;
            SqlCommand sqlCommand = new SqlCommand("SuaHoaDon", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", obj.Id);
            sqlCommand.Parameters.AddWithValue("@Id_user", obj.IdUser);
            sqlCommand.Parameters.AddWithValue("@Id_room", obj.IdRoom);
            sqlCommand.Parameters.AddWithValue("@Id_guest", obj.IdGuest);
            sqlCommand.Parameters.AddWithValue("@Date_checkin", obj.Checkin);
            sqlCommand.Parameters.AddWithValue("@Date_checkout", obj.Checkout);
            sqlCommand.Parameters.AddWithValue("@Payment_method", obj.PaymentMethod);
            sqlCommand.Parameters.AddWithValue("@Total_price", obj.TotalPrice);
            iKQ = sqlCommand.ExecuteNonQuery();
            return iKQ;
        }
        // Hàm xóa
        public int xoaHoaDon(HoaDon_DTO obj)
        {
            int iKQ = 0;
            SqlCommand sqlCommand = new SqlCommand("XoaHoaDon", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", obj.Id);
            iKQ = sqlCommand.ExecuteNonQuery();
            return iKQ;
        }

        // In danh sách hóa đơn
        public DataTable inDanhSachHoaDon()
        {
            DataTable data = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("InDanhSachHoaDon", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(data);
            return data;
        }

        // In hóa đơn
        public DataTable inHoaDon(HoaDon_DTO obj)
        {
            DataTable data = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("InHoaDon", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", obj.Id);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(data);
            return data;
        }
    }
}
