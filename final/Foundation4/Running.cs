using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseTracker
{
    class RunningActivity : Activity
    {
        private double _distance;
        private double _length;

        public RunningActivity(DateTime date, int length, double distance) : base(date, length)
        {
            this._distance = distance;
            this._length = length;
        }

        public override double GetDistance()
        {
            return _distance;
        }

        public override double GetSpeed()
        {
            return (_distance / _length) * 60.0;
        }

        public override double GetPace()
        {
            return _length / _distance;
        }

        public override string GetSummary()
        {
            return $"{base.GetSummary()} - Distance {_distance} miles, Speed {GetSpeed().ToString("F1")} mph, Pace: {GetPace().ToString("F1")} min per mile";
        }
    }
}