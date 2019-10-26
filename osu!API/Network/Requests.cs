using System.Collections.Generic;
using DragonFruit.osu.API.Models;
using Newtonsoft.Json;
using System.Globalization;
using System.IO;
using System.Net.Http;

namespace DragonFruit.osu.API.Network
{
    public class Requests
    {
        private const string UserAgent = "osu!API";

        public static readonly JsonSerializerSettings Parser = new JsonSerializerSettings
        {
            Culture = new CultureInfo("en-us"),
            NullValueHandling = NullValueHandling.Ignore,
            DateTimeZoneHandling = DateTimeZoneHandling.Utc
        };

        private static readonly JsonSerializer Serializer = JsonSerializer.Create(Parser);

        public static T Stream<T>(string uri)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.UserAgent.ParseAdd(UserAgent);

                using (Stream s = client.GetStreamAsync(uri).Result)
                using (StreamReader sr = new StreamReader(s))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    return Serializer.Deserialize<T>(reader);
                }

            }
        }

        public static List<T> Stream<T>(string endpoint, RequestModel m) => Stream<List<T>>(RequestModel.Compile(endpoint, m));
    }
}
