using Microsoft.EntityFrameworkCore;

namespace Assignment12.Models
{
    public class OrderContext:DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {
            // 自动建库建表
            this.Database.EnsureCreated();
        }
        public DbSet<Order> Orders {get; set;}
        public DbSet<OrderDetail> OrderDetails {get; set;}
    }
}