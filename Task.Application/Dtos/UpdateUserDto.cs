using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Application.Dtos
{
    public class UpdateUserDto
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public bool IsActive { get; set; }
    }
}
