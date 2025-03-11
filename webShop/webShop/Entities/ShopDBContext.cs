using Microsoft.EntityFrameworkCore;

namespace webShop.Entities
{
    public class ShopDBContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-78310MP\\SQLEXPRESS;Database=Shop_db;Trusted_Connection=True;");
        }
    }
}
