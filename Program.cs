// Program.cs
using System;

public class Program {
    public static void Main(string[] args) {
        Journal journal = new Journal();
        PromptGenerator prompt = new PromptGenerator();

        while (true) {
            Console.Clear();
            Console.WriteLine("Journal Program");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice) {
                case "1":
                    string randomPrompt = prompt.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {randomPrompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    Entry entry = new Entry(randomPrompt, response);
                    journal.AddEntry(entry);
                    break;
                case "2":
                    journal.DisplayAll();
                    Console.WriteLine("\nPress any key to return to the menu.");
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Write("Enter filename to save the journal: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    Console.WriteLine("Journal saved successfully.");
                    Console.ReadKey();
                    break;
                case "4":
                    Console.Write("Enter filename to load the journal: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    Console.WriteLine("Journal loaded successfully.");
                    Console.ReadKey();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
