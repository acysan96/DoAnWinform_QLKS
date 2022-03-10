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
    public class HangHoa_BUL
    {
        // Khai báo DAL
        HangHoa_DAL hangHoa_DAL = new HangHoa_DAL();
        // Hàm lấy toàn bộ
        public DataTable layToanBoHangHoa()
        {
            return hangHoa_DAL.layToanBoHangHoa();
        }
        // Hàm lấy 1
        public DataTable layMotHangHoa(HangHoa_DTO obj)
        {
            return hangHoa_DAL.layMotHangHoa(obj);
        }
        // Hàm thêm
        public int themHangHoa(HangHoa_DTO obj)
        {
            return hangHoa_DAL.themHangHoa(obj);
        }
        // Hàm sửa
        public int suaHangHoa(HangHoa_DTO obj)
        {
            return hangHoa_DAL.suaHangHoa(obj);
        }
        // Hàm xóa
        public int xoaHangHoa(HangHoa_DTO obj)
        {
            return hangHoa_DAL.xoaHangHoa(obj);
        }
    }
}
