using DragonNews.News;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using DragonNews.Web.App_Start;

namespace DragonNews.Web.Models
{
    public class NewsViewModel
    {
        public int Category { get; set; }
        public string Details { get; set; }
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid UserID { get; set; }

        INewsService _newsService;

        [Inject]
        public NewsViewModel(INewsService newsService)
        {
            _newsService = newsService;
        }

        public NewsViewModel()
        {
            _newsService = NinjectWebCommon.GetConcreteInstance<INewsService>(); ;
        }

        public void Add()
        {
            try
            {
                var news = new News.News();
                Mapper.CreateMap<NewsViewModel, News.News>();
                news = Mapper.Map<NewsViewModel, News.News>(this);
                news.CreateDate = DateTime.UtcNow;
                news.ID = Guid.NewGuid();
                news.UserID = new Guid("3F2504E0-4F89-41D3-9A0C-0305E82C3301");
                _newsService.AddNews(news);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public NewsViewModel Detail()
        {
            var news = _newsService.DetailNews(Id);

            var newsModel = new NewsViewModel();
            Mapper.CreateMap<News.News, NewsViewModel>();
            newsModel = Mapper.Map<News.News, NewsViewModel>(news);

            return newsModel;
        }


        public void Edit()
        {
            try
            {
                var news = new News.News();
                Mapper.CreateMap<NewsViewModel, News.News>();
                news = Mapper.Map<NewsViewModel, News.News>(this);
                _newsService.EditNews(news);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete()
        {
            _newsService.DeleteNews(Id);
        }

        public List<NewsViewModel> GetAllNews()
        {
            var allNews =  _newsService.GetAllNews();
            List<NewsViewModel> allNewsModel = new List<NewsViewModel>();
            Mapper.CreateMap<News.News, NewsViewModel>();
            foreach (var news in allNews)
            {
                var newsModel = new NewsViewModel();
                newsModel = Mapper.Map<News.News, NewsViewModel>(news);
                allNewsModel.Add(newsModel);
            }
            return allNewsModel;
        }

    }
}