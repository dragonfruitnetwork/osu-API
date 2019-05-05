using System;
using System.Collections.Generic;
using System.Text;

namespace DragonFruit.osu.API.Network
{
    public class Endpoints
    {
        public static readonly string baseURL = "https://osu.ppy.sh/api";

        public static readonly string BeatmapInfo = $"{baseURL}/get_beatmaps";
        public static readonly string UserInfo = $"{baseURL}/get_user";
        public static readonly string BeatmapScores = $"{baseURL}/get_scores";
        public static readonly string UserBestPerformance = $"{baseURL}/get_user_best";
        public static readonly string UserRecentlyPlayed = $"{baseURL}/get_user_recent";
        public static readonly string MultiplayerStats = $"{baseURL}/get_match";
    }
}
