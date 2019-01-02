using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class UserChatRecord
    {
        [Key]
        public int UserChatRecordID { get; set; }
        public User User { get; set; }
        public ChatRecord ChatRecord { get; set; }
    }
}