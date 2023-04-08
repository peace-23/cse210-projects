using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseTracker
{
    class CyclingActivity : Activity
    {
        private double _speed;

        public CyclingActivity(DateTime date, int length, double speed) : base(date, length)
        {
            this._speed = speed;
        }

        public override double GetSpeed()
        {
            return _speed;
        }

        public override double GetPace()
        {
            return 60.0 / _speed;
        }

        public override string GetSummary()
        {
            return $"{base.GetSummary()} - Speed: {_speed.ToString("F1")} kph, Pace: {GetPace().ToString("F1")} min per km";
        }
    }

}