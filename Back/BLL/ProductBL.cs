
using System.Linq;
using DAL;
using Microsoft.EntityFrameworkCore;
using Model;
using PostgreSQL;

namespace DAL
{


    public class ProductBL : BaseDA<Product>
    {
        ProductDA _productDA;
        public ProductBL(EntityContext db) : base(db)
        {
            _productDA = new ProductDA(db);
        }
        public new IQueryable<Product> GetAll() => _productDA.GetAll()
        .Include(x => x.Brand)
        .Include(x => x.Nation)
        .Include(x => x.ProductScore)

        .Include(x => x.ProductComment)
            .ThenInclude(x => x.Score)

        .Include(x => x.ProductSeller)
            .ThenInclude(x => x.Seller)
                .ThenInclude(x => x.User)

        .Include(x => x.ProductSimilar)
            .ThenInclude(x => x.Similar)
                .ThenInclude(x=>x.Product);
        public Product GetById(int id) => _productDA.GetById(x => x.ProductID == id);
        public IQueryable<Product> GetByName(string name) => _productDA.GetByName(x => x.Name.Contains(name));
        public IQueryable<Product> GetByName(string name, int sliceNumber, int startPage)
         => base.GetSome(x => x.Name.Contains(name)).Skip(startPage * (sliceNumber - 1)).Take(sliceNumber);
        public new int Delete(int id) => base.Delete(id);
        public new Product Update(Product product, int id) => base.Update(product, id);
        public new Product Insert(Product product) => base.Insert(product);
        public new void SaveChanges() => base.SaveChanges();

    }
}