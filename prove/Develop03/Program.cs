using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            // add some sample scriptures
            library.AddScripture(new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."));
            library.AddScripture(new Scripture("Philippians 4:6-7", "Do not be anxious about anything, but in every situation, by prayer and petition, with thanksgiving, present your requests to God. And the peace of God, which transcends all understanding, will guard your hearts and your minds in Christ Jesus."));
            library.AddScripture(new Scripture("Psalm 23", "The Lord is my shepherd, I lack nothing. He makes me lie down in green pastures, he leads me beside quiet waters, he refreshes my soul. He guides me along the right paths for his name’s sake. Even though I walk through the darkest valley, I will fear no evil, for you are with me; your rod and your staff, they comfort me. You prepare a table before me in the presence of my enemies. You anoint my head with oil; my cup overflows. Surely your goodness and love will follow me all the days of my life, and I will dwell in the house of the Lord forever."));

            UserInterface.DisplayWelcomeMessage();

            while (true)
            {
                Scripture scripture = library.GetRandomScripture();

                UserInterface.DisplayScripture(scripture);

                if (UserInterface.ShouldQuit())
                {
                    break;
                }

                scripture.HideRandomWords();

                while (!scripture.AllWordsHidden())
                {
                    UserInterface.DisplayScripture(scripture);

                    if (UserInterface.ShouldQuit())
                    {
                        break;
                    }

                    scripture.HideRandomWords();
                }

                if (UserInterface.ShouldQuit())
                {
                    break;
                }
            }

            UserInterface.DisplayGoodbyeMessage();
        }
    }
}
