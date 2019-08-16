using DragonFruit.osu.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DragonFruit.osu.API.Accuracy
{
    public class Osu : AccuracyBase
    {
        public Osu(Score Score)
        {
            RawData = Score;
            MaxPoints = 300 * (RawData.Count0 + RawData.Count50 + RawData.Count100 + RawData.Count300);
            EarnedPoints = (300 * RawData.Count300) + (100 * RawData.Count100) + (50 * RawData.Count50);
        }
    }
}
