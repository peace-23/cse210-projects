

using System;
using System.Collections.Generic;
using System.Text;


namespace Develop05
{
    class ChecklistGoal : Goal
    {
        private List<string> _checklist;
        private int cCount;

        public ChecklistGoal(string name, string description, int value, bool complete = false) : base(name, description, value, complete)
        {
            _checklist = new List<string>();
        }

        public ChecklistGoal(string name, string description, int value, bool complete = false, int cCount = 0) : this(name, description, value, complete)
        {
            this.cCount = cCount;
        }

        public override string GetStringRepresentation()
        {
            string checklist = String.Join(",", _checklist);
            return $"ChecklistGoal:{_name}~{_description}~{_value}~{Complete}~{checklist}";
        }

        public override void DisplayEntry()
        {
            Console.WriteLine($"{_name}: {_description} ({_value} points)");
            Console.WriteLine("Checklist:");
            foreach (string item in _checklist)
            {
                Console.WriteLine($"- {item}");
            }
        }

        public override int GetPoints()
        {
            if (Complete)
            {
                return _value;
            }
            else
            {
                return 0;
            }
        }

        public void AddItem(string item)
        {
            _checklist.Add(item);
        }

        public void RemoveItem(string item)
        {
            _checklist.Remove(item);
        }

        public void MarkItemComplete(string item)
        {
            if (_checklist.Contains(item))
            {
                _checklist.Remove(item);
                if (_checklist.Count == 0)
                {
                    base.MarkComplete();
                }
            }
            else
            {
                Console.WriteLine($"Item \"{item}\" not found in checklist.");
            }
        }

        public bool IsItemComplete(string item)
        {
            return !_checklist.Contains(item);
        }

        internal void RecordProgress(int v)
        {
            throw new NotImplementedException();
        }
    }
}
