



namespace shop.web.Data
{
    using Microsoft.EntityFrameworkCore;
    using shop.web.Data.Entities;

    public class DataContext:DbContext 
    {
        public DbSet<Product> Products { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

       
    }
}
