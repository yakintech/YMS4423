using BilgeAdam.Data.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Data.ORM.Context
{
    public class BilgeAdamContext : DbContext
    {
        public BilgeAdamContext()
        {
            Database.Connection.ConnectionString = "Server=.;Database=BilgeAdamdb;UID=sa;PWD=123";
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<AdminUser> AdminUsers { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<WebUser> WebUsers { get; set; }
    }
}
