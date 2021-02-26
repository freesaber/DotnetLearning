using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace MyBlog.EntityFrameworkCore
{
    [DependsOn(
        typeof(MyBlogEntityFrameworkCoreModule)
        )]
    public class MyBlogEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<MyBlogMigrationsDbContext>();
        }
    }
}
