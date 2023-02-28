using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userValue = Console.ReadLine();
        int percent = int.Parse(userValue);

        string letter = "";

        int gradeScale;
        gradeScale =  percent % 10;

        string sign;
        sign = "";


        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (gradeScale >= 7)
        {
            sign = "+";
        }
        else if (gradeScale < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }        

        if (letter == "A" && sign == "+")
        {
            sign = "";
        }
        if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");
        
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations, You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }


    }
}