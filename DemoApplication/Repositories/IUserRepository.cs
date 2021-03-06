﻿using System;
using System.Threading.Tasks;
using EntityFramework.Demo.DomainModel;

namespace EntityFramework.Demo.Repositories
{
    public interface IUserRepository
    {
        User Get(Guid userId);
        Task<User> GetAsync(Guid userId);
        void Add(User user);
    }
}