using System;

public class Entry
{
    private string Date;
    private string PromptText;
    private string EntryText;

    public Entry(string date, string promptText, string entryText)
    {
        Date = date;
        PromptText = promptText;
        EntryText = entryText;
    }

    public string GetDate() => Date;
    public string GetPromptText() => PromptText;
    public string GetEntryText() => EntryText;

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"Response: {EntryText}");
    }
}
