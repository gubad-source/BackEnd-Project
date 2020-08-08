using System;
using System.Collections.Generic;
using System.Text;
 using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    //Order have been created//
   public class Order
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int BookId { get; set; }
        public Book Book { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [Required]
        public DateTime DeadLine { get; set; }
    }
}
