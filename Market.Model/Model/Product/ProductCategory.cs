using System.ComponentModel.DataAnnotations;

namespace Market.Model
{
    public class ProductCategory
    {
        [Key]
        public int ProductCategoryID { get; set; }
        public Product Product { get; set; }
        public Category Category { get; set; }
    }
}