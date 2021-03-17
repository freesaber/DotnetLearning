using Localization.Resources.AbpUi;
using Volo.Abp.Autofac;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
namespace MyBlog
{
    /// <summary>
    /// 职责主要是编写Controller，所有的API都写在这里，同时它要依赖于Application模块
    /// </summary>
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpIdentityHttpApiModule),
        typeof(MyBlogApplicationModule)
    )]
    public class MyBlogHttpApiModule : AbpModule
    {

    }
}
