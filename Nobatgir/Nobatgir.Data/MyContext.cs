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

        public DbSet<Category> Categories { get; set; }
        public DbSet<CategorySetting> CategorySettings { get; set; }

        public DbSet<Expert> Experts { get; set; }
        public DbSet<ExpertSetting> ExpertSettings { get; set; }
        public DbSet<ExpertTimeTemplate> ExpertTimeTemplates { get; set; }

        public DbSet<SiteKind> SiteKinds { get; set; }
        public DbSet<SiteKindSetting> SiteKindSettings { get; set; }


        public DbSet<AdminMenu> AdminMenus { get; set; }

        public DbSet<DictionaryTerm> DictionaryTerms { get; set; }
        public DbSet<SiteDictionary> SiteDictionaries { get; set; }
        public DbSet<SiteKindDictionary> SiteKindDictionaries { get; set; }

        public DbSet<Level> Levels { get; set; }

        public DbSet<Turn> Turns { get; set; }

        public DbSet<TurnDetails> TurnDetails { get; set; }

        public DbSet<SourceType> SourceTypes { get; set; }

        public DbSet<SourceValue> SourceValues { get; set; }
        public DbSet<ExpertField> ExpertFields { get; set; }

    }
}

