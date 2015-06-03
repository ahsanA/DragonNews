using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonNews.News
{
    class NewsRepository : INewsRepository
    {

        private DragonNewsEntities context;

        public NewsRepository(DragonNewsEntities context)
        {
            this.context = context;
        }

        public void AddNews(News news)
        {
            context.News.Add(news);
        }

        public void EditNews(News news)
        {
            context.Entry(news).State = EntityState.Modified;
        }

        public News DetailNews(Guid id)
        {
            return context.News.Find(id);
        }

        public void DeleteNews(Guid id)
        {
            News news = context.News.Find(id);
            context.News.Remove(news);
        }

        public IEnumerable<News> GetAllNews()
        {
            return context.News.ToList();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        #region Dispose
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion


        public IEnumerable<News> GetAllNewsAccordingToCategory(string category)
        {
            int categoryInInt = (int)(NewsCategory)Enum.Parse(typeof(NewsCategory), category);
            return context.News.Where(y=>y.Category == categoryInInt).OrderByDescending(x => x.CreateDate).Take(5);
        }
    }
}
