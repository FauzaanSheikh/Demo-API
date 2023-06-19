using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Demo_API.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        // Additional properties...
    }

    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }

}

