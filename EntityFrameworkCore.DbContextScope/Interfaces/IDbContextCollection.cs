﻿/* 
 * Copyright (C) 2014 Mehdi El Gueddari
 * http://mehdi.me
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 */
using System;
using System.Data.Entity;

namespace EntityFrameworkCore.DbContextScope.Interfaces
{
    /// <summary>
    /// Maintains a list of lazily-created DbContext instances.
    /// </summary>
    public interface IDbContextCollection : IDisposable
    {
        /// <summary>
        /// Get or create a DbContext instance of the specified type. 
        /// </summary>
#if NETCORE
		TDbContext Get<TDbContext>() where TDbContext : Microsoft.EntityFrameworkCore.DbContext;
#else
        TDbContext Get<TDbContext>() where TDbContext : DbContext;
#endif 
    }
}