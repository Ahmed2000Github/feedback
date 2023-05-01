using Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
   public class DataContext : IdentityDbContext<Rater, IdentityRole<Guid>, Guid>
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Rating>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Categorie>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Categorie>().HasData(
                new Categorie()
                {
                    Id = new Guid("775ae4c9-e0cb-4764-9b26-18047b308209"),
                    Name = "Mobiles"
                },
                new Categorie()
                {
                    Id = new Guid("e95a3869-262f-49df-bfbc-504a328c9f0e"),
                    Name = "Computers"
                },
                new Categorie()
                {
                    Id = new Guid("898dd22e-9219-443f-99f1-fcfecb376daa"),
                    Name = "Others"
                }
                );
        }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Categorie> Categories { get; set; }
    }
}
