using Microsoft.EntityFrameworkCore;
using SixminApi.Models;

namespace SixminApi.Data
{
    public class AppDbContext: DbContext
    {
        private readonly IConfiguration _configuration;
        public AppDbContext(DbContextOptions<AppDbContext> options,IConfiguration configuration): base(options)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       // optionsBuilder.UseSqlServer(_configuration.GetConnectionString("SQLDbConnection"));
    }
        public DbSet<Command> Commands => Set<Command>();
    }
}