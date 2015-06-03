using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonNewsService.RSS
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<INews>().To<News>();
        }
    }
}
