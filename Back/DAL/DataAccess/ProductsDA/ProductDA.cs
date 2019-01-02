
using System;
using System.Linq;
using DAL;
using Microsoft.EntityFrameworkCore;
using Model;
using PostgreSQL;
namespace DAL
{


    public class ProductDA : BaseDA<Product>
    {
        public ProductDA(EntityContext db) : base(db)
        {
        }
        public new IQueryable<Product> GetAll() => base.GetAll();
        public Product GetById(Func<Product, bool> crit) => base.GetOne(crit);
        public IQueryable<Product> GetByName(Func<Product, bool> crit) => base.GetSome(crit);
        public new int Delete(int id) => base.Delete(id);
        public new Product Update(Product product, int id) => base.Update(product, id);
        public new Product Insert(Product product) => base.Insert(product);
        public new void SaveChanges() => base.SaveChanges();

    }
}