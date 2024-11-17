using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> Entries;

    public Journal()
    {
        Entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        Entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in Entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (var entry in Entries)
                {
                    writer.WriteLine($"{entry.GetDate()}|{entry.GetPromptText()}|{entry.GetEntryText()}");
                }
            }
            Console.WriteLine("Saved successfully!");
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error saving journal: " + ex.Message);
        }
    }
    public void LoadFromFile(string file)
    {
        try
        {
            string[] lines = File.ReadAllLines(file);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry(parts[0], parts[1], parts[2]);
                    Entries.Add(entry);
                }
            }
            Console.WriteLine("Journal loaded.");
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Error loading file: " + ex.Message);
        }
    }
}
