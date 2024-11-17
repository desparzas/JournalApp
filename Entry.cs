// Entry.cs
using System;

public class Entry
{
    public string _date { get; set; }
    public string _promptText { get; set; }
    public string _entryText { get; set; }

    public Entry(string prompt, string response) {
        _date = DateTime.Now.ToString("yyyy-MM-dd");
        _promptText = prompt;
        _entryText = response;
    }

    public override string ToString() {
        return $"{_date} | {_promptText} | {_entryText}";
    }

    public void Display() {
        Console.WriteLine("Entry Date: " + _date);
        Console.WriteLine("Prompt: " + _promptText);
        Console.WriteLine("Response: " + _entryText);
    }
}
