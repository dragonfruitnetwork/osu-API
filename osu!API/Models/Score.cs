using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DragonFruit.osu.API.Models
{
    public class Score
    {
        [JsonProperty("score_id")]
        public long ID { get; set; }

        [JsonProperty("score")]
        public long PlayerScore { get; set; }

        [JsonProperty("username")]
        public string User { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("count300")]
        public int Count300 { get; set; }

        [JsonProperty("count100")]
        public int Count100 { get; set; }

        [JsonProperty("count50")]
        public int Count50 { get; set; }

        [JsonProperty("countmiss")]
        public int Count0 { get; set; }

        [JsonProperty("enabled_mods")]
        public osu.Mods Mods { get; set; }

        [JsonProperty("maxcombo")]
        public int MaxCombo { get; set; }

        [JsonProperty("perfect")]
        public bool Perfect { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("pp")]
        public float Points { get; set; }

        [JsonProperty("replay_available")]
        public bool IsReplayAvailable { get; set; }
    }
}
