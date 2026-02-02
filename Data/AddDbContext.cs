
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<State> state { get; set; }
        public DbSet<City> city { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "server=DESKTOP-P0SEVP8\\SQLEXPRESS;Database=MyApp;TrustServerCertificate=true;Trusted_Connection=true");
            base.OnConfiguring(optionsBuilder);

        }

    }
}
