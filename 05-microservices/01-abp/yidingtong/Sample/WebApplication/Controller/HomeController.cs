using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace WebApplication.Controller
{
    public class HomeController : AbpController
    {
        public IActionResult Index()
        {
            return Content("Hello World");
        }
    }
}
