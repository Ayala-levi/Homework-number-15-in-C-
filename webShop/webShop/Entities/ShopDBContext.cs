using Microsoft.EntityFrameworkCore;

namespace webShop.Entities
{
    public class ShopDBContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-783IDMP\\SQLEXPRESS;Database=shop_db;Integrated Security=True;TrustServerCertificate=True");
        }

        public DbSet<Product> Products { get; set; }

        //כאן נוסיף עוד טבלאות



    }
}
