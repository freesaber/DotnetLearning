using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Modularity;

namespace HelloAbp
{
    // ABP模块
    public class HelloAbpModule : AbpModule
    {
        // 手动配置注册的服务
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);

            //context.Services.AddTransient<HelloWorldService>();
            //Configure<XXXOption>(opt => { });
        }
    }
}
