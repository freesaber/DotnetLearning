﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Domain.Shared
{
    /// <summary>
    /// 分组
    /// </summary>
    public static class Grouping
    {
        /// <summary>
        /// 博客前台接口组
        /// </summary>
        public const string GroupName_v1 = "v1";

        /// <summary>
        /// 博客后台接口组
        /// </summary>
        public const string GroupName_v2 = "v2";

        /// <summary>
        /// 其他通用接口组
        /// </summary>
        public const string GroupName_v3 = "v3";

        /// <summary>
        /// JWT授权接口组
        /// </summary>
        public const string GroupName_v4 = "v4";
    }
}
