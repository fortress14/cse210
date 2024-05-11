using System;
using System.IO;
using System.Collections.Generic;


public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
            return;
        }
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    
    public void SaveToFile(string file)
    {
        string fileName = "journal.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName)) 
        {
            foreach (Entry newEntry in _entries)
            outputFile.WriteLine($"{newEntry._date} : {newEntry._promptText} | {newEntry._entryText}");
        }
        
    }

    public void LoadFromFile(string file)
    {
        List<Entry> loadEntries = new List<Entry>();
        string filename = "journal.txt";
        
       string[] lines = System.IO.File.ReadAllLines(filename);

       foreach (string line in lines)
       {
        Console.WriteLine(line);
       }

    }
}