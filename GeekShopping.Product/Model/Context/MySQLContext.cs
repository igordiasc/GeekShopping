using Microsoft.EntityFrameworkCore;

namespace GeekShoppingProduct.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}
        public DbSet<Product> Products { get; set;}
        
    }
}
