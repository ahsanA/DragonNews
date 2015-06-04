using AutoMapper;
using DragonNews.Member;
using DragonNews.Web.App_Start;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DragonNews.Web.Models
{
    public class MemberViewModel
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        IMemberService _service;

        [Inject]
        public MemberViewModel(IMemberService service)
        {
            _service = service;
        }

        public MemberViewModel()
        {
            _service = NinjectWebCommon.GetConcreteInstance<IMemberService>(); ;
        }

        public void Add()
        {
            try
            {
                var member = new Member.Member();
                Mapper.CreateMap<MemberViewModel, Member.Member>();
                member = Mapper.Map<MemberViewModel, Member.Member>(this);
                member.ID = Guid.NewGuid();
                member.CreateDate = DateTime.UtcNow;
                _service.AddMember(member);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SignIn(string email, string givenPass)
        {
            var realUser = _service.ValidMember(email, givenPass);
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