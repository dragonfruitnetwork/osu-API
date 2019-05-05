using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DragonFruit.osu.API.Models
{
    public class Beatmap
    {
        [JsonProperty("approved")]
        public osu.BeatmapStatus BeatmapStatus { get; set; }

        [JsonProperty("approved_date")]
        public DateTime ApprovedDate { get; set; }

        [JsonProperty("last_update")]
        public DateTime LastUpdated { get; set; }

        [JsonProperty("artist")]
        public string ArtistName { get; set; }

        [JsonProperty("beatmap_id")]
        public int BeatmapID { get; set; }

        [JsonProperty("beatmapset_id")]
        public int BeatmapSetID { get; set; }

        [JsonProperty("bpm")]
        public int BPM { get; set; }

        [JsonProperty("creator")]
        public string Mapper { get; set; }

        [JsonProperty("difficultyrating")]
        public float StarValue { get; set; }
    }
}
