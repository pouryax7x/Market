
using System.Linq;
using DAL;
using Model;
using PostgreSQL;
namespace DAL
{


    public class ProductSellerDA : BaseDA<ProductSeller>
    {
        public ProductSellerDA(EntityContext db) : base(db)
        {

        }
        public new IQueryable<ProductSeller> GetAll() => base.GetAll();
        public ProductSeller GetById(int id) => base.GetOne(x => x.ProductSellerID == id);
        public new int Delete(int id) => base.Delete(id);
        public new ProductSeller Update(ProductSeller productSeller, int id) => base.Update(productSeller, id);
        public new ProductSeller Insert(ProductSeller productSeller) => base.Insert(productSeller);
        public new void SaveChanges() => base.SaveChanges();

    }
}