using System.ComponentModel.DataAnnotations;

namespace Market.Model
{
    public class UserContact
    {
        [Key]
        public int UserContactID { get; set; }
        public User User { get; set; }
        public Contact Contact { get; set; }
    }
}