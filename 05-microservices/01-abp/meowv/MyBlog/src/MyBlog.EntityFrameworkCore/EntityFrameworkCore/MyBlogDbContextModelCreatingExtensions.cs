using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace MyBlog.EntityFrameworkCore
{
    public static class MyBlogDbContextModelCreatingExtensions
    {
        public static void ConfigureMyBlog(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(MyBlogConsts.DbTablePrefix + "YourEntities", MyBlogConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}