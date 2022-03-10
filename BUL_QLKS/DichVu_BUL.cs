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
    public class DichVu_BUL
    {
        // Khai báo DAL
        DichVu_DAL dichVu_DAL = new DichVu_DAL();
        // Hàm lấy toàn bộ
        public DataTable layToanBoDichVu()
        {
            return dichVu_DAL.layToanBoDichVu();
        }
        // Hàm lấy 1
        public DataTable layMotDichVu(DichVu_DTO obj)
        {
            return dichVu_DAL.layMotDichVu(obj);
        }
        // Hàm thêm
        public int themDichVu(DichVu_DTO obj)
        {
            return dichVu_DAL.themDichVu(obj);
        }
        // Hàm sửa
        public int suaDichVu(DichVu_DTO obj)
        {
            return dichVu_DAL.suaDichVu(obj);
        }
        // Hàm xóa
        public int xoaDichVu(DichVu_DTO obj)
        {
            return dichVu_DAL.xoaDichVu(obj);
        }
    }
}
