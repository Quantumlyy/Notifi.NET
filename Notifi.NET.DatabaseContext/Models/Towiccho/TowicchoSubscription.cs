using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Notifi.NET.DatabaseContext.Models.Towiccho
{
    class TowicchoSubscription : IEquatable<TowicchoSubscription>
    {
        [Key]
        [Required]
        [Column("id")]
        public long ID { get; set; }

        [Required]
        [Column("twitch_id")]
        public string TwitchID { get; set; }

        [Required]
        [Column("guilds")]
        public List<TowicchoSubscriberGuild> Guilds { get; set; }

        [Required]
        [Column("streaming_status")]
        public bool IsStreaming { get; set; }

        [Required]
        [Column("at_creat")]
        public DateTime CreatedAt { get; set; }

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
                   ID == other.ID &&
                   TwitchID == other.TwitchID &&
                   EqualityComparer<List<TowicchoSubscriberGuild>>.Default.Equals(Guilds, other.Guilds) &&
                   IsStreaming == other.IsStreaming &&
                   CreatedAt == other.CreatedAt &&
                   FetchedAt == other.FetchedAt &&
                   ExpireAt == other.ExpireAt;
        }

        public override int GetHashCode()
            => HashCode.Combine(ID, TwitchID, Guilds, IsStreaming, CreatedAt, FetchedAt, ExpireAt);

        public static bool operator ==(TowicchoSubscription left, TowicchoSubscription right)
            => EqualityComparer<TowicchoSubscription>.Default.Equals(left, right);

        public static bool operator !=(TowicchoSubscription left, TowicchoSubscription right)
            => !(left == right);
    }
}
