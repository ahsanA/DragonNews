using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonNews.Member
{
    public interface IMemberService
    {
        void AddMember(Member member);
        Member GetMember(Guid id);
        Member GetMember(string email);
        bool IsMemberExits(string email);
        bool IsPasswordMatched(string email, string realPass);
    }
}
