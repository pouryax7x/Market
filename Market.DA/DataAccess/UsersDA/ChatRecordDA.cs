using System.Linq;
using Market.DA;
using Market.Model;
using PostgreSQL;
namespace Market.DA
{
    public class ChatRecordDA : BaseDA<ChatRecord>
    {
        public ChatRecordDA(EntityContext db) : base(db)
        {

        }
        public new IQueryable<ChatRecord> GetAll() => base.GetAll();
        public ChatRecord GetById(int id) => base.GetOne(x => x.ChatRecordID == id);
        public new int Delete(int id) => base.Delete(id);
        public new ChatRecord Update(ChatRecord chatRecord, int id) => base.Update(chatRecord, id);
        public new ChatRecord Insert(ChatRecord chatRecord) => base.Insert(chatRecord);
        public new void SaveChanges() => base.SaveChanges();

    }
}