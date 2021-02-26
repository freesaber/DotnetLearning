using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace MyBlog.Domain
{
    /// <summary>
    /// 实体领域模型
    /// </summary>
    [DependsOn(typeof(AbpIdentityDomainModule))]
    public class MyBlogDomainModule : AbpModule
    {
    }
}
