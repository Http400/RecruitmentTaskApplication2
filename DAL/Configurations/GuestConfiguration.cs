using DAL.Entities;

namespace DAL.Configurations
{
    public class GuestConfiguration : EntityBaseConfiguration<Guest>
    {
        public GuestConfiguration()
        {
            Property(g => g.Email).IsRequired();
            Property(g => g.Name).IsRequired();
            Property(g => g.Surname).IsRequired();
        }
    }
}
