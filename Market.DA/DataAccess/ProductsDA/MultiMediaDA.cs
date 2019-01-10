
using System.Linq;
using Market.DA;
using Market.Model;
using PostgreSQL;
namespace Market.DA
{


    public class MultiMediaDA : BaseDA<MultiMedia>
    {
        public MultiMediaDA(EntityContext db) : base(db)
        {

        }
        public new IQueryable<MultiMedia> GetAll() => base.GetAll();
        public MultiMedia GetById(int id) => base.GetOne(x => x.MultiMediaID == id);
        public new int Delete(int id) => base.Delete(id);
        public new MultiMedia Update(MultiMedia multiMedia, int id) => base.Update(multiMedia, id);
        public new MultiMedia Insert(MultiMedia multiMedia) => base.Insert(multiMedia);
        public new void SaveChanges() => base.SaveChanges();

    }
}