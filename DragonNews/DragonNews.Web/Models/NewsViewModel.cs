using DragonNews.News;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using DragonNews.Web.App_Start;
using System.ComponentModel.DataAnnotations;

namespace DragonNews.Web.Models
{
    public class NewsViewModel
    {
        [Required]
        public int Category { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public string Title { get; set; }
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
                var news = new DragonNews.DataAccess.News();
                Mapper.CreateMap<NewsViewModel, DragonNews.DataAccess.News>();
                news = Mapper.Map<NewsViewModel, DragonNews.DataAccess.News>(this);
                news.CreateDate = DateTime.UtcNow;
                news.ID = Guid.NewGuid();
                news.UserID = UserSession.CurrentUser.ID;
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
            Mapper.CreateMap<DragonNews.DataAccess.News, NewsViewModel>();
            newsModel = Mapper.Map<DragonNews.DataAccess.News, NewsViewModel>(news);

            return newsModel;
        }


        public void Edit()
        {
            try
            {
                var news = new DragonNews.DataAccess.News();
                Mapper.CreateMap<NewsViewModel, DragonNews.DataAccess.News>();
                news = Mapper.Map<NewsViewModel, DragonNews.DataAccess.News>(this);
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

        public List<NewsViewModel> GetAllNews(int? pageSize, int? pageNumber,out int total)
        {
            var allNews =  _newsService.GetAllNews(pageSize,pageNumber,out total);
            List<NewsViewModel> allNewsModel = new List<NewsViewModel>();
            Mapper.CreateMap<DragonNews.DataAccess.News, NewsViewModel>();
            foreach (var news in allNews)
            {
                var newsModel = new NewsViewModel();
                newsModel = Mapper.Map<DragonNews.DataAccess.News, NewsViewModel>(news);
                allNewsModel.Add(newsModel);
            }
            return allNewsModel;
        }


        internal List<NewsViewModel> GetAllNewsByUserID(Guid userID,int? pageSize, int? pageNumber,out int total)
        {
            var allNews = _newsService.GetAllNewsByUserID(userID, pageSize, pageNumber, out total);
            List<NewsViewModel> allNewsModel = new List<NewsViewModel>();
            Mapper.CreateMap<DragonNews.DataAccess.News, NewsViewModel>();
            foreach (var news in allNews)
            {
                var newsModel = new NewsViewModel();
                newsModel = Mapper.Map<DragonNews.DataAccess.News, NewsViewModel>(news);
                allNewsModel.Add(newsModel);
            }
            return allNewsModel;
        }
    }
}