using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyPal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        // Creating tables based on the models already created
        public DbSet<Floors> Floors { get; set; }

        /* This method OnModelCreating is created when the model is built.
         * In this case, the OnModelCreating is creating a composite key for Paths based on 
         * PinpointIdOne and PinpointIdTwo
         * */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Paths>()
                .HasKey(p => new { p.PinpointIdOne, p.PinpointIdTwo });
        }

        //Each DbSet repreents a table that is in the databse. This allows us to easily access and modify that data.
        public DbSet<Paths> Paths { get; set; }
        public DbSet<Pinpoints> Pinpoints { get; set; }
        public DbSet<PinpointsTypes> PinpointsTypes { get; set; }
        public DbSet<PrivateEvents> PrivateEvents { get; set; }
        public DbSet<PublicEvents> PublicEvents { get; set; }

    }
}

