using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace DragonFruit.osu.API.Models
{
    public class RequestModel
    {
        public string User { get; set; }
        public osu.GameModes Mode { get; set; }
        public int Limit { get; set; }
        public string MapHash { get; set; }
        public bool IncludeConvertedMaps { get; set; }
        public bool IsUserAnID { get; set; }
        public string BeatmapSet { get; set; }
        public string Beatmap { get; set; }
        public string BeatmapHash { get; set; }

        public static string Compile(string root,RequestModel model)
        {
            NameValueCollection queryString = System.Web.HttpUtility.ParseQueryString(string.Empty);
            queryString["k"] = osu.apiKey;
            queryString["u"] = model.User;
            queryString["limit"] = model.Limit.ToString();
            queryString["m"] = ((int)model.Mode).ToString();
            queryString["type"] = !model.IsUserAnID ? "string" : "id";
            queryString["s"] = model.BeatmapSet;
            queryString["b"] = model.Beatmap;
            queryString["h"] = model.BeatmapHash;
            queryString["a"] = model.IncludeConvertedMaps ? "1" : "0";

            NameValueCollection queryString2 = System.Web.HttpUtility.ParseQueryString(string.Empty);
            foreach (string key in queryString)
            {
                if (!string.IsNullOrEmpty(queryString[key]))
                    queryString2.Add(key, queryString[key]);
            }
            return $"{root}?{queryString2.ToString()}";
        }
    }
}
