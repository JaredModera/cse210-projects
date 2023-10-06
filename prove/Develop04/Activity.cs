using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine($"{_description}");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine($"You have completed another {_duration} of the {_name} Activity");
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(seconds);
        int i = 0;
        
        while (DateTime.Now < endTime)
        {
            string a = animationString[i];
            Console.Write(a);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;

            if (i >= animationString.Count)
            {
                i = 0;
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }
}