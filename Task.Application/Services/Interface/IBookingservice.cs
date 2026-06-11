using System;
using System.Collections.Generic;
using System.Text;
using Task.Application.Dtos;
using Task.Domain.Entities;

namespace Task.Application.Services.Interface
{
    public interface IBookingservice
    {
        Task<Booking> CreateBookingAsync(BookingReqDto dto);
        Task<List<Booking>> GetAllBookingAsync();
    }
}
