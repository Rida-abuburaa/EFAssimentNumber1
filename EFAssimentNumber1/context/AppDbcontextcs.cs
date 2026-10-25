using EFAssimentNumber1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAssimentNumber1.context
{
    public class AppDbcontextcs : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server = . ; Database = EFCoreG01C48 ; Trusted_Connection = true ; TrustServerCertificate = true");

        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Categories> Categoriess { get; set; }
        
    }
}
