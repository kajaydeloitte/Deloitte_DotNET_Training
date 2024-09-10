using Microsoft.EntityFrameworkCore;

namespace WebApplication6.Models
{
    public class EntityModel
    {

        public class Product
        {
            public int ProductID { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
            public int Quantity { get; set; }
            public string Category { get; set; }
        }


        // DbContext used to perform operations on database tables
        public class ProductDbContext : DbContext
        {
            // This property refer the databse table 
            // Multiple tables required multiple properties
            public DbSet<Product> Products { get; set; }

            public ProductDbContext(DbContextOptions<ProductDbContext> options)
             : base(options)
            {

            }


        }
    }
}
