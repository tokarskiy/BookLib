using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Books.Models
{
    public class Book
    {
        public Int32 Id { get; set; }

        [JsonProperty("bookName")]
        [MaxLength(50)]
        [Required]
        public String Name { get; set; }

        [JsonProperty("authorName")]
        [MaxLength(50)]
        [Required]
        public String Author { get; set; }
    }

    public class BookContext : DbContext
    {
        public BookContext() : base() { }
        public DbSet<Book> Books { get; set; }
    }
}