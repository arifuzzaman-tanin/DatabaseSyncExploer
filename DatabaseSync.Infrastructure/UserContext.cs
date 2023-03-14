using DatabaseSync.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatabaseSync.Infrastructure
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Mt4User> Mt4Users { get; set; }
    }
}
