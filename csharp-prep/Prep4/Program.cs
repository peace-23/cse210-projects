using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();        
        int userValue = -1;

        while (userValue != 0)
        {
            Console.Write("Enter a list of numbers, type 0 to quit: ");
            string userInput = Console.ReadLine();

            userValue = int.Parse(userInput);

            if (userValue != 0)
            {
                numbers.Add(userValue);
            }

        }

        int total = numbers.Count;
        Console.WriteLine($"total numbers: {total}");

        int sum = numbers.Sum();
        Console.WriteLine($"sum of the numbers: {sum}");

        float avarage = (float)sum / total;
        Console.WriteLine($"avarage of the numbers: {avarage}");

        int max = numbers.Max();
        Console.WriteLine($"biggest number of the numbers: {max}");



// // OR
//         // Part 1: Compute the sum
//         int sum = 0;
//         foreach (int number in numbers)
//         {
//             sum += number;
//         }

//         Console.WriteLine($"The sum is: {sum}");

//         // Part 2: Compute the average
//         // Notice that we first cast the sum variable to be a float. Otherwise, because
//         // both the sum and the count are integers, the computer will do integer division
//         // and I will not get a decimal value (even though it puts the result into a float variable).

//         // By making one of the variables a float first, the computer knows that it has to
//         // do the floating point division, and we get the decimal value that we expect.
//         float average = ((float)sum) / numbers.Count;
//         Console.WriteLine($"The average is: {average}");

//         // Part 3: Find the max
//         // There are several ways to do this, such as sorting the list
        
//         int max = numbers[0];

//         foreach (int number in numbers)
//         {
//             if (number > max)
//             {
//                 // if this number is greater than the max, we have found the new max!
//                 max = number;
//             }
//         }

//         Console.WriteLine($"The max is: {max}");
    

    }
}