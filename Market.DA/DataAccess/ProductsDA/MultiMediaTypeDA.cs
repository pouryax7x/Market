
using System.Linq;
using Market.DA;
using Market.Model;
using PostgreSQL;
namespace Market.DA
{


    public class MultiMediaTypeDA : BaseDA<MultiMediaType>
    {
        public MultiMediaTypeDA(EntityContext db) : base(db)
        {

        }
        public new IQueryable<MultiMediaType> GetAll() => base.GetAll();
        public MultiMediaType GetById(int id) => base.GetOne(x => x.MultiMediaTypeID == id);
        public new int Delete(int id) => base.Delete(id);
        public new MultiMediaType Update(MultiMediaType multiMediaType, int id) => base.Update(multiMediaType, id);
        public new MultiMediaType Insert(MultiMediaType multiMediaType) => base.Insert(multiMediaType);
        public new void SaveChanges() => base.SaveChanges();

    }
}