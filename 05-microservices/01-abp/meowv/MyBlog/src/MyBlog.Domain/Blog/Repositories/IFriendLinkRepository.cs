using MyBlog.Domain.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace MyBlog.Domain.Blog.Repositories
{
    public interface IFriendLinkRepository : IRepository<FriendLink, int>
    {
    }
}
