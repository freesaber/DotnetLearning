﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Modularity;

namespace MyBlog.EntityFrameworkCore.DbMigrations
{
    [DependsOn(
        typeof(MyBlogEntityFrameworkCoreModule)
    )]
    public class MyBlogEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<MyBlogMigrationsDbContext>();
        }
    }
}
