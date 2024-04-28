using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        int numberValue = -1;

        while (numberValue != 0)
        {
            Console.Write("Enter number: ");
            string number = Console.ReadLine();
            numberValue = int.Parse(number);

            if (numberValue != 0)
            {
                numbers.Add(numberValue);
            }
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        float average = (float)sum / numbers.Count;
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine ($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");


    }
}