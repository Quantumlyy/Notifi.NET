#pragma warning disable CS1591

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Notifi.NET.DatabaseContext.Models
{
    public class SubscriberGuildBase : IEquatable<SubscriberGuildBase>
    {
        [Required]
        [Column("guild_id")]
        public string GuildID { get; set; }

        [Required]
        [Column("channel_id")]
        public string ChannelID { get; set; }

        [Required]
        [Column("subscribing_user_id")]
        public string SubscribingUserID { get; set; }

        [Required]
        [Column("embed_hash")]
        public string EmbedHash { get; set; }

        [Required]
        [Column("language")]
        public Language Language { get; set; }

        public override bool Equals(object obj)
            => Equals(obj as SubscriberGuildBase);

        public bool Equals([AllowNull] SubscriberGuildBase other)
        {
            return other != null &&
                   GuildID == other.GuildID &&
                   ChannelID == other.ChannelID &&
                   SubscribingUserID == other.SubscribingUserID &&
                   EmbedHash == other.EmbedHash &&
                   Language == other.Language;
        }

        public override int GetHashCode()
            => HashCode.Combine(GuildID, ChannelID, SubscribingUserID, EmbedHash, Language);

        public static bool operator ==(SubscriberGuildBase left, SubscriberGuildBase right)
            => EqualityComparer<SubscriberGuildBase>.Default.Equals(left, right);

        public static bool operator !=(SubscriberGuildBase left, SubscriberGuildBase right)
            => !(left == right);
    }
}
