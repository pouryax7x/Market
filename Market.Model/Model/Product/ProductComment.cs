using System.ComponentModel.DataAnnotations;

namespace Market.Model
{
    public class ProductComment
    {
        [Key]
        public int ProductCommentID { get; set; }
        public Product Product { get; set; }
        public Comment Score { get; set; }
    }
}