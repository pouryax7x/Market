
using System.Linq;
using DAL;
using Model;
using PostgreSQL;
namespace DAL
{


    public class ProductCommentDA : BaseDA<ProductComment>
    {
        public ProductCommentDA(EntityContext db) : base(db)
        {

        }
        public new IQueryable<ProductComment> GetAll() => base.GetAll();
        public ProductComment GetById(int id) => base.GetOne(x => x.ProductCommentID == id);
        public new int Delete(int id) => base.Delete(id);
        public new ProductComment Update(ProductComment productComment, int id) => base.Update(productComment, id);
        public new ProductComment Insert(ProductComment productComment) => base.Insert(productComment);
        public new void SaveChanges() => base.SaveChanges();

    }
}