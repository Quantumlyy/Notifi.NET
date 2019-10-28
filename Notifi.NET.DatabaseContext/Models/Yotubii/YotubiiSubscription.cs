using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Notifi.NET.DatabaseContext.Models.Yotubii
{
    class YotubiiSubscription : SubscriptionBase<YotubiiSubscriberGuild>, IEquatable<YotubiiSubscription>
    {
        [Key]
        [Required]
        [Column("id")]
        public long ID { get; set; }

        public override bool Equals(object obj)
            => Equals(obj as YotubiiSubscription);

        public bool Equals([AllowNull] YotubiiSubscription other)
        {
            return other != null &&
                   base.Equals(other) &&
                   ID == other.ID;
        }

        public override int GetHashCode()
            => HashCode.Combine(base.GetHashCode(), ID);

        public static bool operator ==(YotubiiSubscription left, YotubiiSubscription right)
            => EqualityComparer<YotubiiSubscription>.Default.Equals(left, right);

        public static bool operator !=(YotubiiSubscription left, YotubiiSubscription right)
            => !(left == right);
    }
}
