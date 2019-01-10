using System.Linq;
using Market.DA;
using Market.Model;
using PostgreSQL;
namespace Market.DA
{
    public class ContactDA : BaseDA<Contact>
    {
        public ContactDA(EntityContext db) : base(db)
        {

        }
        public new IQueryable<Contact> GetAll() => base.GetAll();
        public Contact GetById(int id) => base.GetOne(x => x.ContactID == id);
        public new int Delete(int id) => base.Delete(id);
        public new Contact Update(Contact contact, int id) => base.Update(contact, id);
        public new Contact Insert(Contact contact) => base.Insert(contact);
        public new void SaveChanges() => base.SaveChanges();

    }
}