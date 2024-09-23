using BusinessObject;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class MemberDAO
    {
        public static List<Member> GetMembers()
        {
            var result = new List<Member>();

            try
            {
                using var context = new Assignment01DbContext();
                result = [.. context.Members];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public static Member FindMemberById(int memId)
        {
            var result = new Member();

            try
            {
                using var context = new Assignment01DbContext();
                result = context.Members.FirstOrDefault(member => member.MemberId == memId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public static void SaveMember(Member Member)
        {
            try
            {
                using var context = new Assignment01DbContext();
                context.Members.Add(Member);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateMember(Member Member)
        {
            try
            {
                using var context = new Assignment01DbContext();
                context.Entry<Member>(Member).State = EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeleteMember(int memId)
        {
            try
            {
                using var context = new Assignment01DbContext();
                var MemberExisted = FindMemberById(memId);
                if (MemberExisted != null)
                {
                    context.Members.Remove(MemberExisted);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
