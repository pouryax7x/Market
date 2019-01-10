using System.ComponentModel.DataAnnotations;

namespace Market.Model
{
    public class ProductSimilar
    {
        [Key]
        public int ProductSimilarID { get; set; }
        public Product Product { get; set; }
        public Similar Similar { get; set; }
    }
}