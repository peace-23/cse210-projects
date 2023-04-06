// using System;

// namespace Develop06
// {
//     class EternalGoal : Goal
//     {
//         public EternalGoal(string name, string description, int value)
//             : base(name, description, value)
//         {
//         }

//         public override string GetStringRepresentation() =>
//             $"EternalGoal:{_name} | {_description} | {_value}";

//         public override void MarkComplete()
//         {
//             // Do nothing
//         }

//         public override void DisplayEntry()
//         {
//             Console.Write($"[ ] {_name}= {_description}");
//         }
//     }
// }


using System;
using System.Collections.Generic;
using System.Linq;


namespace Develop05
{
    class EternalGoal : Goal
    {

        public EternalGoal(string name, string description, int value) : base(name, description, value)
        {

        }

        public EternalGoal(string name, string description, int value, bool complete = false) : base(name, description, value, complete)
        {
        }

        public override string GetStringRepresentation()
        {
            string StringRepresentation = $"EternalGoal:{_name}~{_description}~{_value}";
            return StringRepresentation;
        }

        public override void MarkComplete()
        {
            // nothing
        }

        public override void DisplayEntry()
        {
            Console.Write($"[ ] {_name}= {_description}");
        }

    }
}