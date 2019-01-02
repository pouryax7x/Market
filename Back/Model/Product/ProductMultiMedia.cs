using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class ProductMultiMedia
    {
         [Key]
        public int ProductMultiMediaID { get; set; }
        public Product Product { get; set; }
        public MultiMedia MultiMedia { get; set; }
    }
}