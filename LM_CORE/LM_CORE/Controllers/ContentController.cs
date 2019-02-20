using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LM_CORE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace LM_CORE.Controllers
{
    public class ContentController : Controller
    {
        private readonly Content content;
        public ContentController(IOptions<Content> option) {
            content = option.Value;
        }
        public IActionResult Index()
        {
            var contents = new List<Content>();
            for (int i = 0; i < 11; i++)
            {
                contents.Add(new Content
                {
                    id = i,
                    title = $"{i}的标题",
                    content = $"{i}的内容",
                    status=1,
                    add_time=DateTime.Now.AddDays(-i)
                });
            }
            contents.Add(content);
            ContentViewMode contentViewMode = new ContentViewMode();
            contentViewMode.Contents = contents;
            return View(contentViewMode);
        }
    }
}