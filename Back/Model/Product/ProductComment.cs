using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class ProductComment
    {
        [Key]
        public int ProductCommentID { get; set; }
        public Product Product { get; set; }
        public Comment Score { get; set; }
    }
}