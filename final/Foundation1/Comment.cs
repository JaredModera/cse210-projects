using System;

public class Comment
{
    // Member variables
    public string _name;
    public string _text;

    public void DisplayCommentDetails()
    {
        Console.WriteLine($"{_name}: \n| {_text} |\n");
    }
}