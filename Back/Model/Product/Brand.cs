using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Brand
    {
        [Key]
        public int BrandID { get; set; }
     //    [Required]
      //   [MaxLength(50),MinLength(2)]
        public string Name { get; set; }
    }
}