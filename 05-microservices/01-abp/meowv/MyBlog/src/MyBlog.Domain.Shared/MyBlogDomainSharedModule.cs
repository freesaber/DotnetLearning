using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace MyBlog.Domain.Shared
{
    /// <summary>
    /// 项目用到的枚举、公共常量等
    /// </summary>
    [DependsOn(
        typeof(AbpIdentityDomainSharedModule)
    )]
    public class MyBlogDomainSharedModule : AbpModule
    {
    }
}
