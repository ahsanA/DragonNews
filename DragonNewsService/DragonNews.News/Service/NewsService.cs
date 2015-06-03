using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonNews.News
{
    public class NewsService:INewsService
    {
        INewsRepository _newsRepository;

        public NewsService()
        {
            _newsRepository = new NewsRepository();
        }
        public void AddNews(News news)
        {
            _newsRepository.AddNews(news);
            _newsRepository.Save();
        }

        public void EditNews(News news)
        {
            _newsRepository.EditNews(news);
            _newsRepository.Save();
        }

        public News DetailNews(Guid id)
        {
            return _newsRepository.DetailNews(id);
        }

        public void DeleteNews(Guid id)
        {
            _newsRepository.DeleteNews(id);
            _newsRepository.Save();
        }

        public List<News> GetAllNews()
        {
            return _newsRepository.GetAllNews().ToList();
        }


        public IEnumerable<News> GetAllNewsAccordingToCategory(string category)
        {
            return _newsRepository.GetAllNewsAccordingToCategory(category).ToList();
        }
    }
}
