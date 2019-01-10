using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Market.Model
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string NationalNumber { get; set; }

        public List<UserContact> UserContacts { get; set; }
        public List<UserRecord> UserSearchs { get; set; }
        public List<UserCart> UserCarts { get; set; }
        public List<UserCartRecord> UserCartRecords { get; set; }
        public List<UserChatRecord> UserChatRecords { get; set; }
    }
}