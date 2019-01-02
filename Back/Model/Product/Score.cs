using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Score
    {
        [Key]
        public int ScoreID { get; set; }
        public int Rank { get; set; }
        public User User { get; set; }
    }
}