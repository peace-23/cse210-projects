
using System;
using System.Collections.Generic;
using System.Text;


namespace Develop05
{
    public abstract class Goal
    {
        private bool _complete;

        protected string _name;
        protected string _description;
        protected int _value;

        public bool Complete
        {
            get { return _complete; }
        }

        public Goal(string name, string description, int value, bool complete = false)
        {
            _name = name;
            _description = description;
            _value = value;
            _complete = complete;
        }

        public virtual int GetPoints()
        {
            if (_complete)
            {
                return _value;
            }
            else
            {
                return 0;
            }
        }

        public virtual string GetStringRepresentation()
        {
            string StringRepresentation = $"Goal:{_name}~{_description}~{_value}~{_complete}";
            return StringRepresentation;
        }

        public virtual void MarkComplete()
        {
            if (!_complete)
            {
                _complete = true;
                Console.WriteLine($"Congratulations! You have completed the {_name} goal and earned {_value} points.");
            }
        }

        public virtual void DisplayEntry()
        {
            if (_complete)
            {
                Console.WriteLine($"[x] {_name}: {_description} - Completed!");
            }
            else
            {
                Console.WriteLine($"[ ] {_name}: {_description}");
            }
        }

        public string GetName()
        {
            return _name;
        }

        public string GetDescription()
        {
            return _description;
        }
    }
}
