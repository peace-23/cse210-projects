
using System;
using System.Collections.Generic;
using System.Text;


namespace Develop05
{
    public class SimpleGoal : Goal
    {
        private int _progress;

        public SimpleGoal(string name, string description, int value, bool complete = false) : base(name, description, value, complete)
        {
            _progress = 0;
        }

        public override void MarkComplete()
        {
            base.MarkComplete();
            Console.WriteLine($"Congratulations! You have completed the {this._name} goal and earned {this._value} points.");
        }

        public override void DisplayEntry()
        {
            if (Complete)
            {
                Console.WriteLine($"[x] {_name}: {_description} - Completed!");
            }
            else
            {
                Console.WriteLine($"[ ] {_name}: {_description} - Progress: {_progress}");
            }
        }

        public void RecordProgress()
        {
            if (!Complete)
            {
                _progress++;
                if (_progress >= 1)
                {
                    Console.WriteLine($"Congratulations! You have made progress towards your {_name} goal.");
                }
                if (_progress == _value)
                {
                    base.MarkComplete();
                }
            }
        }

        public void RecordProgress(int progress)
        {
            if (!Complete)
            {
                _progress += progress;
                if (_progress >= 1)
                {
                    Console.WriteLine($"Congratulations! You have made progress towards your {_name} goal.");
                }
                if (_progress >= _value)
                {
                    base.MarkComplete();
                }
            }
        }
    }
}
