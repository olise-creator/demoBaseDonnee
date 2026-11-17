using System;
using System.Collections.Generic;
using System.Text;
using Demo.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.Data
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DemoDbContext()
        {
        }
        public DbSet<Client> Clients { get; set; }
    }
}
