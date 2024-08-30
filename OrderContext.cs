using Microsoft.EntityFrameworkCore;
using Enterprise_Programming_in_C_Project.Models;

namespace Enterprise_Programming_in_C_Project.Data
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options) { }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
