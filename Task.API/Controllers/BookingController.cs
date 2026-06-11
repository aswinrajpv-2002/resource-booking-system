using Microsoft.AspNetCore.Mvc;
using Task.Application.Dtos;
using Task.Application.Services.Interface;
using Task.Domain.Entities;
using Task.Domain.Enums;
using Task.Infrastructure.Persistance;

namespace Task.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingservice _bookingService;

        public BookingController(IBookingservice bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBooking(BookingReqDto request)
        {

            var booking = await _bookingService.CreateBookingAsync(request);
            return Ok(booking);
        }

    }
}
