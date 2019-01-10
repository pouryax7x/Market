using System.ComponentModel.DataAnnotations;

namespace Market.Model
{
    public class Cart
    {
        [Key]
        public int CartID { get; set; }
        public Product Product { get; set; }
    }
}