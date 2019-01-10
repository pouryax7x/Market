using System.ComponentModel.DataAnnotations;

namespace Market.Model
{
    public class UserCart
    {
        [Key]
        public int UserCartID { get; set; }
        public User User { get; set; }
        public Cart Cart { get; set; }
    }
}