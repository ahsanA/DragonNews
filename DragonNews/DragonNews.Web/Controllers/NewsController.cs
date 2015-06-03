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
    public class NewsController : Controller
    {
        INewsService _newsService;

        [Inject]
         public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }

        // GET: News
        public ActionResult MyNews(Guid userID)
        {
            return View();
        }

        public ActionResult Create()
        {
            var newsModel = new NewsViewModel();
            return View(newsModel);
        }

        [HttpPost]
        public ActionResult Create(NewsViewModel model)
        {
            model.Add();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Details(Guid id)
        {
            var newsModel = new NewsViewModel();
            newsModel.Id = id;
            return View(newsModel.Detail());
        }

        public ActionResult Edit(Guid id)
        {
            var newsModel = new NewsViewModel();
            newsModel.Id = id;
            return View(newsModel.Detail());
        }

        [HttpPost]
        public ActionResult Edit(NewsViewModel model)
        {
            model.Edit();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Delete(Guid id)
        {
            var newsModel = new NewsViewModel();
            newsModel.Id = id;
            newsModel.Delete();
            return RedirectToAction("Index", "Home");
        }

    }
}