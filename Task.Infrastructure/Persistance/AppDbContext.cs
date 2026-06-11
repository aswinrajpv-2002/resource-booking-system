using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Task.Domain.Entities;
using Task.Infrastructure.Persistance;

namespace Task.Infrastructure.Persistance
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<User> User { get; set; }
        public DbSet<Item> Items { get; set; }

        public DbSet<Booking> Bookings { get; set; }
    }
}
