
using System.Linq;
using DAL;
using Model;
using PostgreSQL;
namespace DAL
{


    public class ProductScoreDA : BaseDA<ProductScore>
    {
        public ProductScoreDA(EntityContext db) : base(db)
        {

        }
        public new IQueryable<ProductScore> GetAll() => base.GetAll();
        public ProductScore GetById(int id) => base.GetOne(x => x.ProductScoreID == id);
        public new int Delete(int id) => base.Delete(id);
        public new ProductScore Update(ProductScore productScore, int id) => base.Update(productScore, id);
        public new ProductScore Insert(ProductScore productScore) => base.Insert(productScore);
        public new void SaveChanges() => base.SaveChanges();

    }
}