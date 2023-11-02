using Microsoft.EntityFrameworkCore;
using mywebapi.Models;
using mywebapi.Data;

namespace mywebapi.Data
{
    public class Dancehousedb : DbContext
    {
        public Dancehousedb(DbContextOptions<Dancehousedb> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
    }
}