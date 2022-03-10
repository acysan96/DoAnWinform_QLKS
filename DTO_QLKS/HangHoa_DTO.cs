using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class HangHoa_DTO
    {
        string id;
        string idSup;
        string name;
        string type;
        float price;
        string unit;

        public string Id { get => id; set => id = value; }
        public string IdSup { get => idSup; set => idSup = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public float Price { get => price; set => price = value; }
        public string Unit { get => unit; set => unit = value; }

        public HangHoa_DTO(string id, string idSup, string name, string type, float price, string unit)
        {
            this.id = id;
            this.idSup = idSup;
            this.name = name;
            this.type = type;
            this.price = price;
            this.unit = unit;
        }

        public HangHoa_DTO(string id)
        {
            this.id = id;
        }
    }
}
