using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonNews.Member
{
    class MemberReposiotry : IMemberRepository
    {
        private DragonNewsEntities context;

        public MemberReposiotry(DragonNewsEntities context)
        {
            this.context = context;
        }

        public void AddMember(Member member)
        {
            context.Members.Add(member);
        }
        public Member GetMember(Guid id)
        {
            return context.Members.Find(id);
        }
        public Member GetMember(string email)
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
