
using System.Linq;
using DAL;
using Model;
using PostgreSQL;
namespace DAL
{


    public class SimilarDA : BaseDA<Similar>
    {
        public SimilarDA(EntityContext db) : base(db)
        {

        }
        public new IQueryable<Similar> GetAll() => base.GetAll();
        public Similar GetById(int id) => base.GetOne(x => x.SimilarID == id);
        public new int Delete(int id) => base.Delete(id);
        public new Similar Update(Similar similar, int id) => base.Update(similar, id);
        public new Similar Insert(Similar similar) => base.Insert(similar);
        public new void SaveChanges() => base.SaveChanges();

    }
}