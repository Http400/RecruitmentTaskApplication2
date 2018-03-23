using DAL.Entities;

namespace DAL.Configurations
{
    public class ReservationConfiguration : EntityBaseConfiguration<Reservation>
    {
        public ReservationConfiguration()
        {
            Property(r => r.Code).IsRequired().HasMaxLength(10);
            Property(r => r.Price).IsRequired();
            Property(r => r.CreationDate).IsRequired();
            Property(r => r.CheckInDate).IsRequired();
            Property(r => r.CheckOutDate).IsRequired();
            Property(r => r.Currency).IsRequired();
        }
    }
}
