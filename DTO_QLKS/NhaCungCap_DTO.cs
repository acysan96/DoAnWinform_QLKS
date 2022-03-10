using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class NhaCungCap_DTO
    {
        string id;
        string name;
        string phone;
        string address;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }

        public NhaCungCap_DTO(string id, string name, string phone, string address)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.address = address;
        }

        public NhaCungCap_DTO(string id)
        {
            this.id = id;
        }
    }
}
