using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class User_DTO
    {
        private string id;
        private string permission;
        private string ten;
        private string gioiTinh;
        private DateTime ngaySinh;
        private string diaChi;
        private string phone;
        private string account;
        private string password;

        public string Id { get => id; set => id = value; }
        public string Permission { get => permission; set => permission = value; }
        public string Ten { get => ten; set => ten = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Account { get => account; set => account = value; }
        public string Password { get => password; set => password = value; }

        public User_DTO(string account, string password)
        {
            this.account = account;
            this.password = password;
        }

        public User_DTO(string id)
        {
            this.id = id;
        }

        public User_DTO(string id, string permission, string ten, string gioiTinh, DateTime ngaySinh, string diaChi, string phone, string account, string password)
        {
            this.id = id;
            this.permission = permission;
            this.ten = ten;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.phone = phone;
            this.account = account;
            this.password = password;
        }
    }
}
