using System;

class Program
{
    static void Main(string[] args)
    {
        Activity act = new Activity("Jare", "aqui se salua", 30);
        // act.DisplayStartingMessage();
        // act.ShowSpinner(10);
        // act.ShowCountDown(5);
        // act.DisplayEndingMessage();

        // BreathingActivity act = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing", 15);

        ListingActivity act1 = new ListingActivity("Listing", "List the responses in this activity", 20);
        act1.DisplayStartingMessage();
        act1.ShowSpinner(2);
        Console.WriteLine(act1.GetRandomPrompt());
        act1.ShowCountDown(5);
        act1.GetListFromUser();
        act1.DisplayEndingMessage();

    }
}