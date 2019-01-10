using System.ComponentModel.DataAnnotations;

namespace Market.Model
{
    public class ProductScore
    {
        [Key]
        public int ProductScoreID { get; set; }
        public Product Product { get; set; }
        public Score Score { get; set; }
    }
}