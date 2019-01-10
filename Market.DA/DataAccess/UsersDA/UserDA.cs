using System.Linq;
using Market.DA;
using Market.Model;
using PostgreSQL;
namespace Market.DA
{
    public class UserDA : BaseDA<User>
    {
        public UserDA(EntityContext db) : base(db)
        {

        }
        public new IQueryable<User> GetAll() => base.GetAll();
        public User GetById(int id) => base.GetOne(x => x.UserID == id);
        public new int Delete(int id) => base.Delete(id);
        public new User Update(User user, int id) => base.Update(user, id);
        public new User Insert(User user) => base.Insert(user);
        public new void SaveChanges() => base.SaveChanges();

    }
}