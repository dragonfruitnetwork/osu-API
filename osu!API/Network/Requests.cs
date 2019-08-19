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

            return JsonConvert.DeserializeObject<List<T>>(await new HttpClient().GetAsync(url).Result.Content.ReadAsStringAsync()); //get and parse into list

        }
    }
}
