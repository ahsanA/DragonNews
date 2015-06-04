﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonNews.News
{
    public interface INewsService
    {
        void AddNews(DragonNews.DataAccess.News news);
        void EditNews(DragonNews.DataAccess.News news);
        DragonNews.DataAccess.News DetailNews(Guid id);
        void DeleteNews(Guid id);
        List<DragonNews.DataAccess.News> GetAllNews(int? pageSize, int? pageNumber, out int total);
        List<DragonNews.DataAccess.News> GetAllNewsByUserID(Guid userID, int? pageSize, int? pageNumber, out int total);
    }
}
