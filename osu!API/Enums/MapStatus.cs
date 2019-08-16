using System;
using System.Collections.Generic;
using System.Text;

namespace DragonFruit.osu.API.Enums
{
    /// <summary>
    /// Status codes that correspond to beatmap status
    /// </summary>
    public enum BeatmapStatus
    {
        Loved = 4,
        Qualified = 3,
        Approved = 2,
        Ranked = 1,
        Pending = 0,
        WIP = -1,
        Graveyard = -2
    }

}
