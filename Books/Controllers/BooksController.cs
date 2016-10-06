using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Books.Models;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Books.Controllers
{
    public class BooksController : ApiController
    {
        private BookContext db = new BookContext();

        // GET: api/Books
        public String Get()
        {
            return JsonConvert.SerializeObject(db.Books);
        }

        // POST: api/Books
        public void Post([FromBody]Book value)
        {
            db.Books.Add(value);
            db.SaveChanges();
        }
    }
}
