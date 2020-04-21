using AcmeCorpBookCatalogueApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcmeCorpBookCatalogueApi.Context
{
    public class BookCatalogueContext : DbContext
    {
        public BookCatalogueContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
