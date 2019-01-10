using System.ComponentModel.DataAnnotations;

namespace Market.Model
{
    public class UserRecord
    {
        [Key]
        public int UserRecordID { get; set; }
        public User User { get; set; }
        public Record Record { get; set; }
    }
}