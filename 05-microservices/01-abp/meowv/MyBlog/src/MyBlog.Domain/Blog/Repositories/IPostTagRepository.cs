﻿using MyBlog.Domain.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace MyBlog.Domain.Blog.Repositories
{
    public interface IPostTagRepository : IRepository<PostTag, int>
    {
        /// <summary>
        /// 批量插入
        /// </summary>
        /// <param name="postTags"></param>
        /// <returns></returns>
        Task BulkInsertAsync(IEnumerable<PostTag> postTags);
    }
}
