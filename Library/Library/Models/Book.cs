using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
   public class Book
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public string  Price { get; set; }
        public int ShelfId { get; set; }
        public Shelf Shelf { get; set; }
        public int BookcaseId { get; set; }
        public Bookcase Bookcase { get; set; }

    }
}
