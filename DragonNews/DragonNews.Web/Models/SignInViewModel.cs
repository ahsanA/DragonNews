using DragonNews.Member;
using DragonNews.Web.App_Start;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DragonNews.Web.Models
{
    public class SignInViewModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        IMemberService _service;

        public SignInViewModel()
        {
            _service = NinjectWebCommon.GetConcreteInstance<IMemberService>(); ;
        }

        public bool SignIn()
        {
            var realUser = _service.ValidMember(Email, Password);
            if (realUser != null)
            {
                var sessionUser = new SessionUser()
                {
                    Email = realUser.Email,
                    Name = realUser.Name,
                    ID = realUser.ID,
                };

                UserSession.User = sessionUser;
                UserSession.AddToCookie(sessionUser);

                return true;
            }
            else
                return false;
        }
    }
}