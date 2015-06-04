using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonNews.Member
{
    class MemberService : IMemberService
    {
        private PasswordManager _passwordManager;
        private IMemberRepository _memberRepository;

        public MemberService(IMemberRepository memberRepository)
        {
            _passwordManager = new PasswordManager();
            memberRepository = _memberRepository;
        }

        public void AddMember(Member member)
        {
            member.Salt = _passwordManager.GenerateSalt();
            member.Password = _passwordManager.SetPassword(member.Password, member.Salt);            
            _memberRepository.AddMember(member);
        }

        public Member GetMember(Guid id)
        {
            return _memberRepository.GetMember(id);
        }

        public Member GetMember(string email)
        {
            return _memberRepository.GetMember(email);
        }

        public bool IsMemberExits(string email)
        {
            return _memberRepository.IsMemberExits(email);
        }

        Member ValidMember(string email, string givenPass)
        {
            var user = _memberRepository.GetMember(email);
            var realPass = _passwordManager.GetPassword(user.Password, user.Salt);
            if (givenPass == realPass)
                return user;
            else
                return null;
        }
    }
}
