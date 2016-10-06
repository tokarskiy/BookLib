using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Books.Models;

namespace Books.Controllers
{
    public class SimpleBooksController : ApiController
    {
        private Book[] books = new Book[]
        {
            new Book { Id = 0, Name = "Harry Potter", Author = "Rowling" },
            new Book { Id = 1, Name = "Lord of the Rings", Author = "Tolkien"},
            new Book { Id = 2, Name = "Code Da Vinci", Author = "Den Braun"},
        };

        // GET: api/SimpleBooks
        public String Get()
        {
            return JsonConvert.SerializeObject(books);
        }

        public Int32 Count => books.Length;
    }
}
