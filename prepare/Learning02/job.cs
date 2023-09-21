using System;

public class Job
{
    //stating the diferent member variables
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    //Display (always Capitalized)
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
    

}