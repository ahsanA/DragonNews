using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DragonNews.Web
{
    public class UserSession
    {

        public static SessionUser User
        {
            get
            {
                return HttpContext.Current.Session["UserSession"] as SessionUser;
            }
            set
            {
                HttpContext.Current.Session["UserSession"] = value;
            }
        }

        public static SessionUser CurrentUser
        {
            get
            {
                var currentUser = User;

                if (currentUser == null)
                {
                    currentUser = new SessionUser();
                    var httpCookie = HttpContext.Current.Response.Cookies["SessionUser"];
                    try
                    {
                        currentUser.ID = new Guid(httpCookie["ID"]);
                        currentUser.Name = httpCookie["Name"];
                        currentUser.Email = httpCookie["Email"];
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
                return currentUser;
            }
        }

        public static void Clear()
        {
            HttpContext.Current.Session["UserSession"] = null;
            var httpCookie = HttpContext.Current.Response.Cookies["SessionUser"];
            if (httpCookie != null)
            {
                httpCookie.Expires = DateTime.Now.AddDays(-1);
                HttpContext.Current.Response.Cookies.Add(httpCookie);
            }
        }

        public static void AddToCookie(SessionUser sessionUser)
        {
            var httpCookie = HttpContext.Current.Response.Cookies["SessionUser"];
            if (httpCookie != null)
            {
                httpCookie["ID"] = sessionUser.ID.ToString();
                httpCookie["Name"] = sessionUser.Name;
                httpCookie["Email"] = sessionUser.Email;
                httpCookie.Expires = DateTime.Now.AddDays(1);
            }

        }
    }

    public class SessionUser
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

}