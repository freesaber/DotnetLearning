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
    public class PostRepository : EfCoreRepository<MyBlogDbContext, Post, int>, IPostRepository
    {
        public PostRepository(IDbContextProvider<MyBlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
