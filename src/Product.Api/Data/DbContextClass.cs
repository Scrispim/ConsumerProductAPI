
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Product.Api.Data
{
	public class DbContextClass : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DbContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Models.Product> Products { get; set; }
    }
}