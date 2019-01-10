
using System.Linq;
using Market.DA;
using Market.Model;
using PostgreSQL;
namespace Market.DA
{


    public class ProductMultiMediaDA : BaseDA<ProductMultiMedia>
    {
        public ProductMultiMediaDA(EntityContext db) : base(db)
        {

        }
        public new IQueryable<ProductMultiMedia> GetAll() => base.GetAll();
        public ProductMultiMedia GetById(int id) => base.GetOne(x => x.ProductMultiMediaID == id);
        public new int Delete(int id) => base.Delete(id);
        public new ProductMultiMedia Update(ProductMultiMedia productMultiMedia, int id) => base.Update(productMultiMedia, id);
        public new ProductMultiMedia Insert(ProductMultiMedia productMultiMedia) => base.Insert(productMultiMedia);
        public new void SaveChanges() => base.SaveChanges();

    }
}