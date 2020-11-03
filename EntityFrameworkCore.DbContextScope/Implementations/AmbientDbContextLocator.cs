/* 
 * Copyright (C) 2014 Mehdi El Gueddari
 * http://mehdi.me
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 */
using EntityFrameworkCore.DbContextScope.Interfaces;
using System.Data.Entity;

namespace EntityFrameworkCore.DbContextScope.Implementations
{
    public class AmbientDbContextLocator : IAmbientDbContextLocator
    {
#if NETCORE
        public TDbContext Get<TDbContext>() where TDbContext : Microsoft.EntityFrameworkCore.DbContext
        {
#else
        public TDbContext Get<TDbContext>() where TDbContext : DbContext
        {
#endif
            var ambientDbContextScope = DbContextScope.GetAmbientScope();

            return ambientDbContextScope == null ? null : ambientDbContextScope.DbContexts.Get<TDbContext>();
        }
    }
}