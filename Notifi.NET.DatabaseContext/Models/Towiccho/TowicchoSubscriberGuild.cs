using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Notifi.NET.DatabaseContext.Models.Towiccho
{
    class TowicchoSubscriberGuild : IEquatable<TowicchoSubscriberGuild>
    {
        [Key]
        [Required]
        [Column("id")]
        public long ID { get; set; }

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
        [Column("game_whitelist")]
        public List<string> GameWhitelist { get; set; }

        [Required]
        [Column("game_blacklist")]
        public List<string> GameBlacklist { get; set; }

        [Required]
        [Column("notification_offline")]
        public bool NotificationOffline { get; set; }

        [Required]
        [Column("embed_hash")]
        public string EmbedHash { get; set; }

        [Required]
        [Column("language")]
        public Language Language { get; set; }

        public override bool Equals(object obj)
            => Equals(obj as TowicchoSubscriberGuild);

        public bool Equals([AllowNull] TowicchoSubscriberGuild other)
        {
            return other != null &&
                   ID == other.ID &&
                   GuildID == other.GuildID &&
                   ChannelID == other.ChannelID &&
                   SubscribingUserID == other.SubscribingUserID &&
                   EqualityComparer<List<string>>.Default.Equals(GameWhitelist, other.GameWhitelist) &&
                   EqualityComparer<List<string>>.Default.Equals(GameBlacklist, other.GameBlacklist) &&
                   NotificationOffline == other.NotificationOffline &&
                   EmbedHash == other.EmbedHash &&
                   Language == other.Language;
        }

        public override int GetHashCode()
        {
            var hash = new HashCode();
            hash.Add(ID);
            hash.Add(GuildID);
            hash.Add(ChannelID);
            hash.Add(SubscribingUserID);
            hash.Add(GameWhitelist);
            hash.Add(GameBlacklist);
            hash.Add(NotificationOffline);
            hash.Add(EmbedHash);
            hash.Add(Language);
            return hash.ToHashCode();
        }

        public static bool operator ==(TowicchoSubscriberGuild left, TowicchoSubscriberGuild right)
            => EqualityComparer<TowicchoSubscriberGuild>.Default.Equals(left, right);

        public static bool operator !=(TowicchoSubscriberGuild left, TowicchoSubscriberGuild right)
            => !(left == right);
    }
}