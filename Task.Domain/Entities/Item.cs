using System;
using System.Collections.Generic;
using System.Text;
using Task.Domain.Enums;

namespace Task.Domain.Entities
{
    public class Item
    {
        public Guid id { get; set; }

        public string name { get; set; }   
        
        public string description { get; set; }

        public bool IsUsing { get; set; }

        public itemType type { get; set; }

        // Navigation Property
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
