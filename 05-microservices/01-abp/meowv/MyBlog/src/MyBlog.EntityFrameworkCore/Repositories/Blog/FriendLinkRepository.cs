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
    public class FriendLinkRepository : EfCoreRepository<MyBlogDbContext, FriendLink, int>, IFriendLinkRepository
    {
        public FriendLinkRepository(IDbContextProvider<MyBlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
