using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        string strNumber = Console.ReadLine();
        int intNumber = int.Parse(strNumber);

        string letter = "";

        if (intNumber >= 90) {
            letter = "A";
        } 
        else if (intNumber >= 80) {
            letter = "B";
        } 
        else if (intNumber >= 70) {
            letter = "C";
        } 
        else if (intNumber >= 60) {
            letter = "D";
        } 
        else if (intNumber < 60) {
            letter = "F";
        } 

        Console.WriteLine($"Your grade is {letter}. ");

        if (intNumber >= 70) {
            Console.WriteLine("Congratulations, you have passed. :)");
        }
        else {
            Console.WriteLine("You did not pass, keep the efort and next time you will make it. :)");
        }
    }
}