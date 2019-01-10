using System.ComponentModel.DataAnnotations;
namespace Market.Model
{
    public class ProductSeller
    {
        [Key]
        public int ProductSellerID { get; set; }
        public Product Product { get; set; }
        public Seller Seller { get; set; }
        public int Number { get; set; }
        public long Price { get; set; }
    }
}