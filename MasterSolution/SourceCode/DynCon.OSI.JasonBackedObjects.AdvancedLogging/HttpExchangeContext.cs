using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DynCon.OSI.JasonBackedObjects.AdvancedLogging
{
    public class HttpExchangeContext : DbContext
    {
        public DbSet<ExchangeEntry> ExchangeEntries { get; set; }
        public DbSet<PositionalParameter> PositionalParameters { get; set; }
        public DbSet<QueryParameter> QueryParameters { get; set; }

        public HttpExchangeContext()
            : base("HttpExchangeContext") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) { modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); }
    }
}