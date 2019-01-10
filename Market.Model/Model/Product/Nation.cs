using System.ComponentModel.DataAnnotations;

namespace Market.Model
{
    public class Nation
    {
        [Key]
        public int NationID { get; set; }
        public string Name { get; set; }
    }
}