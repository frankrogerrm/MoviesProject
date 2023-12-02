using Microsoft.EntityFrameworkCore;
using MoviesProject.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MoviesProject.Service.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Movie> Movies => Set<Movie>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Movie>().HasData(TestData.Movies);
        }
    }
}
