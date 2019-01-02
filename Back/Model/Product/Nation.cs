using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Nation
    {
        [Key]
        public int NationID { get; set; }
        public string Name { get; set; }
    }
}