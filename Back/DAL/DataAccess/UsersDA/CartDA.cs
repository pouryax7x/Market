using System.Linq;
using DAL;
using Model;
using PostgreSQL;
namespace DAL
{
    public class CartDA : BaseDA<Cart>
    {
        public CartDA(EntityContext db) : base(db)
        {

        }
        public new IQueryable<Cart> GetAll() => base.GetAll();
        public Cart GetById(int id) => base.GetOne(x => x.CartID == id);
        public new int Delete(int id) => base.Delete(id);
        public new Cart Update(Cart cart, int id) => base.Update(cart, id);
        public new Cart Insert(Cart cart) => base.Insert(cart);
        public new void SaveChanges() => base.SaveChanges();

    }
}
//beres