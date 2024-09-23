using BusinessObject;
using DataAccess;
using Repository.Interfaces;

namespace Repository.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        public void DeleteMember(int memId)
           => MemberDAO.DeleteMember(memId);

        public Member GetMemberById(int memId)
            => MemberDAO.FindMemberById(memId);

        public List<Member> GetMembers()
            => MemberDAO.GetMembers();

        public void SaveMember(Member member)
            => MemberDAO.SaveMember(member);

        public void UpdateMember(Member member)
            => MemberDAO.UpdateMember(member);
    }
}
