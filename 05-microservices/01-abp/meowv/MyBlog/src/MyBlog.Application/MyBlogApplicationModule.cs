using Volo.Abp.AutoMapper;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;

namespace MyBlog
{
    /// <summary>
    /// 应用模块，这里编写接口和接口实现
    /// </summary>
    [DependsOn(
        typeof(AbpIdentityApplicationModule)
    )]
    public class MyBlogApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {

        }
    }
}
