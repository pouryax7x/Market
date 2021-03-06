using System.ComponentModel.DataAnnotations;

namespace Market.Model
{
    public class UserCartRecord
    {
        [Key]
        public int UserCartRecordID { get; set; }
        public User User { get; set; }
        public CartRecord CartRecord { get; set; }
    }
}