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
            if (ModelState.IsValid)
            {
                if (model.Password == model.ConfirmPassword)
                {
                    if (!model.IsEmailAddressExits())
                    {
                        model.SignUp();
                        return RedirectToAction("SignIn");
                    }
                    else
                    {
                        ModelState.AddModelError("Email", "This Email is already Registered");
                    }
                }
                else
                {
                    ModelState.AddModelError("ConfirmPassword", "Password And Confirm Password Do Not Same");
                }
            }
            return View(model);
        }

        public ActionResult SignIn()
        {
            SignInViewModel model = new SignInViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult SignIn(SignInViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.SignIn())
                {
                    FormsAuthentication.SetAuthCookie(UserSession.CurrentUser.Name, true);
                    return RedirectToAction("MyNews", "News", new { userID = UserSession.CurrentUser.ID });
                }
                else
                {
                    ModelState.AddModelError("Password", "Email or Password is not corruct!!!");
                }
            }
            return View(model);
        }

        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            UserSession.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}