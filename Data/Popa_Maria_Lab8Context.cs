using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Popa_Maria_Lab8.Models;

namespace Popa_Maria_Lab8.Data
{
    public class Popa_Maria_Lab8Context : DbContext
    {
        public Popa_Maria_Lab8Context (DbContextOptions<Popa_Maria_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Popa_Maria_Lab8.Models.Book> Book { get; set; }

        public DbSet<Popa_Maria_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Popa_Maria_Lab8.Models.BookCategory> BookCategory { get; set; }
    }
}
