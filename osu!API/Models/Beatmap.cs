using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DragonFruit.osu.API.Models
{
    public class Beatmap
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("approved")]
        public Enums.BeatmapStatus BeatmapStatus { get; set; }

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
        public float BPM { get; set; }

        [JsonProperty("creator")]
        public string Mapper { get; set; }

        [JsonProperty("difficultyrating")]
        public float StarValue { get; set; }

        [JsonProperty("diff_size")]
        public float CircleSize { get; set; }

        [JsonProperty("diff_overall")]
        public float OverallDifficulty { get; set; }

        [JsonProperty("diff_approach")]
        public float ApproachRate { get; set; }

        [JsonProperty("diff_drain")]
        public float DrainRate { get; set; }

        /// <summary>
        /// seconds from first note to last note including breaks
        /// </summary>
        [JsonProperty("hit_length")]
        public float SongNoteDuration { get; set; }

        [JsonProperty("version")]
        public string DifficultyName { get; set; }

        [JsonProperty("file_md5")]
        public string BeatmapHash { get; set; }

        [JsonProperty("mode")]
        public Enums.Modes GameMode { get; set; }

        [JsonProperty("tags")]
        public string TagList { get; set; }

        [JsonProperty("favourite_count")]
        public int FavouriteRating { get; set; }

        [JsonProperty("playcount")]
        public int PlayCount { get; set; }

        [JsonProperty("passcount")]
        public int PassCount { get; set; }

        [JsonProperty("max_combo")]
        public int MaxCombo { get; set; }
    }
}
