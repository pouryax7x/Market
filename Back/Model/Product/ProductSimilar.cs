using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class ProductSimilar
    {
        [Key]
        public int ProductSimilarID { get; set; }
        public Product Product { get; set; }
        public Similar Similar { get; set; }
    }
}