using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Model
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public bool Enabled{ get; set; }
        public Nation Nation { get; set; }
        public Brand Brand { get; set; }
        public List<ProductScore> ProductScore { get; set; }
        public List<ProductComment> ProductComment { get; set; }
        public List<ProductMultiMedia> ProductMultiMedia { get; set; }
        public List<ProductSeller> ProductSeller { get; set; }
        public List<ProductSimilar> ProductSimilar { get; set; }
    }
}
