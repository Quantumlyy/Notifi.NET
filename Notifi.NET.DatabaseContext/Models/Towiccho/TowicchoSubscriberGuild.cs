using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Notifi.NET.DatabaseContext.Models.Towiccho
{
    class TowicchoSubscriberGuild : SubscriberGuildBase, IEquatable<TowicchoSubscriberGuild>
    {
        [Key]
        [Required]
        [Column("id")]
        public long ID { get; set; }

        [Required]
        [Column("game_whitelist")]
        public List<string> GameWhitelist { get; set; }

        [Required]
        [Column("game_blacklist")]
        public List<string> GameBlacklist { get; set; }

        [Required]
        [Column("notification_offline")]
        public bool NotificationOffline { get; set; }

        public override bool Equals(object obj)
            => Equals(obj as TowicchoSubscriberGuild);

        public bool Equals([AllowNull] TowicchoSubscriberGuild other)
        {
            return other != null &&
                   base.Equals(other) &&
                   ID == other.ID &&
                   EqualityComparer<List<string>>.Default.Equals(GameWhitelist, other.GameWhitelist) &&
                   EqualityComparer<List<string>>.Default.Equals(GameBlacklist, other.GameBlacklist) &&
                   NotificationOffline == other.NotificationOffline;
        }

        public override int GetHashCode()
            => HashCode.Combine(base.GetHashCode(), ID, GameWhitelist, GameBlacklist, NotificationOffline);

        public static bool operator ==(TowicchoSubscriberGuild left, TowicchoSubscriberGuild right)
            => EqualityComparer<TowicchoSubscriberGuild>.Default.Equals(left, right);

        public static bool operator !=(TowicchoSubscriberGuild left, TowicchoSubscriberGuild right)
            => !(left == right);
    }
}