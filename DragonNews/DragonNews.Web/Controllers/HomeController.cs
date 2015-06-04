using DragonNews.News;
using DragonNews.Web.Models;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DragonNews.Web.Controllers
{
    public class HomeController : Controller
    {
         INewsService _newsService;

        [Inject]
         public HomeController(INewsService newsService)
        {
            _newsService = newsService;
        }
        // GET: Home
        public ActionResult Index(int? pageSize=10, int? pageNumber=1)
        {
           
            var newsModel = new NewsViewModel();
            int total;
            var data = newsModel.GetAllNews(pageSize, pageNumber,out total);
            ViewData["PageCount"] = Math.Ceiling((double)total / pageSize.Value);
            ViewData["PageSize"] = pageSize.Value;
            return View(data);
        }

        public ActionResult Details(Guid id)
        {
            var newsModel = new NewsViewModel();
            newsModel.Id = id;
            return View(newsModel.Detail());
        }
    }
}