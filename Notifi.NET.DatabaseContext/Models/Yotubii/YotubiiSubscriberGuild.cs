#pragma warning disable CS1591

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Notifi.NET.DatabaseContext.Models.Yotubii
{
    public class YotubiiSubscriberGuild : SubscriberGuildBase, IEquatable<YotubiiSubscriberGuild>
    {
        [Key]
        [Required]
        [Column("id")]
        public long ID { get; set; }

        public override bool Equals(object obj) => Equals(obj as YotubiiSubscriberGuild);

        public bool Equals([AllowNull] YotubiiSubscriberGuild other)
        {
            return other != null &&
                   base.Equals(other) &&
                   ID == other.ID;
        }

        public override int GetHashCode()
            => HashCode.Combine(base.GetHashCode(), ID);

        public static bool operator ==(YotubiiSubscriberGuild left, YotubiiSubscriberGuild right)
            => EqualityComparer<YotubiiSubscriberGuild>.Default.Equals(left, right);

        public static bool operator !=(YotubiiSubscriberGuild left, YotubiiSubscriberGuild right)
            => !(left == right);
    }
}
