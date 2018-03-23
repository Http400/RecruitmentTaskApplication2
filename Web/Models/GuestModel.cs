using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class GuestModel
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public DateTime Birthdate { get; set; }
        public string PostCode { get; set; }
        public List<ReservationModel> Reservations { get; set; }

        public GuestModel()
        {
            Reservations = new List<ReservationModel>();
        }
    }
}