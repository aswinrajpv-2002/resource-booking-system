using Microsoft.AspNetCore.Mvc;
using Task.Application.Dtos;
using Task.Application.Services.Implementation;
using Task.Application.Services.Interface;
using Task.Domain.Entities;


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
        [HttpGet]
        public async Task<IActionResult> GetAllBookings()
        {
            var bookings = await _bookingService.GetAllBookingAsync();
            return Ok(bookings);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteBookingAsync(Guid id)
        {
            var result = await _bookingService.DeleteBookingAsync(id);
            if (!result) return NotFound();
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBooking(Guid id,UpdateBookingDto dto)
        {
            var booking = await _bookingService.UpdateBookingAsync(id,dto);
            if (booking == null) return NotFound();
            return Ok(booking);
        }

    }
}
