using System.Collections.Generic;
using Web.Models;

namespace Web.Services.Interfaces
{
    public interface IReservationService
    {
        List<ReservationModel> GetReservations();
    }
}
