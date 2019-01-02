using System.Linq;
using DAL;
using Model;
using PostgreSQL;
namespace DAL
{
    public class UserCartDA : BaseDA<UserCart>
    {
        public UserCartDA(EntityContext db) : base(db)
        {

        }
        public new IQueryable<UserCart> GetAll() => base.GetAll();
        public UserCart GetById(int id) => base.GetOne(x => x.UserCartID == id);
        public new int Delete(int id) => base.Delete(id);
        public new UserCart Update(UserCart userCart, int id) => base.Update(userCart, id);
        public new UserCart Insert(UserCart userCart) => base.Insert(userCart);
        public new void SaveChanges() => base.SaveChanges();

    }
}