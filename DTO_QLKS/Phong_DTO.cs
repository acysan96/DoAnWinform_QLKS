using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class Phong_DTO
    {
        string id;
        int numOfBeds;
        float pricePerNight;
        string status;

        public string Id { get => id; set => id = value; }
        public int NumOfBeds { get => numOfBeds; set => numOfBeds = value; }
        public float PricePerNight { get => pricePerNight; set => pricePerNight = value; }
        public string Status { get => status; set => status = value; }

        public Phong_DTO(string id, int num, float price, string status)
        {
            this.id = id;
            this.numOfBeds = num;
            this.pricePerNight = price;
            this.status = status;
        }

        public Phong_DTO(string id)
        {
            this.id = id;
        }
    }
}
