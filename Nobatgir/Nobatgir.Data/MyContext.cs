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
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("dbo");
        }

        public DbSet<Site> Sites { get; set; }
        public DbSet<SiteSetting> SiteSettings { get; set; }
        public DbSet<SiteTimeTemplate> SiteTimeTemplates { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<CategorySetting> CategorySettings { get; set; }
        public DbSet<CategoryTimeTemplate> CategoryTimeTemplates { get; set; }

        public DbSet<Expert> Experts { get; set; }
        public DbSet<ExpertSetting> ExpertSettings { get; set; }
        public DbSet<ExpertTimeTemplate> ExpertTimeTemplates { get; set; }

        public DbSet<Model.Action> Actions { get; set; }
        public DbSet<Model.ActionCategory> ActionCategories { get; set; }
        public DbSet<Model.RoleAction> RoleActions { get; set; }

    }
}

