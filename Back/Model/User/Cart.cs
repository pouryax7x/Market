using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Cart
    {
        [Key]
        public int CartID { get; set; }
        public Product Product { get; set; }
    }
}