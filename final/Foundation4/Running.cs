using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation4
{
    class Running : Activity
    {
        private double _distance;

        public Running(
            string date,
            int minutes,
            double distance
        ) : base(date,minutes)
        {
            _distance = distance;
        }

        protected override double getPace()
        {
            return getMinutes() / _distance;
        }

        protected override double getSpeed()
        {
            return (_distance / getMinutes()) * 60;
        }

        public override string getSummary() {
            double pace = Math.Round(getPace(),2);
            double speed = Math.Round(getSpeed(),2);
            return $"{getDate()} Running {getMinutes()} (min)- Distance {Math.Round(_distance,2)} miles, Speed {speed} mph, Pace: {pace} min per mile";
        }  


    }
}