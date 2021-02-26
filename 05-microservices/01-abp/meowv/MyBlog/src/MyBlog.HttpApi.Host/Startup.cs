using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace MyBlog
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // abp应用启动模块
            services.AddApplication<MyBlogHttpApiHostingModule>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            // abp应用初始化
            app.InitializeApplication();
        }
    }
}
