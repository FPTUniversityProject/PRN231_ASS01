using BusinessObject;

namespace Repository.Interfaces
{
    public interface IMemberRepository
    {
        void SaveMember(Member member);
        Member GetMemberById(int memId);
        void DeleteMember(int memId);
        void UpdateMember(Member member);
        List<Member> GetMembers();
    }
}
