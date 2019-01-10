using System.ComponentModel.DataAnnotations;

namespace Market.Model
{
    public class Similar
    {
        [Key]
        public int SimilarID { get; set; }
        public Product Product { get; set; }
    }
}