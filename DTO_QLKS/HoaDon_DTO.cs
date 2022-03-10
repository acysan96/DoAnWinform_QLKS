using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class HoaDon_DTO
    {
        string id;
        string idUser;
        string idRoom;
        string idGuest;
        DateTime checkin;
        DateTime checkout;
        string paymentMethod;
        float totalPrice;

        public string Id { get => id; set => id = value; }
        public string IdUser { get => idUser; set => idUser = value; }
        public string IdRoom { get => idRoom; set => idRoom = value; }
        public string IdGuest { get => idGuest; set => idGuest = value; }
        public DateTime Checkin { get => checkin; set => checkin = value; }
        public DateTime Checkout { get => checkout; set => checkout = value; }
        public string PaymentMethod { get => paymentMethod; set => paymentMethod = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }

        public HoaDon_DTO(string id, string idUser, string idRoom, string idGuest, DateTime checkin, DateTime checkout, string paymentMethod, float totalPrice)
        {
            this.id = id;
            this.idUser = idUser;
            this.IdRoom = idRoom;
            this.idGuest = idGuest;
            this.checkin = checkin;
            this.checkout = checkout;
            this.paymentMethod = paymentMethod;
            this.totalPrice = totalPrice;
        }

        public HoaDon_DTO(string id)
        {
            this.id = id;
        }
    }
}
