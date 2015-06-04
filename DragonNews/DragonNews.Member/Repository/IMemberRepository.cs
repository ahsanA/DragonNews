using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragonNews.DataAccess;

namespace DragonNewsModule.Member
{
    public interface IMemberRepository
    {
        void AddMember(DragonNews.DataAccess.Member member);
        DragonNews.DataAccess.Member GetMember(Guid id);
        DragonNews.DataAccess.Member GetMember(string email);
        bool IsMemberExits(string email);
        void Save();
    }
}
