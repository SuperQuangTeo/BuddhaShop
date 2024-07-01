using Microsoft.EntityFrameworkCore;

namespace BuddhaShop.Models
{
    public class BuddhaShopContext :DbContext
    {
        private readonly IConfiguration _configuration;

        public BuddhaShopContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetConnectionString("buddhashop");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
