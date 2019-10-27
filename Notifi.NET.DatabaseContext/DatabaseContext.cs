using Microsoft.EntityFrameworkCore;

using Notifi.NET.DatabaseContext.Models.Towiccho;

namespace Notifi.NET.DatabaseContext
{
    class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TowicchoSubscription> TowicchoSubscriptions { get; set; }
    }
}
