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
    [Authorized]
    public class NewsController : Controller
    {
        INewsService _newsService;

        [Inject]
         public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }

        // GET: News
        public ActionResult MyNews(Guid userID, int? pageSize = 10, int? pageNumber = 1)
        {
            var newsModel = new NewsViewModel();
            int total;
            var data = newsModel.GetAllNewsByUserID(userID, pageSize, pageNumber, out total);
            ViewData["PageCount"] = Math.Ceiling((double)total / pageSize.Value);
            ViewData["PageSize"] = pageSize.Value;
            return View(data);
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
            return RedirectToAction("MyNews", "News", new { userID = UserSession.CurrentUser.ID });
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
            return RedirectToAction("MyNews", "News", new { userID = UserSession.CurrentUser.ID });
        }

        public ActionResult Delete(Guid id)
        {
            var newsModel = new NewsViewModel();
            newsModel.Id = id;
            newsModel.Delete();
            return RedirectToAction("MyNews", "News", new { userID = UserSession.CurrentUser.ID });
        }

    }
}