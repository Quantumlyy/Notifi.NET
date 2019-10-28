using Microsoft.EntityFrameworkCore;

using Notifi.NET.DatabaseContext.Models.Towiccho;
using Notifi.NET.DatabaseContext.Models.Yotubii;

namespace Notifi.NET.DatabaseContext
{
    class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TowicchoSubscription> TowicchoSubscriptions { get; set; }

        public DbSet<YotubiiSubscription> YotubiiSubscriptions { get; set; }
    }
}
