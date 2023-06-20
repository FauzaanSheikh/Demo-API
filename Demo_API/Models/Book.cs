using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Demo_API.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public DateOnly ReleaseDate { get; set; }
    }
}

