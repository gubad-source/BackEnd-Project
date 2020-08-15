using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
   public class Bookcase
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

       public ICollection<Book> Books { get; set; }

    }
}
