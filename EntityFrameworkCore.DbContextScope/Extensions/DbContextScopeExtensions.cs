using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;

namespace DbContextScope.Extensions
{
    public static class DbContextExtensions
    {
        /// <summary>
        /// Convenience method to get the <see cref="IStateManager"/>
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static IStateManager GetStateManager(this DbContext context)
        {
            return context.GetDependencies().StateManager;
        }
    }
}