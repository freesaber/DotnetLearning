using Localization.Resources.AbpUi;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
namespace MyBlog
{
    [DependsOn(
        typeof(AbpIdentityHttpApiModule),
        typeof(MyBlogApplicationModule)
    )]
    public class MyBlogHttpApiModule : AbpModule
    {

    }
}
