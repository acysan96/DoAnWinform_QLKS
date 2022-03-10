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
    public class User_BUL
    {
        // Khai báo DAL
        User_DAL user_DAL = new User_DAL();
        // Hàm login
        public DataTable login(User_DTO obj)
        {
            return user_DAL.login(obj);
        }
        // Hàm lấy toàn bộ
        public DataTable layToanBoUsers()
        {
            return user_DAL.layToanBoUser();
        }
        // Hàm lấy 1
        public DataTable layMotUser(User_DTO obj)
        {
            return user_DAL.layMotUser(obj);
        }
        // Hàm thêm
        public int themUser(User_DTO obj)
        {
            return user_DAL.themUser(obj);
        }
        // Hàm sửa
        public int suaUser(User_DTO obj)
        {
            return user_DAL.suaUser(obj);
        }
        // Hàm xóa
        public int xoaUser(User_DTO obj)
        {
            return user_DAL.xoaUser(obj);
        }
    }
}
