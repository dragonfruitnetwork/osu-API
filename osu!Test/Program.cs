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
            osu.SetAPIKey(args.Length>0? args[0] :Environment.GetEnvironmentVariable("osuAPI", EnvironmentVariableTarget.Machine));

            //username test
            var user = await Requests.Make<User>(Endpoints.UserInfo, new RequestModel
            {
                User = "13723332",
                IsUserAnID = true
            }); //make the request and serialise it to the User model
            Console.WriteLine("Test 1: Get User Info: "+ user[0].Username+" (SUCCESS)");

            //recent osu beatmaps
            var maps = await Requests.Make<Beatmap>(Endpoints.BeatmapInfo, new RequestModel
            {
                Limit = 50,
                Mode = osu.GameModes.osu,
                IncludeConvertedMaps = false,

            }); //make the request and serialise it to the User model
            Console.WriteLine("Test 2: Get 50 Beatmaps: " + maps.Count + " listed");

            //get top scores from ADAMAS Monstrata's Insane (1799100)
            var adamas = await Requests.Make<Score>(Endpoints.BeatmapScores, new RequestModel
            {
                Beatmap = "1799100",
                User = "13723332",
                IsUserAnID = true
            }); //make the request and serialise it to the User model
            Console.WriteLine($"Test 3: Get {user[0].Username}'s Best score at [ADAMAS Monstrata's Insane] {adamas[0].PlayerScore:n0} points");

            //recent osu beatmaps
            var best = await Requests.Make<Score>(Endpoints.UserBestPerformance, new RequestModel
            {
                Limit = 50,
                Mode = osu.GameModes.osu,
                User = user[0].UserID.ToString(),
                IsUserAnID = true

            }); //make the request and serialise it to the User model
            Console.WriteLine("Test 4: Get"+user[0].Username+"'s Best Performances: " + best.Count + " found");
        }
    }
}
