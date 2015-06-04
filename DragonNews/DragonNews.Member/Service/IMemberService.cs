using DragonNews.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonNewsModule.Member
{
    public interface IMemberService
    {
        void AddMember(DragonNews.DataAccess.Member member);
        DragonNews.DataAccess.Member GetMember(Guid id);
        DragonNews.DataAccess.Member GetMember(string email);
        bool IsMemberExits(string email);
        DragonNews.DataAccess.Member ValidMember(string email, string realPass);
    }
}
