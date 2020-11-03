using System;
using System.Threading.Tasks;
using DemoEfCore.DomainModel;

namespace DemoEfCore.Repositories
{
    public interface IUserRepository
    {
        User Get(Guid userId);
        ValueTask<User> GetAsync(Guid userId);
        void Add(User user);
    }
}