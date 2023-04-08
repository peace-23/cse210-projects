using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseTracker
{
    class Activity
    {
        private DateTime _date;
        private int _length;

        public Activity(DateTime date, int length)
        {
            this._date = date;
            this._length = length;
        }

        public virtual double GetDistance()
        {
            return 0.0;
        }

        public virtual double GetSpeed()
        {
            return 0.0;
        }

        public virtual double GetPace()
        {
            return 0.0;
        }

        public virtual string GetSummary()
        {
            return $"{_date.ToString("dd MMM yyyy")} {this.GetType().Name} ({_length} min)";
        }
    }
}
