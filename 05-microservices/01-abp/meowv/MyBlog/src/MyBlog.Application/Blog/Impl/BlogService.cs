﻿using MyBlog.Application.Blog.Dto;
using MyBlog.Domain.Blog;
using MyBlog.Domain.Blog.Repositories;
using MyBlog.ToolKits.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Application.Blog.Impl
{
    public class BlogService : MyBlogApplicationServiceBase, IBlogService
    {
        private readonly IPostRepository _postRepository;

        public BlogService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<ServiceResult<string>> InsertPostAsync(PostDto dto)
        {
            var result = new ServiceResult<string>();

            var entity = new Post
            {
                Title = dto.Title,
                Author = dto.Author,
                Url = dto.Url,
                Html = dto.Html,
                Markdown = dto.Markdown,
                CategoryId = 1,
                CreationTime = DateTime.Now
            };

            var post = await _postRepository.InsertAsync(entity);
            if (post == null)
            {
                result.IsFailed("添加失败");
                return result;
            }

            result.IsSuccess("添加成功");
            return result;
        }
        public async Task<ServiceResult> DeletePostAsync(int id)
        {
            var result = new ServiceResult();

            await _postRepository.DeleteAsync(id);

            return result;
        }

        public async Task<ServiceResult<string>> UpdatePostAsync(int id, PostDto dto)
        {
            var result = new ServiceResult<string>();

            var post = await _postRepository.GetAsync(id);
            if (post == null)
            {
                result.IsFailed("文章不存在");
                return result;
            }

            post.Title = dto.Title;
            post.Author = dto.Author;
            post.Url = dto.Url;
            post.Html = dto.Html;
            post.Markdown = dto.Markdown;
            //post.CategoryId = dto.CategoryId;
            //post.CreationTime = dto.CreationTime;

            await _postRepository.UpdateAsync(post);


            result.IsSuccess("更新成功");
            return result;
        }

        public async Task<ServiceResult<PostDto>> GetPostAsync(int id)
        {
            var result = new ServiceResult<PostDto>();

            try
            {
                var post = await _postRepository.GetAsync(id);
                if (post == null)
                {
                    result.IsFailed("文章不存在");
                    return result;
                }

                var dto = new PostDto
                {
                    Title = post.Title,
                    Author = post.Author,
                    Url = post.Url,
                    Html = post.Html,
                    Markdown = post.Markdown,
                    //CategoryId = post.CategoryId,
                    //CreationTime = post.CreationTime
                };

                result.IsSuccess(dto);
            }
            catch (Exception ex)
            {
                result.IsFailed(ex.ToString());
            }

            return result;
        }
    }
}
