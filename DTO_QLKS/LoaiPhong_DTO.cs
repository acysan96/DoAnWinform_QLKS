using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class LoaiPhong_DTO
    {
        string id;
        string name;
        int roomForRent;
        int roomReady;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int RoomForRent { get => roomForRent; set => roomForRent = value; }
        public int RoomReady { get => roomReady; set => roomReady = value; }

        public LoaiPhong_DTO(string id, string name, int roomForRent, int roomReady)
        {
            this.id = id;
            this.name = name;
            this.roomForRent = roomForRent;
            this.roomReady = roomReady;
        }

        public LoaiPhong_DTO(string id)
        {
            this.id = id;
        }
    }
}
