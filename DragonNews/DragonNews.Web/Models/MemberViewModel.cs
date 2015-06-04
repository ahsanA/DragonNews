using AutoMapper;
using DragonNews.Member;
using DragonNews.Web.App_Start;
using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DragonNews.Web.Models
{
    public class MemberViewModel
    {
        public Guid ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
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

        public void SignUp()
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

        public bool IsEmailAddressExits()
        {
            return _service.IsMemberExits(Email);
        }        
    }
}