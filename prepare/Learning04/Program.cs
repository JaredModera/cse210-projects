using System;

class Program
{
    static void Main(string[] args)
    {
        Assingment Assing1 = new Assingment("Jared Modera","Mathematics");
        Console.WriteLine(Assing1.GetSummary());

        MathAssingment math1 = new MathAssingment("Jaredto Moderedto", "Fraciotnes", "7.3", "8-19");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssingment write1 = new WritingAssingment("Jagherd Modegha", "European History", "Tin Tin Adventures");
        Console.WriteLine(write1.GetSummary());
        Console.WriteLine(write1.GetWritingInformation());

    }
}