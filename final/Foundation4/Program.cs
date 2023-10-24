using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> actList = new List<Activity>();

        Running run1 = new Running();

        Bicycle bic1 = new Bicycle();

        Swimming swi1 = new Swimming();

        actList.Add(run1);
        actList.Add(bic1);
        actList.Add(swi1);

        foreach (Activity acticity in actList)
        {
            acticity.GetSummary();
        }
    }
}