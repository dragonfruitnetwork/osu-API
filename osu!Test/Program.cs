﻿using System;
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
            Auth.SetAPIKey(args.Length>0? args[0] :Environment.GetEnvironmentVariable("osuAPI", EnvironmentVariableTarget.Machine));

            //username test
            var user = await Task.Run(() => Requests.Stream<User>(Endpoints.UserInfo, new RequestModel
            {
                User = "13723332",
                IsUserAnID = true
            })); //make the request and serialise it to the User model
            Console.WriteLine("Test 1: Get User Info: "+ user[0].Username+" (SUCCESS)");

            //recent osu beatmaps
            var maps = await Task.Run(() => Requests.Stream<Beatmap>(Endpoints.BeatmapInfo, new RequestModel
            {
                Limit = 50,
                Mode = DragonFruit.osu.API.Enums.Modes.osu,
                IncludeConvertedMaps = false,

            })); //make the request and serialise it to the maps model
            Console.WriteLine("Test 2: Get 50 Beatmaps: " + maps.Count + " listed");

            //get top scores from ADAMAS Monstrata's Insane (1799100)
            var adamas = await Task.Run(() => Requests.Stream<Score>(Endpoints.BeatmapScores, new RequestModel
            {
                Beatmap = "1799100",
                User = "13723332",
                IsUserAnID = true
            })); //make the request and serialise it to the score model
            Console.WriteLine($"Test 3: Get {user[0].Username}'s Best score at [ADAMAS Monstrata's Insane] {adamas[0].PlayerScore:n0} points");

            //recent osu beatmaps
            var best = await Task.Run(() => Requests.Stream<Score>(Endpoints.UserBestPerformance, new RequestModel
            {
                Limit = 50,
                Mode = DragonFruit.osu.API.Enums.Modes.osu,
                User = user[0].UserID.ToString(),
                IsUserAnID = true

            })); //make the request and serialise it to the Scoring model
            Console.WriteLine("Test 4: Get"+user[0].Username+"'s Best Performances: " + best.Count + " found");
        }
    }
}
