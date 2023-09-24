using System;
using System.Diagnostics;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator pg = new PromptGenerator();
        Console.WriteLine(pg.GetRandomPrompt());
        

        Entry anEntry = new Entry();
        anEntry._entryText = Console.ReadLine();
        DateTime theCurrentTime = DateTime.Now;
        anEntry._date = theCurrentTime.ToShortDateString();
        
        
        
        anEntry.Display();
        
    }
}