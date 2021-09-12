using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.EF
{
    public class eShoppingDbContextFactory : IDesignTimeDbContextFactory<eShoppingDbContext>
    {
        public eShoppingDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("eShopSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<eShoppingDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new eShoppingDbContext(optionsBuilder.Options);
        }
    }
}
