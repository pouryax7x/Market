using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Record
    {
        [Key]
        public int RecordID { get; set; }
        public string Subject { get; set; }
    }
}