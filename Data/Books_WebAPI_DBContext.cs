using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Books_WebAPI.Model;

namespace Books_WebAPI.Models
{
    public class Books_WebAPI_DBContext : DbContext
    {
        public Books_WebAPI_DBContext (DbContextOptions<Books_WebAPI_DBContext> options)
            : base(options)
        {
        }

        public DbSet<Books_WebAPI.Model.Books> Books { get; set; }
    }
}
