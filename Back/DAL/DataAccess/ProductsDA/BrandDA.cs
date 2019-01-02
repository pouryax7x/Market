
using System.Collections.Generic;
using System.Linq;
using DAL;
using Model;
using PostgreSQL;
namespace DAL
{
    public class BrandDA : BaseDA<Brand>
    {
        public BrandDA(EntityContext db) : base(db)
        {

        }
        public new IQueryable<Brand> GetAll() => base.GetAll();
        public Brand GetById(int id) => base.GetOne(x => x.BrandID == id);
        public Brand GetByName(string name) => base.GetOne(x => x.Name == name);
        public new int Delete(int id) => base.Delete(id);
        public new Brand Update(Brand brand, int id) => base.Update(brand, id);
        public new Brand Insert(Brand brand) => base.Insert(brand);
        public new void SaveChanges() => base.SaveChanges();

    }
}