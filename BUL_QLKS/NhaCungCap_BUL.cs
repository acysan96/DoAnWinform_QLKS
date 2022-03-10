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
    public class NhaCungCap_BUL
    {
        // Khai báo DAL
        NhaCungCap_DAL nhaCungCap_DAL = new NhaCungCap_DAL();
        // Hàm lấy toàn bộ
        public DataTable layToanBoNhaCungCap()
        {
            return nhaCungCap_DAL.layToanBoNhaCungCap();
        }
        // Hàm lấy 1
        public DataTable layMotNhaCungCap(NhaCungCap_DTO obj)
        {
            return nhaCungCap_DAL.layMotNhaCungCap(obj);
        }
        // Hàm thêm
        public int themNhaCungCap(NhaCungCap_DTO obj)
        {
            return nhaCungCap_DAL.themNhaCungCap(obj);
        }
        // Hàm sửa
        public int suaNhaCungCap(NhaCungCap_DTO obj)
        {
            return nhaCungCap_DAL.suaNhaCungCap(obj);
        }
        // Hàm xóa
        public int xoaNhaCungCap(NhaCungCap_DTO obj)
        {
            return nhaCungCap_DAL.xoaNhaCungCap(obj);
        }
    }
}
