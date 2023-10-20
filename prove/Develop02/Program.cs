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
        // DateTime theCurrentTime = DateTime.Now;
        // anEntry._date = theCurrentTime.ToShortDateString();
        anEntry._entryText = "ola";
        anEntry._date = "hoy xd";
        anEntry._promptText = "huh?";

        Journal jurnal = new Journal();
        jurnal.AddEntry(anEntry);
        jurnal.DisplayAll();
        
        
        
        anEntry.Display();
        
    }
}