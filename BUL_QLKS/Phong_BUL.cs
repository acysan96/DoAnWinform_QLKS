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
    public class Phong_BUL
    {
        // Khai báo DAL
        Phong_DAL phong_DAL = new Phong_DAL();
        // Hàm lấy toàn bộ
        public DataTable layToanBoPhong()
        {
            return phong_DAL.layToanBoPhong();
        }
        // Hàm lấy 1
        public DataTable layMotPhong(Phong_DTO obj)
        {
            return phong_DAL.layMotPhong(obj);
        }
        // Hàm thêm
        public int themPhong(Phong_DTO obj)
        {
            return phong_DAL.themPhong(obj);
        }
        // Hàm sửa
        public int suaPhong(Phong_DTO obj)
        {
            return phong_DAL.suaPhong(obj);
        }
        // Hàm xóa
        public int xoaPhong(Phong_DTO obj)
        {
            return phong_DAL.xoaPhong(obj);
        }
    }
}
