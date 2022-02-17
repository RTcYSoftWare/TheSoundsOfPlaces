using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheSoundsOfPlaces.Database
{
    public class TheSoundsOfPlacesDBContext : DbContext
    {
        public TheSoundsOfPlacesDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Sound> Sounds { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().ToTable("Admins");
            modelBuilder.Entity<Sound>().ToTable("Sounds");
            modelBuilder.Entity<Category>().ToTable("Categories");
        }


    }
}
