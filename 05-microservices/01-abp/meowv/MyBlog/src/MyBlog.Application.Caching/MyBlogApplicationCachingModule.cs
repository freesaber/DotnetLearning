using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Caching;
using Volo.Abp.Modularity;

namespace MyBlog.Application.Caching
{
    /// <summary>
    /// 缓存模块
    /// </summary>
    [DependsOn(
        typeof(AbpCachingModule)
    )]
    public class MyBlogApplicationCachingModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);
        }
    }
}
