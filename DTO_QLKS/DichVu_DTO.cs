using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DichVu_DTO
    {
        string id;
        string name;
        float price;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }

        public DichVu_DTO(string id, string name, float price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public DichVu_DTO(string id)
        {
            this.id = id;
        }
    }
}
