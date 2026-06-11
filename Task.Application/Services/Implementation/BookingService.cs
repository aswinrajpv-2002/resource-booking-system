using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Task.Application.Dtos;
using Task.Application.Services.Interface;
using Task.Domain.Entities;
using Task.Infrastructure.Persistance;

namespace Task.Application.Services.Implementation
{
    public class BookingService : IBookingservice
    {
        private readonly AppDbContext _context;

        public BookingService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Booking> CreateBookingAsync(BookingReqDto dto)
        {
            var booking = new Booking
            {
                UserId = dto.UserId,
                ItemId = dto.ItemId,
                StartDate = dto.StartDate,
                EndDate = dto.EndDate,
                Purpose = dto.Purpose
            };
            await _context.Bookings.AddAsync(booking);

            await _context.SaveChangesAsync();

            return booking;
        }


        public async Task<List<Booking>> GetAllBookingAsync()
        {
            return await _context.Bookings.ToListAsync();
        }
        
        public async Task<bool> DeleteBookingAsync(Guid id)
        {
            var booking = await _context.Bookings.FindAsync(id);

            if (booking == null) return false;

            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
