using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Syndication;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace WebService
{
    [ServiceContract]
    public interface INews
    {
        [OperationContract]
        [WebGet(UriTemplate = "rss?category={category}")]
        Rss20FeedFormatter Rss(string category);
    }
}
