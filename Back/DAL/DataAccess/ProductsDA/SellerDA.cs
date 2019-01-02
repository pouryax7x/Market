
using System.Linq;
using DAL;
using Model;
using PostgreSQL;
namespace DAL
{


    public class SellerDA : BaseDA<Seller>
    {
        public SellerDA(EntityContext db) : base(db)
        {

        }
        public new IQueryable<Seller> GetAll() => base.GetAll();
        public Seller GetById(int id) => base.GetOne(x => x.SellerID == id);
        public new int Delete(int id) => base.Delete(id);
        public new Seller Update(Seller seller, int id) => base.Update(seller, id);
        public new Seller Insert(Seller seller) => base.Insert(seller);
        public new void SaveChanges() => base.SaveChanges();

    }
}