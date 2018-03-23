using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class ReservationModel
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string Currency { get; set; }
        public int Commission { get; set; }
        public string Source { get; set; }
        public List<GuestModel> Guests { get; set; }

        public ReservationModel()
        {
            Guests = new List<GuestModel>();
        }
    }
}