using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Master1.Models
{
    public class TaxContext : DbContext
    {
        public TaxContext() : base("TaxContext")
        {
        }
        public DbSet<SalariatModel> Salariati { get; set; }
        public DbSet<TaxeModel> Taxe { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}