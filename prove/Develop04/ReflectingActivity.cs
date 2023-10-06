using System;

public class ReflectingActivity : Activity
{
    // member variables 
    protected List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else",
        "Think of a time when you did something really difficult",
        "Think of a time when you helped someone in need",
        "Think of a time when you did something truly selfless",
        "Think of a time when you rejected doing a bad thing"
        //here i was experimenting to know wich way of defining the list is better
    };
    protected List<string> _questions = new List<string>();

    // Constructor
    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        _questions = new List<string>{

            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
            //here i was experimenting to know wich way of defining the list is better
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Write("How Long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("Get ready");
        ShowSpinner(3);

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine(DisplayPrompt());

        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.WriteLine();
        Console.Clear();

        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(_duration);

        while  (DateTime.Now < endTime)
        {
            Console.Write($"> {DisplayQuestion()} ");
            ShowSpinner(15);

            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);

        Console.WriteLine();

        DisplayEndingMessage();
        ShowSpinner(3);

        Console.Clear();
    }

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int listCount = _prompts.Count();//experiment

        int number = randomGenerator.Next(1, listCount);//I made the listCount in case the length of the list changes i dont have to come back here to change it as well

        string randomPrompt = _prompts[number];

        return randomPrompt;
    }
    public string GetRandomQuestion()
    {
        Random randomGenerator = new Random();
        int listCount = _questions.Count();

        int number = randomGenerator.Next(1, listCount);//same

        string randomQuestion = _questions[number];

        return randomQuestion;
    }

    public string DisplayPrompt()
    {
        string prompt = GetRandomPrompt();

        return $" --- {prompt} --- ";
    }

    public string DisplayQuestion()
    {
        string question = GetRandomQuestion();

        return $"{question}";
        /*Here i wondered if i really needed the display function, 
        because i could just consol.write it  like in the listing activity*/
    }
}