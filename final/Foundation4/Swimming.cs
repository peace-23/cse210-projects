using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseTracker
{
    class SwimmingActivity : Activity
    {
        private int _laps;
        private double _length;

        public SwimmingActivity(DateTime date, int length, int laps) : base(date, length)
        {
            this._laps = laps;
            this._length = length;
        }

        public override double GetDistance()
        {
            return _laps * 50.0 / 1000.0;
        }

        public override double GetSpeed()
        {
            double durationInMinutes = (double)_length / 60.0;
            double speedInKph = GetDistance() / durationInMinutes;
            return speedInKph;
        }

        public override double GetPace()
        {
            return _length / GetDistance();
        }

        public override string GetSummary()
        {
            return $"{base.GetSummary()} - Distance {GetDistance().ToString("F1")} km, Speed: {GetSpeed().ToString("F1")} kph, Pace: {GetPace().ToString("F1")} min per mile";
        }
    }
}