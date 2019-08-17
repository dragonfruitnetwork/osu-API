using DragonFruit.osu.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DragonFruit.osu.API.Accuracy
{
    public class Taiko : Accuracy
    {
        public Taiko(Score Score)
        {
            MaxPoints = Score.Count300 = Score.Count100 + Score.Count0;
            EarnedPoints = Score.Count300 + (.5 * Score.Count100);
        }
    }
}
