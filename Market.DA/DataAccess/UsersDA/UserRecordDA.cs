using System.Linq;
using Market.DA;
using Market.Model;
using PostgreSQL;
namespace Market.DA
{
    public class UserRecordDA : BaseDA<UserRecord>
    {
        public UserRecordDA(EntityContext db) : base(db)
        {

        }
        public new IQueryable<UserRecord> GetAll() => base.GetAll();
        public UserRecord GetById(int id) => base.GetOne(x => x.UserRecordID == id);
        public new int Delete(int id) => base.Delete(id);
        public new UserRecord Update(UserRecord userRecord, int id) => base.Update(userRecord, id);
        public new UserRecord Insert(UserRecord userRecord) => base.Insert(userRecord);
        public new void SaveChanges() => base.SaveChanges();

    }
}