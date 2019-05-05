using System;
using DragonFruit.osu.API;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using DragonFruit.osu.API.Models;
using System.Collections.Generic;
using Newtonsoft.Json;
using DragonFruit.osu.API.Network;

namespace osu_Test
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //var JsonString = await new HttpClient().GetAsync($"{osu.endpointBase}/get_user?k=212c6b9d6370f2ac4c07aafc5e234ca52691f754&u=13723332").Result.Content.ReadAsStringAsync();
            //var JsonList = JArray.Parse(JsonString);
            //List<User> Beatmaps = new List<User>();

            //foreach(var x in JsonList)
            //{
            //    Beatmaps.Add(x.ToObject<User>(JsonSerializer.Create(new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore })));
            //}

            //Console.WriteLine(JsonConvert.SerializeObject(Beatmaps, Formatting.Indented));

            osu.SetAPIKey("212c6b9d6370f2ac4c07aafc5e234ca52691f754");
            var x = new RequestModel
            {
                User = "PaPaCurry",
                IsUserAnID = false
            };

            Console.Write(RequestModel.Compile(Endpoints.UserInfo, x));
        }
    }
}
