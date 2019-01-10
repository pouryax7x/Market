using System.ComponentModel.DataAnnotations;

namespace Market.Model
{
    public class Score
    {
        [Key]
        public int ScoreID { get; set; }
        public int Rank { get; set; }
        public User User { get; set; }
    }
}