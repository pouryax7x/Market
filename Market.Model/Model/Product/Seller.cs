using System.ComponentModel.DataAnnotations;

namespace Market.Model
{
    public class Seller
    {
        [Key]
        public int SellerID { get; set; }
        public User User { get; set; }
    }
}