#pragma warning disable CS1591

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Notifi.NET.DatabaseContext.Models
{
    public class SubscriptionBase<T> : IEquatable<SubscriptionBase<T>>
    {
        [Required]
        [Column("guilds")]
        public List<T> Guilds { get; set; }

        [Required]
        [Column("at_create")]
        public DateTime CreatedAt { get; set; }

        public override bool Equals(object obj)
            => Equals(obj as SubscriptionBase<T>);

        public bool Equals([AllowNull] SubscriptionBase<T> other)
        {
            return other != null &&
                   EqualityComparer<List<T>>.Default.Equals(Guilds, other.Guilds) &&
                   CreatedAt == other.CreatedAt;
        }

        public override int GetHashCode()
            => HashCode.Combine(Guilds, CreatedAt);

        public static bool operator ==(SubscriptionBase<T> left, SubscriptionBase<T> right)
            => EqualityComparer<SubscriptionBase<T>>.Default.Equals(left, right);

        public static bool operator !=(SubscriptionBase<T> left, SubscriptionBase<T> right)
            => !(left == right);
    }
}
