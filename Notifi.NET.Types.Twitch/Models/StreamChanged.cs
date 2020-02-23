using System;
using Newtonsoft.Json;

namespace Notifi.NET.Types.Twitch.Models
{
    /// <summary>
    /// Base result of a Twitch StreamChange action.
    /// </summary>
    public class StreamChanged
    {
        /// <summary>
        /// An array of returned data from Twitch.
        /// </summary>
        [JsonProperty("data")]
        public StreamChangedData[] Data { get; set; }
    }

    public class StreamChangedData
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("user_id")]
        public string UserID { get; set; }

        [JsonProperty("user_name")]
        public string Username { get; set; }

        [JsonProperty("game_id")]
        public string GameID { get; set; }

        [JsonProperty("community_ids")]
        public string[] CommunityIDs { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("viewer_count")]
        public int? ViewerCount { get; set; }

        [JsonProperty("started_at")]
        public DateTime StartedAt { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("thumbnail_url")]
        public Uri ThumbnailUrl { get; set; }
    }
}