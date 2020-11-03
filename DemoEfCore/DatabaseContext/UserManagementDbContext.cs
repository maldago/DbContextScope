using System.Reflection;
using Microsoft.Extensions.Configuration;
using DemoEfCore.DomainModel;
using Microsoft.EntityFrameworkCore;

namespace DemoEfCore.DatabaseContext
{
    public class UserManagementDbContext : DbContext
    {
        // Map our 'User' model by convention
        public DbSet<User> Users { get; set; }

        public UserManagementDbContext() : base()
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=HOUNDS-TOOTH\\SQLEXPRESS;Initial Catalog=DbContextScopeDemo;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Overrides for the convention-based mappings.
            // We're assuming that all our fluent mappings are declared in this assembly.
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(UserManagementDbContext)));
        }
    }
}
