using DragonNews.DataAccess;
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

        public void AddNews(DragonNews.DataAccess.News news)
        {
            context.News.Add(news);
        }

        public void EditNews(DragonNews.DataAccess.News news)
        {
            context.Entry(news).State = EntityState.Modified;
        }

        public DragonNews.DataAccess.News DetailNews(Guid id)
        {
            return context.News.Find(id);
        }

        public void DeleteNews(Guid id)
        {
            DragonNews.DataAccess.News news = context.News.Find(id);
            context.News.Remove(news);
        }

        public IEnumerable<DragonNews.DataAccess.News> GetAllNews(int? pageSize, int? pageNumber, out int total)
        {            
            total =  context.News.Count();
            return context.News.OrderByDescending(x=>x.CreateDate).Skip((pageNumber.Value-1) * pageSize.Value).Take(pageSize.Value);
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


        public IEnumerable<DragonNews.DataAccess.News> GetAllNewsByUserID(Guid userID, int? pageSize, int? pageNumber, out int total)
        {
            total = context.News.Where(i => i.UserID == userID).Count();
            return context.News.Where(i => i.UserID == userID).OrderByDescending(x => x.CreateDate).Skip((pageNumber.Value - 1) * pageSize.Value).Take(pageSize.Value);
        }
    }
}
