using Demo.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Data
{
    public class DemoDbContext : DbContext
    {

        public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options)
        {
        }

        public DemoDbContext():base()
        {
        }
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                // Chemin : C:\Users\<nom>\Demo\demo.db
                string dbPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                    "Demo", "demo.db");

                // Crée le fichier si nécessaire
                Directory.CreateDirectory(Path.GetDirectoryName(dbPath)!);

                // Configure SQLite avec le chemin
                optionsBuilder.UseSqlite($"Data Source={dbPath}");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

        }
    }
}
