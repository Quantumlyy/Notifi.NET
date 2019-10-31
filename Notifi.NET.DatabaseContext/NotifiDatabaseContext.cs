#pragma warning disable CS1591

using Microsoft.EntityFrameworkCore;
using Notifi.NET.DatabaseContext.Models.Towiccho;
using Notifi.NET.DatabaseContext.Models.Yotubii;

namespace Notifi.NET.DatabaseContext
{

    public class NotifiDatabaseContext : DbContext
    {
        public NotifiDatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TowicchoSubscription> TowicchoSubscriptions { get; set; }

        public DbSet<YotubiiSubscription> YotubiiSubscriptions { get; set; }
    }
}
