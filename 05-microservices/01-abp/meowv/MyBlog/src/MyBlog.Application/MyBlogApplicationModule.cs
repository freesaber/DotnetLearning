using MyBlog.Domain;
using MyBlog.EntityFrameworkCore;
using Volo.Abp.AutoMapper;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;

namespace MyBlog
{
    /// <summary>
    /// 为我们的应用服务层，在这里编写服务的接口以及对应的实现
    /// </summary>
    [DependsOn(
        typeof(AbpIdentityApplicationModule),
        typeof(MyBlogDomainModule),
        typeof(MyBlogEntityFrameworkCoreModule)
    )]
    public class MyBlogApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {

        }
    }
}
