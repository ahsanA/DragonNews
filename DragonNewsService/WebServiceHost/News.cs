using DragonNews.News;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;

namespace WebService
{
    public class News:INews
    {
        INewsService _service;

        [Inject]
        public News()
        {
            _service = new NewsService();
        }

        public Rss20FeedFormatter Rss(string category)
        {
            SyndicationFeed feed = new SyndicationFeed("Dragon News Feed", "This feed gives you news about latest 5 news according to category", new Uri("http://localhost/news/rss?category=" + category));
            feed.Authors.Add(new SyndicationPerson("ahsan1037@gmail.com"));
            feed.Categories.Add(new SyndicationCategory(category));
            feed.Description = new TextSyndicationContent("Get Letest Dragon News Using This Feed");

            var allNews = _service.GetAllNewsAccordingToCategory(category);
            List<SyndicationItem> items = new List<SyndicationItem>();
            foreach (var news in allNews)
            {
                SyndicationItem item = new SyndicationItem(
                                                    category,
                                                  news.Details,
                                                    new Uri("http://localhost:47201/News/Details/" + news.ID),
                                                    news.ID.ToString(),
                                                    news.CreateDate);
                items.Add(item);
            }
            feed.Items = items;
            return new Rss20FeedFormatter(feed);
        }
    }
}
