using System;
using Microsoft.EntityFrameworkCore;

namespace Demo_API.Models
{
	public class LibraryContext : DbContext
	{
        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public DbSet<Book>? Books { get; set; } = null;
    }
}

