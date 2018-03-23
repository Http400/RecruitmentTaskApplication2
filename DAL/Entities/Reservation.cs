using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public class Reservation : IEntityBase
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
        public ICollection<Guest> Guests { get; set; }
    }
}
