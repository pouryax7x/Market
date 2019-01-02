using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class MultiMedia
    {
        [Key]
        public int MultiMediaID { get; set; }
        public MultiMediaType MultiMediaType { get; set; }
        public string Path { get; set; }
    }
}