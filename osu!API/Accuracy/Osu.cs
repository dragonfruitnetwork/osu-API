using DragonFruit.osu.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DragonFruit.osu.API.Accuracy
{
    public class Osu : Accuracy
    {
        public Osu(Score Score)
        {
            MaxPoints = 300 * (Score.Count0 + Score.Count50 + Score.Count100 + Score.Count300);
            EarnedPoints = (300 * Score.Count300) + (100 * Score.Count100) + (50 * Score.Count50);
        }
    }
}
