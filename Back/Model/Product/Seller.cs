using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Seller
    {
        [Key]
        public int SellerID { get; set; }
        public User User { get; set; }
    }
}