using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace PureFood.Data
{
    public class PureFoodContextFactory : IDesignTimeDbContextFactory<PureFoodDbContext>
    {
        public PureFoodDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                                  .SetBasePath(Directory.GetCurrentDirectory())
                                  .AddJsonFile("appsettings.json")
                                  .Build();
            var builder = new DbContextOptionsBuilder<PureFoodDbContext>();
            builder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            return new PureFoodDbContext(builder.Options);
        }
    }
}
