using System;
using Volo.Abp;

namespace HelloAbp
{
    class Program
    {
        static void Main(string[] args)
        {
            // ABP应用
            var application = AbpApplicationFactory.Create<HelloAbpModule>();//根模块
            application.Initialize();

            var service = (HelloWorldService)application.ServiceProvider.GetService(typeof(HelloWorldService));
            service.Run();
        }
    }
}
