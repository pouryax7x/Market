using System.ComponentModel.DataAnnotations;

namespace Market.Model
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public int Parent { get; set; }
        public string Name { get; set; }
    }
}