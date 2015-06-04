using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonNews.News
{
    class NewsService:INewsService
    {
        INewsRepository _newsRepository;

        [Inject]
        public NewsService(INewsRepository newsRepository)
        {
            _newsRepository = newsRepository;
        }
        public void AddNews(DragonNews.DataAccess.News news)
        {
            _newsRepository.AddNews(news);
            _newsRepository.Save();
        }

        public void EditNews(DragonNews.DataAccess.News news)
        {
            _newsRepository.EditNews(news);
            _newsRepository.Save();
        }

        public DragonNews.DataAccess.News DetailNews(Guid id)
        {
            return _newsRepository.DetailNews(id);
        }

        public void DeleteNews(Guid id)
        {
            _newsRepository.DeleteNews(id);
            _newsRepository.Save();
        }

        public List<DragonNews.DataAccess.News> GetAllNews(int? pageSize, int? pageNumber, out int total)
        {
            return _newsRepository.GetAllNews(pageSize, pageNumber,out total).ToList();
        }


        public List<DragonNews.DataAccess.News> GetAllNewsByUserID(Guid userID, int? pageSize, int? pageNumber, out int total)
        {
            return _newsRepository.GetAllNewsByUserID(userID, pageSize, pageNumber, out total).ToList();
        }
    }
}
