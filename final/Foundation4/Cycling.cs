using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation4
{
    class Cycling : Activity
    {
        private double _speed;

        public Cycling(
            string date,
            int minutes,
            double speed
        ) : base(date,minutes)
        {
            _speed = speed;
        }

        protected override double getPace()
        {
            return getMinutes() / getDistance();
        }

        protected override double getDistance()
        {
            return (_speed * getMinutes()) / 60;
        }

        public override string getSummary() {
            double pace = Math.Round(getPace(),2);
            double distance = Math.Round(getDistance(),2);
            return $"{getDate()} Cycling ({getMinutes()} min)- Distance {distance} miles, Speed {Math.Round(_speed,2)} mph, Pace: {pace} min per mile";
        }  
    }
}