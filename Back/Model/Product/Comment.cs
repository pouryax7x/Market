using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string Subject { get; set; }
        public User User { get; set; }
    }
}