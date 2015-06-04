using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonNews.Member
{
    class MemberService : IMemberService
    {
        private PasswordManager passwordManager;
        private IMemberRepository _memberRepository;

        public MemberService(IMemberRepository memberRepository)
        {
            passwordManager = new PasswordManager();
            memberRepository = _memberRepository;
        }

        public void AddMember(Member member)
        {
            member.Salt = passwordManager.GenerateSalt();
            member.Password = passwordManager.SetPassword(member.Password, member.Salt);
            member.ID = Guid.NewGuid();
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
    }
}
