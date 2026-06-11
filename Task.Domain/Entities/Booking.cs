using System;
using System.Collections.Generic;
using System.Text;
using Task.Domain.Enums;

namespace Task.Domain.Entities
{
    public class Booking
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid ItemId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public BookingStatus Status { get; set; }

        public string? Purpose { get; set; }

        // Navigation Properties
        public User User { get; set; } = null!;

        public Item Item { get; set; } = null!;

    }
}
