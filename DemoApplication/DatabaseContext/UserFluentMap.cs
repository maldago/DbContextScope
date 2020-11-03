using System.Data.Entity.ModelConfiguration;
using EntityFramework.Demo.DomainModel;

namespace EntityFramework.Demo.DatabaseContext
{
    /// <summary>
    /// Defines the convention-based mapping overrides for the User model. 
    /// </summary>
    public class UserFluentMap : EntityTypeConfiguration<User>
    {
        public UserFluentMap()
        {
            Property(m => m.Name).IsRequired();
            Property(m => m.Email).IsRequired();
        }
    }
}
