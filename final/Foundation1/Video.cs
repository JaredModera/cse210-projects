using System;

public class Video
{
    // Member variables
    public string _title;
    public string _author;
    public double _length;
    public List<Comment> _comments = new List<Comment>();

    public int CommentsCount()
    {
        // int count = 0;
        // foreach (Comment coment in _comments)
        // {
        //     count++;
        // }
        // return count;
        return _comments.Count;
    }

    public void DisplayVideos()
    {
        Console.WriteLine($"Video Title: {_title} \n \nBy: {_author} \nDuration {_length} Minutes\n");
        Console.WriteLine($"{CommentsCount()} Comments: \n");

        foreach (Comment comment in _comments)
        {
            comment.DisplayCommentDetails();
        }
    }



}