namespace DAL.Migrations
{
    using DAL.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.MyDatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.MyDatabaseContext context)
        {
            context.GuestSet.AddOrUpdate(g => g.Email, new Guest[] 
            {
                new Guest()
                {
                    Email = "john@doe.com",
                    Name = "John",
                    Surname = "Doe",
                    Birthdate = new DateTime(1980, 3, 4),
                    PostCode = "32-321",
                    Reservations = new List<Reservation>() 
                    {
                        new Reservation()
                        {
                            Code = "dqe12e1d",
                            CreationDate = DateTime.Now,
                            CheckInDate = new DateTime(2018,5,1),
                            CheckOutDate = new DateTime(2018,5,7),
                            Currency = "PLN",
                            Price = 2000m
                        }
                    }
                },
                new Guest()
                {
                    Email = "jane@smith.com",
                    Name = "Jane",
                    Surname = "Smith",
                    Birthdate = new DateTime(1985, 7, 23),
                    PostCode = "28-180",
                    Reservations = new List<Reservation>() 
                    {
                        new Reservation()
                        {
                            Code = "db78awd",
                            CreationDate = DateTime.Now,
                            CheckInDate = new DateTime(2018,6,14),
                            CheckOutDate = new DateTime(2018,6,28),
                            Currency = "PLN",
                            Price = 4000m
                        },
                        new Reservation()
                        {
                            Code = "dawb6789d",
                            CreationDate = DateTime.Now,
                            CheckInDate = new DateTime(2018,8,7),
                            CheckOutDate = new DateTime(2018,8,14),
                            Currency = "PLN",
                            Price = 3000m
                        }
                    }
                }
            });
        }
    }
}
