using DragonFruit.osu.API.Models;

namespace DragonFruit.osu.API.Accuracy
{
    public class AccuracyBase
    {
        public Score RawData { get; set; }

        public double MaxPoints { get; set; }
        public double EarnedPoints { get; set; }

        public double Percentage
        {
            get
            {
                return EarnedPoints / MaxPoints * 100;
            }
        }

    }
}
