using System;
using Microsoft.EntityFrameworkCore;

namespace Demo_API.Models
{
	public class ApplicationDbContext: DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book>? Books { get; set; } = null;
        public DbSet<User>? Users { get; set; } = null;
    }
}


