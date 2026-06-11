using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public bool IsActive { get; set; }

        public ICollection<Booking>? Bookings { get; set; }

    }
}
