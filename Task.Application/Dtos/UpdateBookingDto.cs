using System;
using System.Collections.Generic;
using System.Text;
using Task.Domain.Enums;

namespace Task.Application.Dtos
{
    public class UpdateBookingDto
    {
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string? Purpose { get; set; }

        public BookingStatus Status { get; set; }
    }
}
