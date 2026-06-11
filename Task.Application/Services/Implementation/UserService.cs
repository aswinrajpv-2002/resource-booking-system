using Microsoft.EntityFrameworkCore;
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
        public async Task<User> createUserAsync(UserDto dto)
        {
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

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _context.User.ToListAsync();
        }

        public async Task<bool> DeleteUserAsync(Guid id)
        {
            var user = await _context.User.FindAsync(id);
            if (user == null) return false;

            _context.User.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<User?> UpdateUserAsync(Guid id, UpdateUserDto dto)
        {
            var user = await _context.User.FindAsync(id);

            if (user == null) return null;

            user.FirstName = dto.FirstName;
            user.LastName = dto.LastName;
            user.IsActive = dto.IsActive;

            await _context.SaveChangesAsync();
            return user;
        }
    }
}
