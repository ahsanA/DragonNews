﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Syndication;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace RSSFeeder
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface INews
    {
        [OperationContract]
        [WebGet(UriTemplate = "rss?category={category}")]
        Rss20FeedFormatter Rss(string category);
    }

}