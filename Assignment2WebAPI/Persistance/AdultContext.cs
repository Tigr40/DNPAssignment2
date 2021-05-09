﻿using Assignment2WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment2WebAPI.Persistance
{
    public class AdultContext : DbContext
    {
        public DbSet<Adult> adults { get; set; }
        public DbSet<User> users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Adults.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Adult>().HasKey(sc => new {sc.Id});
        }
    }
}