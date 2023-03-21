using System;

namespace Activities
{
    public class Activities
    {
        // private string _menu;
       private string _name;
        private string _description;
        private string _duration;


        // public Activities(string menu)
        // {
        //     _menu = menu;

        // }
        // public string GetMenu()
        // {
        //     return _menu;

        // }

         public Activities(string name)
        {
            _name = name;

        }

         public Activities.Activities(string description)
        {
            _description = description;

        }


        public string GetName()
        {
            return _name;

        }

    }


}