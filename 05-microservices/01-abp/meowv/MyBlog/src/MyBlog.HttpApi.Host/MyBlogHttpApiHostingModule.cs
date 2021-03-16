using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using MyBlog.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MyBlog
{
    /// <summary>
    /// 相当于一个web项目
    /// </summary>
    [DependsOn(
       typeof(AbpAspNetCoreMvcModule),
       typeof(AbpAutofacModule),
       typeof(MyBlogHttpApiModule),
       typeof(MyBlogSwaggerModule)
    )]
    public class MyBlogHttpApiHostingModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddSwagger();

            base.ConfigureServices(context);
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();
            var env = context.GetEnvironment();

            app.UseSwagger().UseSwaggerUI();

            // 环境变量，开发环境
            if (env.IsDevelopment())
            {
                // 生成异常页面
                app.UseDeveloperExceptionPage();
            }

            // 路由
            app.UseRouting();

            // 路由映射
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
