
using System.Linq;
using Market.DA;
using Market.Model;
using PostgreSQL;
namespace Market.DA
{


    public class CommentDA : BaseDA<Comment>
    {
        public CommentDA(EntityContext db) : base(db)
        {

        }
        public new IQueryable<Comment> GetAll() => base.GetAll();
        public Comment GetById(int id) => base.GetOne(x => x.CommentID == id);
        public new int Delete(int id) => base.Delete(id);
        public new Comment Update(Comment comment, int id) => base.Update(comment, id);
        public new Comment Insert(Comment comment) => base.Insert(comment);
        public new void SaveChanges() => base.SaveChanges();

    }
}