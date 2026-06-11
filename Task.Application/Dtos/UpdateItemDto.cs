using System;
using System.Collections.Generic;
using System.Text;
using Task.Domain.Enums;

namespace Task.Application.Dtos
{
    public class UpdateItemDto
    {
        public string name { get; set; }

        public string description { get; set; }

        public bool IsUsing { get; set; }

        public itemType type { get; set; }
    }
}
