using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class KhachHang_DTO
    {
        string id;
        string name;
        string rank;
        string phone;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Rank { get => rank; set => rank = value; }
        public string Phone { get => phone; set => phone = value; }

        public KhachHang_DTO(string id, string name, string rank, string phone)
        {
            this.id = id;
            this.name = name;
            this.rank = rank;
            this.phone = phone;
        }

        public KhachHang_DTO(string id)
        {
            this.id = id;
        }
    }
}
