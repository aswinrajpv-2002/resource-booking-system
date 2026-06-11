using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Application.Dtos
{
    public class BookingReqDto
    {
        public Guid UserId { get; set; }

        public Guid ItemId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string? Purpose { get; set; }
    }
}
