using Microsoft.EntityFrameworkCore;
using MyBlog.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace MyBlog.EntityFrameworkCore
{
    /// <summary>
    /// 数据访问上下文对象
    /// </summary>
    //[ConnectionStringName("MySql")]
    public class MyBlogDbContext : AbpDbContext<MyBlogDbContext>
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<FriendLink> FriendLinks { get; set; }

        public MyBlogDbContext(DbContextOptions<MyBlogDbContext> options) : base(options)
        {

        }

        /// <summary>
        /// 定义EF Core 实体映射
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 配置应用程序的实体
            modelBuilder.Configure();
        }
    }
}
