/* 
 * Copyright (C) 2014 Mehdi El Gueddari
 * http://mehdi.me
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 */
using System.Data.Entity;

namespace EntityFrameworkCore.DbContextScope.Interfaces
{
    /// <summary>
    /// Convenience methods to retrieve ambient DbContext instances. 
    /// </summary>
    public interface IAmbientDbContextLocator
    {
        /// <summary>
        /// If called within the scope of a DbContextScope, gets or creates 
        /// the ambient DbContext instance for the provided DbContext type. 
        /// 
        /// Otherwise returns null. 
        /// </summary>
#if NETCORE
        TDbContext Get<TDbContext>() where TDbContext : Microsoft.EntityFrameworkCore.DbContext;
#else
        TDbContext Get<TDbContext>() where TDbContext : System.Data.Entity.DbContext;
#endif
    }
}
