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
    };

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {
        
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

        return randomPrompt;
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