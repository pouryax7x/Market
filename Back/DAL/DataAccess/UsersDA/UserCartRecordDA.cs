using System.Linq;
using DAL;
using Model;
using PostgreSQL;
namespace DAL
{
    public class UserCartRecordDA : BaseDA<UserCartRecord>
    {
        public UserCartRecordDA(EntityContext db) : base(db)
        {

        }
        public new IQueryable<UserCartRecord> GetAll() => base.GetAll();
        public UserCartRecord GetById(int id) => base.GetOne(x => x.UserCartRecordID == id);
        public new int Delete(int id) => base.Delete(id);
        public new UserCartRecord Update(UserCartRecord userCartRecord, int id) => base.Update(userCartRecord, id);
        public new UserCartRecord Insert(UserCartRecord userCartRecord) => base.Insert(userCartRecord);
        public new void SaveChanges() => base.SaveChanges();

    }
}