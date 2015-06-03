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
        public ActionResult Index()
        {
            var newsModel = new NewsViewModel();
            return View(newsModel.GetAllNews());
        }
    }
}