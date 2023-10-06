using System;

public class ListingActivity : Activity
{
    //menber vairiables
    protected int _count = 0;
    protected List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "What are you afraid of loosing?",
        "Who are you afraid of loosing?",
        "Which are feelings/emotions that you have pretty often" 
        //here i was experimenting to know wich way of defining the list is better
    };

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
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
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine(GetRandomPrompt());
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.WriteLine();

        List<string> userList = GetListFromUser();
        
        _count = userList.Count();

        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items!");
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
        // List<string> prompts = new List<string>();
        // prompts.Add("Who are people that you appreciate?");
        // prompts.Add("What are personal strengths of yours?");
        // prompts.Add("Who are people that you have helped this week?");
        // prompts.Add("When have you felt the Holy Ghost this month?");
        // prompts.Add("Who are some of your personal heroes?");
        // _prompts = prompts;

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 8);

        string randomPrompt = _prompts[number];

        return $" --- {randomPrompt} --- ";
    }
    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        
        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            
            userList.Add(response);
            // // Pauses the console until 
            // // the user presses enter key
            // Console.ReadLine(); 
        }
        return userList;
    }
}