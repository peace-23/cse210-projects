using System;



namespace Develop05
{
    class EternalQuest : Goal
    {
        private List<Goal> _goals;

        public EternalQuest(string name, string description, int value, bool complete = false) : base(name, description, value, complete)
        {
            _goals = new List<Goal>();
        }

        public EternalQuest()
        {
           
        }

        public void AddGoal(Goal goal)
        {
            _goals.Add(goal);
        }

        public void RemoveGoal(string name)
        {
            Goal goalToRemove = null;
            foreach (Goal goal in _goals)
            {
                if (goal.GetName() == name)
                {
                    goalToRemove = goal;
                    break;
                }
            }

            if (goalToRemove != null)
            {
                _goals.Remove(goalToRemove);
                Console.WriteLine($"Goal '{name}' has been removed.");
            }
            else
            {
                Console.WriteLine($"Goal '{name}' not found.");
            }
        }

        public void DisplayAllGoals()
        {
            Console.WriteLine($"{this.GetName()} - {this.GetDescription()}: {this.GetValue()} points");

            foreach (Goal goal in _goals)
            {
                goal.DisplayEntry();
            }
        }

        private object GetValue()
        {
            throw new NotImplementedException();
        }

        public void LoadGoals(string filename)
        {
            try
            {
                string[] lines = File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] tokens = line.Split(':');
                    string goalType = tokens[0];
                    string[] values = tokens[1].Split('~');

                    switch (goalType)
                    {
                        case "SimpleGoal":
                            string name = values[0];
                            string description = values[1];
                            int value = int.Parse(values[2]);
                            bool complete = bool.Parse(values[3]);
                            int progress = int.Parse(values[4]);
                            SimpleGoal simpleGoal = new SimpleGoal(name, description, value, complete);
                            simpleGoal.RecordProgress(progress);
                            AddGoal(simpleGoal);
                            break;
                        case "EternalGoal":
                            string eName = values[0];
                            string eDescription = values[1];
                            int eValue = int.Parse(values[2]);
                            bool eComplete = bool.Parse(values[3]);
                            EternalGoal eternalGoal = new EternalGoal(eName, eDescription, eValue, eComplete);
                            AddGoal(eternalGoal);
                            break;
                        case "ChecklistGoal":
                            string cName = values[0];
                            string cDescription = values[1];
                            int cValue = int.Parse(values[2]);
                            bool cComplete = bool.Parse(values[3]);
                            int cCount = int.Parse(values[4]);
                            ChecklistGoal checklistGoal = new ChecklistGoal(cName, cDescription, cValue, cComplete, cCount);
                            checklistGoal.RecordProgress(int.Parse(values[5]));
                            AddGoal(checklistGoal);
                            break;
                        default:
                            Console.WriteLine($"Unknown goal type '{goalType}' in file.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading goals from file: {ex.Message}");
            }
        }

        public void SaveGoals(string filename)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (Goal goal in _goals)
                    {
                        writer.WriteLine(goal.GetStringRepresentation());
                    }
                }
                Console.WriteLine("Goals saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving goals to file: {ex.Message}");
            }
        }

        internal IEnumerable<string> GetGoals()
        {
            throw new NotImplementedException();
        }

        internal void AddGoal(string goal)
        {
            throw new NotImplementedException();
        }
    }
}

