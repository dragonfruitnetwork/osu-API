using DragonFruit.osu.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DragonFruit.osu.API.Accuracy
{
    public class Mania : Accuracy
    {
        public Mania(Score Score)
        {
            MaxPoints = 300 * (Score.Count0 + Score.Count50 + Score.Count100 + Score.CountGeki + Score.CountKatu + Score.Count300);
            EarnedPoints = (300 * (Score.Count300 + Score.CountGeki)) + (200 * Score.CountKatu) + (100 * Score.Count100) + (50 * Score.Count50);
        }
    }
}
