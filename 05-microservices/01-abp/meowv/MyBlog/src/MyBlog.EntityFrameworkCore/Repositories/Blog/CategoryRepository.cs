using MyBlog.Domain.Blog;
using MyBlog.Domain.Blog.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace MyBlog.EntityFrameworkCore.Repositories.Blog
{
    public class CategoryRepository : EfCoreRepository<MyBlogDbContext, Category, int>, ICategoryRepository
    {
        public CategoryRepository(IDbContextProvider<MyBlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
