
using System.Linq;
using DAL;
using Model;
using PostgreSQL;
namespace DAL
{


    public class NationDA : BaseDA<Nation>
    {
        public NationDA(EntityContext db) : base(db)
        {

        }
        public new IQueryable<Nation> GetAll() => base.GetAll();
        public Nation GetById(int id) => base.GetOne(x => x.NationID == id);
        public new int Delete(int id) => base.Delete(id);
        public new Nation Update(Nation nation, int id) => base.Update(nation, id);
        public new Nation Insert(Nation nation) => base.Insert(nation);
        public new void SaveChanges() => base.SaveChanges();

    }
}