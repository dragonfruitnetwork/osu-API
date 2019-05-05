using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DragonFruit.osu.API.Network
{
    public class Requests
    {
        public static async Task<string> MakeRequest(string url)
        {
            return await new HttpClient().GetAsync(url).Result.Content.ReadAsStringAsync();
        }
    }
}
