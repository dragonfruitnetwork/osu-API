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

        /// <summary>
        /// Geki - combo = all 300s. Also used as the rainbow 300s in Mania (perfect)
        /// </summary>
        [JsonProperty("countgeki")]
        public int CountGeki { get; set; }

        [JsonProperty("count100")]
        public int Count100 { get; set; }

        /// <summary>
        /// acts as 200s in mania
        /// </summary>
        [JsonProperty("countkatu")]
        public int CountKatu { get; set; }

        [JsonProperty("count50")]
        public int Count50 { get; set; }

        [JsonProperty("countmiss")]
        public int Count0 { get; set; }

        [JsonProperty("enabled_mods")]
        public Enums.Mods Mods { get; set; }

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

        public Enums.Modes GameMode { get; set; }
    }
}
