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
            osu.SetAPIKey("212c6b9d6370f2ac4c07aafc5e234ca52691f754");
            var x = new RequestModel
            {
                User = "PaPaCurry",
                IsUserAnID = false
            };

            var y = await Requests.Make<User>(Endpoints.UserInfo, x); //make the request and serialise it to the User model
            Console.WriteLine(y[0].UserID); //print ID
        }
    }
}
