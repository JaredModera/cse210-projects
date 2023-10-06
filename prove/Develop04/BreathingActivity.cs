using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Write("How Long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());


        Console.Clear();

        Console.WriteLine("Get ready");
        ShowSpinner(3);

        Console.WriteLine();

        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(_duration);

        while  (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown(4);

            Console.WriteLine();

            Console.Write("Now breathe out...");
            ShowCountDown(6);

            Console.WriteLine();
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);

        Console.WriteLine();//So many of these i wonder if theres a better way to get a blank line .-.

        DisplayEndingMessage();
        ShowSpinner(3);

        Console.Clear();
    }
}