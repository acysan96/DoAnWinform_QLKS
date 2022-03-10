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
    public class LoaiPhong_BUL
    {
        // Khai báo DAL
        LoaiPhong_DAL loaiPhong_DAL = new LoaiPhong_DAL();
        // Hàm lấy toàn bộ
        public DataTable layToanBoLoaiPhong()
        {
            return loaiPhong_DAL.layToanBoLoaiPhong();
        }
        // Hàm lấy 1
        public DataTable layMotLoaiPhong(LoaiPhong_DTO obj)
        {
            return loaiPhong_DAL.layMotLoaiPhong(obj);
        }
        // Hàm thêm
        public int themLoaiPhong(LoaiPhong_DTO obj)
        {
            return loaiPhong_DAL.themLoaiPhong(obj);
        }
        // Hàm sửa
        public int suaLoaiPhong(LoaiPhong_DTO obj)
        {
            return loaiPhong_DAL.suaLoaiPhong(obj);
        }
        // Hàm xóa
        public int xoaLoaiPhong(LoaiPhong_DTO obj)
        {
            return loaiPhong_DAL.xoaLoaiPhong(obj);
        }
    }
}
