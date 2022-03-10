using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLKS;
using DTO_QLKS;

namespace BUL_QLKS
{
    public class KhachHang_BUL
    {
        // Khai báo DAL
        KhachHang_DAL khachHang_DAL = new KhachHang_DAL();
        // Hàm lấy toàn bộ
        public DataTable layToanBoKhachHang()
        {
            return khachHang_DAL.layToanBoKhachHang();
        }
        // Hàm lấy 1
        public DataTable layMotKhachHang(KhachHang_DTO obj)
        {
            return khachHang_DAL.layMotKhachHang(obj);
        }
        // Hàm thêm
        public int themKhachHang(KhachHang_DTO obj)
        {
            return khachHang_DAL.themKhachHang(obj);
        }
        // Hàm sửa
        public int suaKhachHang(KhachHang_DTO obj)
        {
            return khachHang_DAL.suaKhachHang(obj);
        }
        // Hàm xóa
        public int xoaKhachHang(KhachHang_DTO obj)
        {
            return khachHang_DAL.xoaKhachHang(obj);
        }
    }
}
