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
    public class ItemService : IItemService
    {
        private readonly AppDbContext _context;

        public ItemService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Item> CreateItemAsync(ItemDto dto)
        {
            var items = new Item
            {
                id = Guid.NewGuid(),
                name = dto.Name,
                description = dto.Description,
                type = dto.Type,
                IsUsing = false
            };

            await _context.Items.AddAsync(items);
            await _context.SaveChangesAsync();

            return items;
        }

        public async Task<List<Item>> GetAllItemsAsync()
        {
           return  await _context.Items.ToListAsync();
        }

        public async Task<bool> DeleteItemAsync(Guid id)
        {
            var item = await _context.Items.FindAsync(id);
            if (item == null) return false;
            _context.Items.Remove(item);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
