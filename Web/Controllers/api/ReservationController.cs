using System;
using System.Net;
using System.Web.Http;
using Web.Services.Interfaces;

namespace Web.Controllers.api
{
    public class ReservationController : ApiController
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet]
        public IHttpActionResult GetReservations()
        {
            try
            {
                var reservations = _reservationService.GetReservations();
                return Ok(reservations);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, "An error occured. Please try again.");
            }
        }
    }
}