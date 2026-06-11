using System;
using System.Collections.Generic;
using System.Text;
using Task.Domain.Enums;

namespace Task.Application.Dtos
{
    public class ItemDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public itemType Type { get; set; }
    }
}
