using DragonNews.News;
using Ninject;
using Ninject.Extensions.Wcf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DragonNewsService.RSS
{
    public class NinjectFileLessServiceHostFactory : NinjectServiceHostFactory
    {
        public NinjectFileLessServiceHostFactory()
        {
            var kernel = new StandardKernel(
                new ServiceModule(),
                new NewsModule()
            );
            kernel.Bind<ServiceHost>().To<NinjectServiceHost>();
            SetKernel(kernel);
        }
    }
}
