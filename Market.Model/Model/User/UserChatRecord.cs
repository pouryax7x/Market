using System.ComponentModel.DataAnnotations;

namespace Market.Model
{
    public class UserChatRecord
    {
        [Key]
        public int UserChatRecordID { get; set; }
        public User User { get; set; }
        public ChatRecord ChatRecord { get; set; }
    }
}