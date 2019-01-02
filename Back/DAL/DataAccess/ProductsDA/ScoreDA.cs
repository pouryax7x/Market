
using System.Linq;
using DAL;
using Model;
using PostgreSQL;
namespace DAL
{


    public class ScoreDA : BaseDA<Score>
    {
        public ScoreDA(EntityContext db) : base(db)
        {

        }
        public new IQueryable<Score> GetAll() => base.GetAll();
        public Score GetById(int id) => base.GetOne(x => x.ScoreID == id);
        public new int Delete(int id) => base.Delete(id);
        public new Score Update(Score score, int id) => base.Update(score, id);
        public new Score Insert(Score score) => base.Insert(score);
        public new void SaveChanges() => base.SaveChanges();

    }
}