using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task.Application.Dtos;
using Task.Application.Services.Implementation;
using Task.Application.Services.Interface;

namespace Task.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }
        [HttpPost]
        public async Task<IActionResult> CreateItem(ItemDto request)
        {
            var items = await _itemService.CreateItemAsync(request);
            return Ok(items);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllItems()
        {
            var items = await _itemService.GetAllItemsAsync();
            return Ok(items);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteItem(Guid id)
        {
            var result = await _itemService.DeleteItemAsync(id);
            if (!result) return NotFound();
            return NoContent();
        }
    }
}
