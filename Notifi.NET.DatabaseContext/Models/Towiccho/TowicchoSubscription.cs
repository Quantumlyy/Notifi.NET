#pragma warning disable CS1591

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Notifi.NET.DatabaseContext.Models.Towiccho
{
    public class TowicchoSubscription : SubscriptionBase<TowicchoSubscriberGuild>, IEquatable<TowicchoSubscription>
    {
        [Key]
        [Required]
        [Column("id")]
        public long ID { get; set; }

        [Required]
        [Column("twitch_id")]
        public string TwitchID { get; set; }

        [Required]
        [Column("streaming_status")]
        public bool IsStreaming { get; set; }

        [Required]
        [Column("at_fetch")]
        public DateTime FetchedAt { get; set; }

        [Required]
        [Column("at_expire")]
        public DateTime ExpireAt { get; set; }

        public override bool Equals(object obj)
            => Equals(obj as TowicchoSubscription);

        public bool Equals([AllowNull] TowicchoSubscription other)
        {
            return other != null &&
                   base.Equals(other) &&
                   ID == other.ID &&
                   TwitchID == other.TwitchID &&
                   IsStreaming == other.IsStreaming &&
                   FetchedAt == other.FetchedAt &&
                   ExpireAt == other.ExpireAt;
        }

        public override int GetHashCode()
            => HashCode.Combine(base.GetHashCode(), ID, TwitchID, IsStreaming, FetchedAt, ExpireAt);

        public static bool operator ==(TowicchoSubscription left, TowicchoSubscription right)
            => EqualityComparer<TowicchoSubscription>.Default.Equals(left, right);

        public static bool operator !=(TowicchoSubscription left, TowicchoSubscription right)
            => !(left == right);
    }
}
