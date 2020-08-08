using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Library.Models;



namespace Library.Data
{
    //Library context have been created for project//
    class LibraryContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=LAPTOP-D6PJ3FJ7;Database=Library;Integrated Security=True");
        }
       public DbSet<Book> Books { get; set; }
       public DbSet<Customer> Customers { get; set; }
       public DbSet<Manager> Managers { get; set; }
       public  DbSet <Report> Reports { get; set; }
       public DbSet<Shelf> Shelfs { get; set; }
       public DbSet<Bookcase> Bookcases { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
