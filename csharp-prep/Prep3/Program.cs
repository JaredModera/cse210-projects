using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please Write the magic number: ");
        string answer = Console.ReadLine();
        int magicNumber = int.Parse(answer);
    
        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("Make a guess on the magic number: ");
            guess = int.Parse(Console.ReadLine()); //new way of converting learned.

            if (guess > magicNumber) {
            Console.WriteLine("Lower");
            }
            else if (guess < magicNumber) {
                Console.WriteLine("Higher");
            }
            else {
                Console.WriteLine("You guessed it!");
            }
    
        }

        
    }
}