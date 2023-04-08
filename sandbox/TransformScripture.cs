// using System;
// using System.Collections.Generic;
// using System.Linq;

// public class TransformScripture
// {
//     public static string HideRandomWords(string text, int count)
//     {
//         string[] words = text.Split();
//         Random random = new Random();
//         HashSet<int> indices = new HashSet<int>();
//         while (indices.Count < count && indices.Count < words.Length)
//         {
//             indices.Add(random.Next(words.Length));
//         }
//         StringBuilder builder = new StringBuilder();
//         for (int i = 0; i < words.Length; i++)
//         {
//             if (indices.Contains(i))
//             {
//                 builder.Append(new string('*', words[i].Length));
//             }
//             else
//             {
//                 builder.Append(words[i]);
//             }
//             builder.Append(" ");
//         }
//         return builder.ToString().TrimEnd();
//     }
// }