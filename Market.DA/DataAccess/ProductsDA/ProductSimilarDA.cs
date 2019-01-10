
using System.Linq;
using Market.DA;
using Market.Model;
using PostgreSQL;
namespace Market.DA
{


    public class ProductSimilarDA : BaseDA<ProductSimilar>
    {
        public ProductSimilarDA(EntityContext db) : base(db)
        {

        }
        public new IQueryable<ProductSimilar> GetAll() => base.GetAll();
        public ProductSimilar GetById(int id) => base.GetOne(x => x.ProductSimilarID == id);
        public new int Delete(int id) => base.Delete(id);
        public new ProductSimilar Update(ProductSimilar productSimilar, int id) => base.Update(productSimilar, id);
        public new ProductSimilar Insert(ProductSimilar productSimilar) => base.Insert(productSimilar);
        public new void SaveChanges() => base.SaveChanges();

    }
}