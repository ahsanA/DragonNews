using DragonNews.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonNewsModule.Member
{
    class MemberReposiotry : IMemberRepository
    {
        private DragonNewsEntities context;

        public MemberReposiotry(DragonNewsEntities context)
        {
            this.context = context;
        }

        public void AddMember(DragonNews.DataAccess.Member member)
        {
            context.Members.Add(member);
        }
        public DragonNews.DataAccess.Member GetMember(Guid id)
        {
            return context.Members.Find(id);
        }
        public DragonNews.DataAccess.Member GetMember(string email)
        {
            return context.Members.Where(e => e.Email == email).SingleOrDefault();
        }
        public bool IsMemberExits(string email)
        {
            return context.Members.Where(e => e.Email == email).Count() > 0;
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
