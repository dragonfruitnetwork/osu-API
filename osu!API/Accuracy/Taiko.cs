using DragonFruit.osu.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DragonFruit.osu.API.Accuracy
{
    public class Taiko : AccuracyBase
    {
        public Taiko(Score Score)
        {
            RawData = Score;
            MaxPoints = RawData.Count300 = RawData.Count100 + RawData.Count0;
            EarnedPoints = RawData.Count300 + (.5 * RawData.Count100);
        }
    }
}
