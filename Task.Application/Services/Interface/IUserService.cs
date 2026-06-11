using System;
using System.Collections.Generic;
using System.Text;
using Task.Application.Dtos;
using Task.Domain.Entities;

namespace Task.Application.Services.Interface
{
    public interface IUserService
    {
        public Task<User> createUserAsync(UserDto dto);
        public Task<List<User>> GetAllUsersAsync();

        public Task<bool> DeleteUserAsync(Guid id);

        public Task<User?> UpdateUserAsync(Guid id, UpdateUserDto dto);
    }
}
