using System.Data.Entity;
using System.Reflection;
using EntityFramework.Demo.DomainModel;

namespace EntityFramework.Demo.DatabaseContext
{
    public class UserManagementDbContext : DbContext
    {
        // Map our 'User' model by convention
        public DbSet<User> Users { get; set; }

        public UserManagementDbContext() : base("Data Source=HOUNDS-TOOTH\\SQLEXPRESS;Initial Catalog=DbContextScopeDemo;Integrated Security=True")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Overrides for the convention-based mappings.
            // We're assuming that all our fluent mappings are declared in this assembly.
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetAssembly(typeof(UserManagementDbContext)));
        }
    }
}
