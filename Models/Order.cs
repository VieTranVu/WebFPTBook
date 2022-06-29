using WebFPTBook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebFPTBook.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }
        public DateTime Order_Date { get; set; }
        [Required]
        public int Quantity { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }
    }
}
