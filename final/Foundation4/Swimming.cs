using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation4
{
    class Swimming : Activity
    {
        private double _laps;

        public Swimming(
            string date,
            int minutes,
            double laps
        ) : base(date,minutes)
        {
            _laps = laps;
        }

        protected override double getDistance()
        {
            return _laps * 50 / 1000 * 0.62;
        }

        protected override double getSpeed()
        {
            return (getDistance() / getMinutes()) * 60;
        }

        protected override double getPace()
        {
            return getMinutes() / getDistance();
        }

        public override string getSummary() {
            double pace = Math.Round(getPace(),2);
            double speed = Math.Round(getSpeed(),2);
            double distance = Math.Round(getDistance(),2);
            return $"{getDate()} Swimming ({getMinutes()} min)- Distance {distance} miles, Speed {speed} mph, Pace: {pace} min per mile";
        }  


    }
}