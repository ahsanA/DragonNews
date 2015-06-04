using DragonNews.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace DragonNews.Web.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult SignUp() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(MemberViewModel model)
        {
            return View();
        }

        public ActionResult SignIn()
        {
            return View(new { email="", pass=""});
        }

        [HttpPost]
        public ActionResult SignIn(string email, string pass)
        {
            MemberViewModel model = new MemberViewModel();

            if (model.SignIn(email, pass))
            {
                FormsAuthentication.SetAuthCookie(UserSession.CurrentUser.Name,true);
                return RedirectToAction("MyNews", "News", new { userID = UserSession.CurrentUser.ID });
            }

            return View(new { email = email, pass = pass });
        }

        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            UserSession.Clear();
            return RedirectToAction("UserLogin", "Annonymous");
            return View();
        }
    }
}