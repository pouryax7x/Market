using System.ComponentModel.DataAnnotations;

namespace Market.Model
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string Subject { get; set; }
        public User User { get; set; }
    }
}