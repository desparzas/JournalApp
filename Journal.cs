using System;
using System.Collections.Generic;
using System.IO;

public class Journal {
    private List<Entry> entries;

    public Journal() {
        entries = new List<Entry>();
    }

    public void AddEntry(Entry entry) {
        entries.Add(entry);
    }

    public void DisplayAll() {
        foreach (var entry in entries) {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename) {
        using (StreamWriter writer = new StreamWriter(filename)) {
            foreach (var entry in entries) {
                writer.WriteLine(entry.ToString());
            }
        }
    }

    public void LoadFromFile(string filename) {
        entries.Clear();
        try {
            using (StreamReader reader = new StreamReader(filename)) {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        entries.Add(new Entry(parts[1].Trim(), parts[2].Trim()) { _date = parts[0].Trim() });
                    }
                }
            }
        }
        catch (FileNotFoundException) {
            Console.WriteLine("The file could not be found.");
        }
    }
}
