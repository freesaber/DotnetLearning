using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace HelloAbp
{
    // ABP服务,自动注册到abp服务列表中
    public class HelloWorldService : ITransientDependency
    {
        public void Run()
        {
            Console.Write("Hello World");
        }
    }
}
