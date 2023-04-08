using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation4
{
    class Activity
    {
        private string _date;
        private int _minutes;
        public Activity(
            string date,
            int minutes
        ) 
        {
            _date = date;
            _minutes = minutes;
        }

        protected int getMinutes()
        {
            return _minutes;
        }

        protected string getDate()
        {
            return _date;
        }

        protected virtual double getDistance()
        {
            return new double();
        }

        protected virtual double getSpeed()
        {
            return new double();
        }

        protected virtual double getPace()
        {
            return new double();
        }

        public virtual string getSummary()
        {
            return $"{_date} Running ({_minutes} min)- Distance {0} miles, Speed {0} mph, Pace: {0} min per mile";
        }


    }
}
