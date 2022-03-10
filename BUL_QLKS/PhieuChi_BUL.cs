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
    public class PhieuChi_BUL
    {
        // Khai báo DAL
        PhieuChi_DAL phieuChi_DAL = new PhieuChi_DAL();
        // Hàm lấy toàn bộ
        public DataTable layToanBoPhieuChi()
        {
            return phieuChi_DAL.layToanBoPhieuChi();
        }
        // Hàm lấy 1
        public DataTable layMotPhieuChi(PhieuChi_DTO obj)
        {
            return phieuChi_DAL.layMotPhieuChi(obj);
        }
        // Hàm thêm
        public int themPhieuChi(PhieuChi_DTO obj)
        {
            return phieuChi_DAL.themPhieuChi(obj);
        }
        // Hàm sửa
        public int suaPhieuChi(PhieuChi_DTO obj)
        {
            return phieuChi_DAL.suaPhieuChi(obj);
        }
        // Hàm xóa
        public int xoaPhieuChi(PhieuChi_DTO obj)
        {
            return phieuChi_DAL.xoaPhieuChi(obj);
        }
    }
}
