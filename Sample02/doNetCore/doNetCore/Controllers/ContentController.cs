using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using doNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace doNetCore.Controllers
{
    public class ContentController : Controller
    {
        /// <summary>
        /// Content实体
        /// </summary>
        private readonly Content contents;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="option"></param>
        public ContentController(IOptions<Content> option)
        {
            contents = option.Value;
        }

        /// <summary>
        /// 首页视图
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            //var contents = new List<Content>();
            //for (int i = 1; i < 11; i++)
            //{
            //    contents.Add(new Content { Id = i, title = $"{i}的标题", content = $"{i}的内容", status = 1, add_time = DateTime.Now.AddDays(-i) });
            //}
            //return View(new ContentViewModel { Contents = contents });
            return View(new ContentViewModel { Contents = new List<Content> { contents } });
            //return View();
        }
    }
}