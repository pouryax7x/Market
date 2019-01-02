using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }
}