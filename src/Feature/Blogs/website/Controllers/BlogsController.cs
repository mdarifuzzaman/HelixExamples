using Sitecore.Data;
using Sitecore.Data.Managers;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicCompany.Feature.Blogs.Controllers
{
    public class BlogsController : Controller
    {
        // GET: Blogs
        public ActionResult List()
        {
            var blogRoot = RenderingContext.Current.ContextItem;
            var blogs = ItemManager.GetChildren(blogRoot).ToList().Where(e=> e.Name != "Page Components");
            return View(blogs);
        }
    }
}