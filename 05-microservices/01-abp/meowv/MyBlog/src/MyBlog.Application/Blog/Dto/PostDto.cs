﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Application.Blog.Dto
{
    public class PostDto
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Url { get; set; }

        public string Markdown { get; set; }

        public string Html { get; set; }


        //public CategoryAdminDto Category { get; set; }

        //public List<TagAdminDto> Tags { get; set; }

        //public string CreatedAt { get; set; }
    }
}
