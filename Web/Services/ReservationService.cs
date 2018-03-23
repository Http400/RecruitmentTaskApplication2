using DAL.Entities;
using DAL.Infrastructure;
using DAL.Repositories;
using System.Collections.Generic;
using Web.Models;
using Web.Services.Interfaces;

namespace Web.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IEntityBaseRepository<Reservation> _reservationRepository;
        private readonly IEntityBaseRepository<Guest> _guestRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ReservationService(IEntityBaseRepository<Reservation> reservationRepository, IEntityBaseRepository<Guest> guestRepository, IUnitOfWork unitOfWork)
        {
            _reservationRepository = reservationRepository;
            _guestRepository = guestRepository;
            _unitOfWork = unitOfWork;
        }

        public List<ReservationModel> GetReservations()
        {
            var reservations = _reservationRepository.GetAll();
            var result = new List<ReservationModel>();
            foreach (var reservation in reservations)
            {
                var guests = new List<GuestModel>();
                foreach (var guest in reservation.Guests)
                {
                    guests.Add(new GuestModel() {
                        ID = guest.ID,
                        Email = guest.Email,
                        Name = guest.Name,
                        Surname = guest.Surname,
                        Address = guest.Address,
                        City = guest.City,
                        PhoneNumber = guest.PhoneNumber,
                        PostCode = guest.PostCode,
                        Birthdate = guest.Birthdate
                    });
                }

                result.Add(new ReservationModel()
                {
                    ID = reservation.ID,
                    Code = reservation.Code,
                    CreationDate = reservation.CreationDate,
                    CheckInDate = reservation.CheckInDate,
                    CheckOutDate = reservation.CheckOutDate,
                    Price = reservation.Price,
                    Currency = reservation.Currency,
                    Commission = reservation.Commission,
                    Source = reservation.Source,
                    Guests = guests
                });
            }

            return result;
        }
    }
}