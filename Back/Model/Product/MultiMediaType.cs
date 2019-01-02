using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class MultiMediaType
    {
         [Key]
        public int MultiMediaTypeID { get; set; }
        public string Name { get; set; }
    }
}