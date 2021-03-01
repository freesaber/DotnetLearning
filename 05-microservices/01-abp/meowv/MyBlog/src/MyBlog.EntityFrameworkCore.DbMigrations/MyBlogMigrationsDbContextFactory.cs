using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyBlog.Domain.Configurations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.EntityFrameworkCore.DbMigrations
{
    public class MyBlogMigrationsDbContextFactory : IDesignTimeDbContextFactory<MyBlogMigrationsDbContext>
    {
        public MyBlogMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<MyBlogMigrationsDbContext>()
                .UseMySql(configuration.GetConnectionString(AppSettings.EnableDb), new MySqlServerVersion(new Version(5, 7, 32)));

            return new MyBlogMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            return builder.Build();
        }
    }
}
