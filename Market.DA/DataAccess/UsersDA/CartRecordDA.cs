using System.Linq;
using Market.DA;
using Market.Model;
using PostgreSQL;
namespace Market.DA
{
    public class CartRecordDA : BaseDA<CartRecord>
    {
        public CartRecordDA(EntityContext db) : base(db)
        {

        }
        public new IQueryable<CartRecord> GetAll() => base.GetAll();
        public CartRecord GetById(int id) => base.GetOne(x => x.CartRecordID == id);
        public new int Delete(int id) => base.Delete(id);
        public new CartRecord Update(CartRecord cartRecord, int id) => base.Update(cartRecord, id);
        public new CartRecord Insert(CartRecord cartRecord) => base.Insert(cartRecord);
        public new void SaveChanges() => base.SaveChanges();

    }
}