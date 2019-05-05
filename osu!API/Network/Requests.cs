using DragonFruit.osu.API.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DragonFruit.osu.API.Network
{
    public class Requests
    {
        public static async Task<List<T>> Make<T>(string Endpoint,RequestModel m)
        {
            string url = RequestModel.Compile(Endpoint, m); //compile the request url
            var JsonList = JArray.Parse(await new HttpClient().GetAsync(url).Result.Content.ReadAsStringAsync()); //get and parse into list

            List<T> SerailisedList = new List<T>();

            foreach (var x in JsonList)
                SerailisedList.Add(x.ToObject<T>(JsonSerializer.Create(new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore })));

            return SerailisedList;
        }
    }
}
