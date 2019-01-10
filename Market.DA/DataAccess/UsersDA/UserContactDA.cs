using System.Linq;
using Market.DA;
using Market.Model;
using PostgreSQL;
namespace Market.DA
{
    public class UserContactDA : BaseDA<UserContact>
    {
        public UserContactDA(EntityContext db) : base(db)
        {

        }
        public new IQueryable<UserContact> GetAll() => base.GetAll();
        public UserContact GetById(int id) => base.GetOne(x => x.UserContactID == id);
        public new int Delete(int id) => base.Delete(id);
        public new UserContact Update(UserContact userContact, int id) => base.Update(userContact, id);
        public new UserContact Insert(UserContact userContact) => base.Insert(userContact);
        public new void SaveChanges() => base.SaveChanges();

    }
}