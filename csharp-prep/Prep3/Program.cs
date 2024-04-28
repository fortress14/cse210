using System;

class Program
{
    static void Main(string[] args)
    {

        //Console.Write("What is the magic number? ");
        //string magicNumber = Console.ReadLine();
        //int num = int.Parse(magicNumber);

        Random randomGenerator = new Random();
        int num =randomGenerator.Next(1, 100);

        int guess = -1;

        while (guess != num)
        {
            Console.Write("What is your guess? ");
            string guessNumber = Console.ReadLine();
            guess = int.Parse(guessNumber);

            if (guess < num)
            {
                Console.WriteLine ("Higher");
            }
            else if (guess > num)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }
    
    }
}