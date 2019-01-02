using System;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class CartRecord
    {
        [Key]
        public int CartRecordID { get; set; }
        public Product Product { get; set; }
        public int Price { get; set; }
        public int Number { get; set; }
        public DateTime BuyDate { get; set; }
    }
}