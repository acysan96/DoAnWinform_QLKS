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
    public class HoaDon_BUL
    {
        // Khai báo DAL
        HoaDon_DAL hoaDon_DAL = new HoaDon_DAL();
        // Hàm lấy toàn bộ
        public DataTable layToanBoHoaDon()
        {
            return hoaDon_DAL.layToanBoHoaDon();
        }
        // Hàm lấy 1
        public DataTable layMotHoaDon(HoaDon_DTO obj)
        {
            return hoaDon_DAL.layMotHoaDon(obj);
        }
        // Hàm thêm
        public int themHoaDon(HoaDon_DTO obj)
        {
            return hoaDon_DAL.themHoaDon(obj);
        }
        // Hàm sửa
        public int suaHoaDon(HoaDon_DTO obj)
        {
            return hoaDon_DAL.suaHoaDon(obj);
        }
        // Hàm xóa
        public int xoaHoaDon(HoaDon_DTO obj)
        {
            return hoaDon_DAL.xoaHoaDon(obj);
        }

        // In danh sách hóa đơn
        public DataTable inDanhSachHoaDon()
        {
            return hoaDon_DAL.inDanhSachHoaDon();
        }

        // In hóa đơn
        public DataTable inHoaDon(HoaDon_DTO obj)
        {
            return hoaDon_DAL.inHoaDon(obj);
        }
    }
}
