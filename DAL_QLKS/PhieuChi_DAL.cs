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
    public class PhieuChi_DAL
    {
        // Khai báo database
        clsDatabase db = new clsDatabase();
        // Hàm lấy tất cả 
        public DataTable layToanBoPhieuChi()
        {
            DataTable data = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("LayToanBoPhieuChi", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(data);
            return data;
        }
        // Hàm lấy 1
        public DataTable layMotPhieuChi(PhieuChi_DTO obj)
        {
            DataTable data = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("LayMotPhieuChi", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", obj.Id);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(data);
            return data;
        }
        // Hàm thêm
        public int themPhieuChi(PhieuChi_DTO obj)
        {
            int iKQ = 0;
            SqlCommand sqlCommand = new SqlCommand("ThemPhieuChi", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", obj.Id);
            sqlCommand.Parameters.AddWithValue("@Id_goods", obj.IdGoods);
            sqlCommand.Parameters.AddWithValue("@Id_user", obj.IdUser);
            sqlCommand.Parameters.AddWithValue("@Total_price", obj.TotalPrice);
            sqlCommand.Parameters.AddWithValue("@Date_create", obj.DateCreate);
            sqlCommand.Parameters.AddWithValue("@Date_received", obj.DateReceived);
            iKQ = sqlCommand.ExecuteNonQuery();
            return iKQ;
        }
        // Hàm sửa
        public int suaPhieuChi(PhieuChi_DTO obj)
        {
            int iKQ = 0;
            SqlCommand sqlCommand = new SqlCommand("SuaPhieuChi", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", obj.Id);
            sqlCommand.Parameters.AddWithValue("@Id_goods", obj.IdGoods);
            sqlCommand.Parameters.AddWithValue("@Id_user", obj.IdUser);
            sqlCommand.Parameters.AddWithValue("@Total_price", obj.TotalPrice);
            sqlCommand.Parameters.AddWithValue("@Date_create", obj.DateCreate);
            sqlCommand.Parameters.AddWithValue("@Date_received", obj.DateReceived);
            iKQ = sqlCommand.ExecuteNonQuery();
            return iKQ;
        }
        // Hàm xóa
        public int xoaPhieuChi(PhieuChi_DTO obj)
        {
            int iKQ = 0;
            SqlCommand sqlCommand = new SqlCommand("XoaPhieuChi", db.sql);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", obj.Id);
            iKQ = sqlCommand.ExecuteNonQuery();
            return iKQ;
        }
    }
}
