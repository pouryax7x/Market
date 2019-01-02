using System.Linq;
using DAL;
using Model;
using PostgreSQL;
namespace DAL
{
    public class RecordDA : BaseDA<Record>
    {
        public RecordDA(EntityContext db) : base(db)
        {

        }
        public new IQueryable<Record> GetAll() => base.GetAll();
        public Record GetById(int id) => base.GetOne(x => x.RecordID == id);
        public new int Delete(int id) => base.Delete(id);
        public new Record Update(Record record, int id) => base.Update(record, id);
        public new Record Insert(Record record) => base.Insert(record);
        public new void SaveChanges() => base.SaveChanges();

    }
}