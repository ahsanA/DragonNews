using DragonNews.Member;
using DragonNews.Web.App_Start;
using System.Web;
using System.Web.Mvc;

namespace DragonNews.Web
{
    public class Authorized : AuthorizeAttribute
    {
        private IMemberService _service;

        public Authorized()
        {
            _service = NinjectWebCommon.GetConcreteInstance<IMemberService>();
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            bool isAuthorized = false;

            if (!httpContext.Request.IsAuthenticated)
                isAuthorized = false;

            var user = UserSession.CurrentUser;


            if (user != null)
            {
                isAuthorized = true;
                return isAuthorized;
            }

            // user not selected
            HttpContext.Current.Response.BufferOutput = true;
            HttpContext.Current.Response.Redirect("/Home/Index", true);
            HttpContext.Current.Response.Close();
            return isAuthorized;
        }
    }
}