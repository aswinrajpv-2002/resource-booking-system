using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Application.Dtos
{
    public class UserDto
    {
        public Guid Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }
    }
}
