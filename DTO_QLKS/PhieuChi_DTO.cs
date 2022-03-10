using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class PhieuChi_DTO
    {
        string id;
        string idGoods;
        string idUser;
        float totalPrice;
        DateTime dateCreate;
        DateTime dateReceived;

        public string Id { get => id; set => id = value; }
        public string IdGoods { get => idGoods; set => idGoods = value; }
        public string IdUser { get => idUser; set => idUser = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        public DateTime DateCreate { get => dateCreate; set => dateCreate = value; }
        public DateTime DateReceived { get => dateReceived; set => dateReceived = value; }

        public PhieuChi_DTO(string id, string idGoods, string idUser, float totalPrice, DateTime dateCreate, DateTime dateReceived)
        {
            this.id = id;
            this.idGoods = idGoods;
            this.IdUser = idUser;
            this.totalPrice = totalPrice;
            this.dateCreate = dateCreate;
            this.dateReceived = dateReceived;
        }

        public PhieuChi_DTO(string id)
        {
            this.id = id;
        }
    }
}
