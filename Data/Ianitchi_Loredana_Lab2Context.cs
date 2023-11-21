using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ianitchi_Loredana_Lab2.Models;

namespace Ianitchi_Loredana_Lab2.Data
{
    public class Ianitchi_Loredana_Lab2Context : DbContext
    {
        public Ianitchi_Loredana_Lab2Context (DbContextOptions<Ianitchi_Loredana_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Ianitchi_Loredana_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Ianitchi_Loredana_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Ianitchi_Loredana_Lab2.Models.Author>? Author { get; set; }

        public DbSet<Ianitchi_Loredana_Lab2.Models.Category>? Category { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(e => e.Borrowing)
            .WithOne(e => e.Book)
                .HasForeignKey<Borrowing>("BookID");
        }
        public DbSet<Ianitchi_Loredana_Lab2.Models.Borrowing>? Borrowing { get; set; }
        public DbSet<Ianitchi_Loredana_Lab2.Models.Member>? Member { get; set; }

       
    }
}
