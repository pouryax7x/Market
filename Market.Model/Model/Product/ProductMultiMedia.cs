using System.ComponentModel.DataAnnotations;

namespace Market.Model
{
    public class ProductMultiMedia
    {
         [Key]
        public int ProductMultiMediaID { get; set; }
        public Product Product { get; set; }
        public MultiMedia MultiMedia { get; set; }
    }
}