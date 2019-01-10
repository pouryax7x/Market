using System.Linq;
using Market.DA;
using Market.Model;
using PostgreSQL;
namespace Market.DA
{
    public class UserChatRecordDA : BaseDA<UserChatRecord>
    {
        public UserChatRecordDA(EntityContext db) : base(db)
        {

        }
        public new IQueryable<UserChatRecord> GetAll() => base.GetAll();
        public UserChatRecord GetById(int id) => base.GetOne(x => x.UserChatRecordID == id);
        public new int Delete(int id) => base.Delete(id);
        public new UserChatRecord Update(UserChatRecord userChatRecord, int id) => base.Update(userChatRecord, id);
        public new UserChatRecord Insert(UserChatRecord userChatRecord) => base.Insert(userChatRecord);
        public new void SaveChanges() => base.SaveChanges();

    }
}