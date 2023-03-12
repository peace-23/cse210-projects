using System;
using System.Collections.Generic;
using System.Linq;

class DataStore
    {
        private List<Scripture> scriptures = new List<Scripture>();

        public void SaveScripture(Scripture scripture)
        {
            if (!scriptures.Contains(scripture))
            {
                scriptures.Add(scripture);
            }
        }
    }