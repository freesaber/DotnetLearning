﻿using Microsoft.AspNetCore.Mvc;
using MyBlog.Application.Blog;
using MyBlog.Application.Blog.Dto;
using MyBlog.Domain.Shared;
using MyBlog.ToolKits.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace MyBlog.HttpApi.Controllers
{
    [ApiExplorerSettings(GroupName = Grouping.GroupName_v1)]
    [ApiController]
    [Route("[controller]")]
    public class BlogController : AbpController
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        /// <summary>
        /// 添加博客
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ServiceResult<string>> InsertPostAsync([FromBody] PostDto dto)
        {
            return await _blogService.InsertPostAsync(dto);
        }

        /// <summary>
        /// 删除博客
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<ServiceResult> DeletePostAsync([Required] int id)
        {
            return await _blogService.DeletePostAsync(id);
        }

        /// <summary>
        /// 更新博客
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<ServiceResult<string>> UpdatePostAsync([Required] int id, [FromBody] PostDto dto)
        {
            return await _blogService.UpdatePostAsync(id, dto);
        }

        /// <summary>
        /// 查询博客
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ServiceResult<PostDto>> GetPostAsync([Required] int id)
        {
            return await _blogService.GetPostAsync(id);
        }
    }
}
