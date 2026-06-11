using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Task.Application.Dtos;
using Task.Application.Services.Interface;

namespace Task.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(UserDto request)
        {
            var users= await _userService.createUserAsync(request);
            return Ok(users);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userService.GetAllUsersAsync();
            return Ok(users);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            var result = await _userService.DeleteUserAsync(id);
            if (!result) return NotFound();
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(Guid id,UpdateUserDto dto)
        {
            var result = await _userService.UpdateUserAsync(id, dto);
            if (result == null) return NotFound();
            return Ok(result);

        }
    }
}
