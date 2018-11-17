using Microsoft.EntityFrameworkCore;
using System;
using Nobatgir.Model;

namespace Nobatgir.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        public MyContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
        }

        public DbSet<Site> Sites { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<TimeTemplate> TimeTemplates { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<AdminMenu> AdminMenus { get; set; }
    }
}

