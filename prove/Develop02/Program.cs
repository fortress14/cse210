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

        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        

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
                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToString("MM-dd-yyyy");
                newEntry._promptText = promptGenerator.GetRandomPrompt();

                Console.WriteLine($"Prompt: {newEntry._promptText}");
                newEntry._entryText = Console.ReadLine();

                theJournal.AddEntry (newEntry);
            }
            else if (choice == "2")
            {
                theJournal.DisplayAll();
                
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                string loadFileName = Console.ReadLine();
                theJournal.LoadFromFile(loadFileName);

            }
            else if (choice =="4")
            {
               Console.Write("Enter the filename to save: ");
               string saveFileName = Console.ReadLine();
               theJournal.SaveToFile(saveFileName);

            }
            else if (choice == "5")
            {
                Console.WriteLine("Exiting Journal!");
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