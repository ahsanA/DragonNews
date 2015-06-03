using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DragonNews.Web.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult SignUp() 
        {
            return View();
        }

        public ActionResult SignIn()
        {
            return View();
        }

        public ActionResult SignOut()
        {
            return View();
        }
    }
}