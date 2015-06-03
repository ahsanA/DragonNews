using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonNews.News
{
    public class NewsModule: NinjectModule
    {
        public override void Load()
        {
            Bind<INewsService>().To<NewsService>();
            Bind<INewsRepository>().To<NewsRepository>();
        }
    }
}
