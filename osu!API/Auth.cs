using System;
using System.Collections.Generic;
using System.Text;

namespace DragonFruit.osu.API
{
    public class Auth
    {
        internal static string apiKey = "";

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
