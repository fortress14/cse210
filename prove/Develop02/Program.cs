using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Test Code
       // Entry e = new Entry();
        //e._date = "1/1/2025";
        //e._promptText ="How are you feeling?";
        //e._entryText = "Everything is awesome!";
        //e.Display();




        Console.WriteLine("Welcome to the Journal Program!");
        String choice;
        do
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                PromptGenerator _prompts = new PromptGenerator();
                //string _prompts = PromptGenerator.GetRandomPrompt();
                Journal theJournal = new Journal();
                Entry anEntry = new Entry();
                theJournal.AddEntry (anEntry);
                anEntry.Display();

            
            }
            else if (choice == "2")
            {
                
            }
            else if (choice == "3")
            {

            }
            else if (choice =="4")
            {

            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye");
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
            Console.WriteLine();
        }
        while (choice!= "5");

    }
}