using System;
using System.Collections.Generic;
using System.Text;
using Task.Application.Dtos;
using Task.Application.Services.Interface;
using Task.Domain.Entities;
using Task.Infrastructure.Persistance;

namespace Task.Application.Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context; 
        }
        public async Task<User> createUserAsync(UserDto dto) {
            var user = new User
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                IsActive = true
            };

            await _context.User.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;


        }
    }
}
