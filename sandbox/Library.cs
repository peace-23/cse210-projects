// using System;
// using System.Collections.Generic;
// using System.Linq;

// public class Library
//     {
//         private List<Scripture> scriptures;

//         public Library()
//         {
//             scriptures = new List<Scripture>();
//             scriptures.Add(new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son, that whoever believes in him should not perish but have everlasting life."));
//             scriptures.Add(new Scripture(new Reference("Proverbs", 3, 5), "Trust in the Lord with all your heart, and lean not on your own understanding; in all your ways acknowledge Him, and He shall direct your paths."));
//             scriptures.Add(new Scripture(new Reference("Psalm", 23), "The Lord is my shepherd; I shall not want. He makes me to lie down in green pastures; He leads me beside the still waters. He restores my soul; He leads me in the paths of righteousness for His name's sake."));
//         }

//         public Scripture GetScripture(string reference)
//         {
//             foreach (Scripture scripture in scriptures)
//             {
//                 if (scripture.GetReference().ToString() == reference)
//                 {
//                     return scripture;
//                 }
//             }
//             return null;
//         }
//     }