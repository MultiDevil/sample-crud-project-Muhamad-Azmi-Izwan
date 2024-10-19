using Microsoft.EntityFrameworkCore;
using CrudApp.Models;

namespace CrudApp.Data
{
    public class ProductDb : DbContext
    {
        public ProductDb(DbContextOptions<ProductDb> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}