using System;

class Program
{
    static void Main(string[] args)
    {
       
        Console.Write("What is your grade percentage? ");
        string valueGrade = Console.ReadLine();
        int percentage = int.Parse(valueGrade);

        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");


        if (percentage >= 70)
        {
            Console.WriteLine("Good Job! You pass.");
        }
        else
        {
            Console.WriteLine("You can do it next time.");
        }


    }
}