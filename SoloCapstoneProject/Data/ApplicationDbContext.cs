using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SoloCapstoneProject.Models;

namespace SoloCapstoneProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
            .HasData(
            new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN"
            }
            );
        }

        public DbSet<Consumers> Consumers { get; set; }
        public DbSet<Providers> Providers { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<ProviderAvailability> ProviderAvailabilities { get; set; }

    }
}
