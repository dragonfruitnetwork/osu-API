using System;
using System.Collections.Generic;
using System.Text;

namespace DragonFruit.osu.API
{
    public class osu
    {
        public static readonly string endpointBase = "https://osu.ppy.sh/p/api/";
        internal static string apiKey = "";

        /// <summary>
        /// Status codes that correspond to beatmap status
        /// </summary>
        public enum BeatmapStatus 
        {
            Loved = 4,
            Qualified = 3,
            Approved = 2,
            Ranked = 1,
            Pending = 0,
            WIP = -1,
            Graveyard = -2
        }


        /// <summary>
        /// Sets the API key for the rest of the app to use
        /// </summary>
        /// <param name="APIKey"></param>
        public static void SetAPIKey(string APIKey)
        {
            apiKey = APIKey;
            return;
        }
    }
}
