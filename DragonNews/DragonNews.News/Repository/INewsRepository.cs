using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonNews.News
{
    public interface INewsRepository : IDisposable
    {
        void AddNews(News news);
        void EditNews(News news);
        News DetailNews(Guid id);
        void DeleteNews(Guid id);
        IEnumerable<News> GetAllNews();
        void Save();
    }
}
