using Microsoft.EntityFrameworkCore;
using aspcore3_efcore3.Models;

namespace aspcore3_efcore3.Data 
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {}

        public DbSet<Product> Products {get;set;}
        public DbSet<Category> Categories {get; set;}
    }
}