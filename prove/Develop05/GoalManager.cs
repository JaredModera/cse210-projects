using System;
using System.IO; 
using System.Net.NetworkInformation;

public class GoalManager
{
    // Member variables
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    // Constructor

    public GoalManager()
    {
        _score = 0;
    }

    // Methods
    public void Start()
    {
        string userChoice = "";

        while (userChoice != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine();

            Console.Write("--- Menu Options --- \n \n1. Create New Goal \n2. List Goals \n3. Save Goals \n4. Load Goals \n5. Record Event \n6. Quit \n \nSelect a choice from the menu: ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Console.Clear();

                Console.WriteLine("The types of goal are: \n \n1. Simple Goal \n2. Eternal Goal \n3. Checklist Goal \n");
                Console.Write("Which type of goal would you like to create?: ");
                string createChoice = Console.ReadLine();
                
                Console.Clear();
                if (createChoice == "1")
                {
                    Console.WriteLine("--- Creating Simple Goal ---\n");
                }
                if (createChoice == "2")
                {
                    Console.WriteLine("--- Creating Eternal Goal ---\n");
                }
                if (createChoice == "3")
                {
                    Console.WriteLine("--- Creating CheckList Goal ---\n");
                }

                CreateGoal(createChoice);
            }

            else if (userChoice == "2")
            {
                if (_goals.Count == 0)
                {
                    Console.Clear();
                    Console.WriteLine("--- Goals ---\n");
                    Console.WriteLine("This list is empty D: \n");

                }
                else if (_goals.Count > 0)
                {
                    ListGoalDetails();
                }
                
                Console.Write("\nPress enter to continue to menu (enter 1 if you want to hide the Goals): ");
                string miniChoice = Console.ReadLine();
                
                Console.WriteLine();

                if (miniChoice == "1")
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("___________________\n");
                }
            }

            else if (userChoice == "3")
            {
                Console.Clear();
                Console.WriteLine("--- Saving Goals ---\n");

                Console.Write("What is the filename for the goal file? (filename.txt): ");
                string fileName = Console.ReadLine();

                Console.WriteLine();
                
                SaveGoals(fileName);
            }

            else if (userChoice == "4")
            {
                Console.Write("What is the filename for the goal file? (filename.txt): ");
                string fileName = Console.ReadLine();

                LoadGoals(fileName);
            }
            
            else if (userChoice == "5")
            {
                RecordEvent();
            }

            else if (userChoice == "6")
            {
                Console.Clear();
                
                Console.WriteLine("See you soon! \nHave a nice day :D");
                Thread.Sleep(3000);

                Console.Clear();
            }

            else {
                Console.Clear();

                Console.Write($"-{userChoice}- is an invalid option. \n \nPlease try againg (press enter to continue): ");
                Console.ReadLine();

                Console.Clear();

                // This is a bug preventer in case the user enter an invalid value, it doesnt stop and it also tells the user what is wrong
            }
            

        }
    }
    public void DisplayPlayerInfo() 
    {
        Console.WriteLine($"Your score is: {_score}");
    } 
    public void ListGoalNames() 
    {

        // for (int index = 0; index < _goals.Count; index++)
        // {
        //     Console.WriteLine($"{index++}. {_goals[index].GetDetailsString()}");
        // }   
        // I just repeated the same code. cant find a way to get only the name of the goal??... 
    }
    public void ListGoalDetails() 
    {
        Console.Clear();
        Console.WriteLine("--- Goals ---\n");

        for (int index = 0; index < _goals.Count; index++)
        {
            Console.Write($"{index + 1}. ");
            Console.WriteLine(_goals[index].GetDetailsString());
        }
        
        Console.WriteLine();
    }
    public void CreateGoal(string createChoice) 
    {
            Console.Write("What is the name of your goal?: ");
            string goalName = Console.ReadLine();

            Console.Write("What is a short description of it?: ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal?: ");
            int points = int.Parse(Console.ReadLine());
            
            if (createChoice == "1")
            {
                /*The data type of _goals is List<Goal>. This means that we can put Goal objects 
                in the List. SimpleGoal, ChecklistGoal, and EternalGoal are all types of Goal 
                because of you inheritance. You don't need to call GetDetailsString to add it 
                to the list. 

                Just: _goals.Add(simpleGoal);*/
                _goals.Add(new SimpleGoal(goalName, description, points));

                Console.Clear();
                Console.WriteLine("-Simple Goal- Created!");
                Thread.Sleep(2000);
                Console.Clear();

            }
            else if (createChoice == "2")
            {
                _goals.Add(new EternalGoal(goalName, description, points));

                Console.Clear();
                Console.WriteLine("-EternalGoal- Created!");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else if (createChoice == "3")
            {
                Console.Write("How many times does this goal need to be accomplished for a bonus?: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times?: ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new CheckListGoal(goalName, description, points, target, bonus));

                Console.Clear();
                Console.WriteLine("-CheckListGoal- Created!");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.Clear();

                Console.WriteLine($"The -{createChoice}- is invalid.");
                Console.WriteLine("Please try again.");

                Thread.Sleep(2000);
                Console.Clear();
            }
    }
    public void RecordEvent() 
    {
        ListGoalDetails();

        Console.Write("Which goal did you accomplish?: \n");
        int userIndex = int.Parse(Console.ReadLine());

        // subtract 1 so it matches the inner list
        userIndex--; 
        if (userIndex < _goals.Count && userIndex >= 0)
        {
            Goal accomplishedGoal = _goals[userIndex];

            int points = accomplishedGoal.RecordEvent();

            _score += points;

            if (points > 0)
            {
                Console.Clear();
                Console.WriteLine($"Conratulations!! \nYou have earned {points} points!\n");
                Thread.Sleep(2500);
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("This goal has already been acomplished.\n");
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
    }
    public void SaveGoals(string fileName) 
    {
        // using (StreamWriter outputFile = new StreamWriter(fileName))
        // {
        //     // You can add text to the file with the WriteLine method
        //     outputFile.WriteLine("This will be the first line in the file.");
            
        //     // You can use the $ and include variables just like with Console.WriteLine
        //     string color = "Blue";
        //     outputFile.WriteLine($"My favorite color is {color}");
        // }
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            Console.WriteLine($"Saving {fileName}...");

            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }

            Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine($"Goals -{fileName}- Saved!!");

            Thread.Sleep(2500);

            Console.Clear();
        }
    }
    public void LoadGoals(string fileName) 
    {
        /*The easiest way to read a text file in C# is to read the entire file 
        into an array of strings (one per line) using the 
        System.IO.File.ReadAllLines() function. 
        Then, you can iterate through each string as you would with any list.*/
        _goals.Clear();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        if (lines.Length > 0)
        {
            if (int.TryParse(lines[0], out int score))
            {
                _score = score;
            }
        }

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");

            string type = parts[0];
            string shortName = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if (type == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(shortName, description, points);

                if (simpleGoal.IsComplete())
                {
                    simpleGoal.RecordEvent();
                }

                _goals.Add(simpleGoal);
            }

            else if (type == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(shortName, description, points);
                
                _goals.Add(eternalGoal);
            }
            else if (type == "CheckListGoal")
            {
                int bonus = int.Parse(parts[4]);
                
                int target = int.Parse(parts[5]);

                CheckListGoal checkListGoal = new CheckListGoal(shortName, description, points, target, bonus);

                checkListGoal.AmountComplete(int.Parse(parts[6]));
                
                _goals.Add(checkListGoal);
            }
        }
    }
}