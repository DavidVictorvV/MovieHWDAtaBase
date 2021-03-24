using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieHW_Db.Models;

namespace MovieHW_Db.Data
{
    public class MovieHW_DbContext : DbContext
    {

        public DbSet<MovieHW_Db.Models.Movie> Movie { get; set; }
        public MovieHW_DbContext (DbContextOptions<MovieHW_DbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
