using System;

class Program
{
    static void Main(string[] args)
    {     
        string userChoice = "";

        while (userChoice != "4")
        {
            Console.Write("Menu Options \n1. Start breathing activity \n2. Start reflecting activity \n3. Start listing activity \n4. Quit \nSelect a choice from the menu: ");
            userChoice = Console.ReadLine();

            Console.Clear();

            if (userChoice == "1")
            {
                BreathingActivity breathing1 = new BreathingActivity();
                breathing1.Run();
            }

            else if (userChoice == "2")
            {
                ReflectingActivity reflet1 = new ReflectingActivity();
                reflet1.Run();
            }

            else if (userChoice == "3")
            {
                ListingActivity listing1 = new ListingActivity();
                listing1.Run();
            }

            else if (userChoice == "4")
            {
                Console.WriteLine("Thank you for taking this time to feel better. \nHave a nice day! :D");
                //Added this as an extra to give a more solid finish to the program
            }

            else {
                Console.Write($"-{userChoice}- is an invalid option. \nPlease try againg (press enter to continue): ");
                Console.ReadLine();
                Console.Clear();
                //Added this as an extra to kind of avoidong bugs o value errors. maybe someone just pressed the wrong number/key by mistake who knows
            }
        }
    }
}