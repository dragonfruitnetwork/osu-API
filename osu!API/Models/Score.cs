using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DragonFruit.osu.API.Models
{
    public class Score
    {
        [JsonProperty("beatmap_id")]
        public long BeatmapID { get; set; }
        
        [JsonProperty("score_id")]
        public long ScoreID { get; set; }

        [JsonProperty("score")]
        public long PlayerScore { get; set; }

        [JsonProperty("username")]
        public string User { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("count300")]
        public int Count300 { get; set; }

        [JsonProperty("countkatu")]
        public int CountKatu {get; set; }

        [JsonProperty("count100")]
        public int Count100 { get; set; }

        [JsonProperty("countgeki")]
        public int CountGeki { get; set; }

        [JsonProperty("count50")]
        public int Count50 { get; set; }

        [JsonProperty("countmiss")]
        public int Count0 { get; set; }

        [JsonProperty("enabled_mods")]
        public osu.Mods Mods { get; set; }

        [JsonProperty("maxcombo")]
        public int MaxCombo { get; set; }

        [JsonProperty("perfect")]
        public int Perfect { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("pp")]
        public float Points { get; set; }

        [JsonProperty("replay_available")]
        public int IsReplayAvailable { get; set; }
    }
}
