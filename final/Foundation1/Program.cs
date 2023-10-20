using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        // Video 1
        Video vid1 = new Video();
        vid1._title = "Pentatonic Scale for Guitarr!";
        vid1._author = "Itadori Juji";
        vid1._length = 12.38;

        Comment comnt1 = new Comment();
        comnt1._name = "Ed Sherand";
        comnt1._text = "hahaha maybe I will use them.";
        Comment comnt2 = new Comment();
        comnt2._name = "Jimi Hendrix";
        comnt2._text = "You have some knowledge kid.";
        Comment comnt3 = new Comment();
        comnt3._name = "Eddie Van Halen";
        comnt3._text = "Thats what Im saying! hahaha";

        vid1._comments.Add(comnt1);
        vid1._comments.Add(comnt2);
        vid1._comments.Add(comnt3);

        // Video 2
        Video vid2 = new Video();
        vid2._title = "How to Get Stronger Arms";
        vid2._author = "Asta";
        vid2._length = 10.35;

        Comment comnt2_1 = new Comment();
        comnt2_1._name = "Ronnie Coleman";
        comnt2_1._text = "Yeah Buddy! Ligth Weigth!";
        Comment comnt2_2 = new Comment();
        comnt2_2._name = "Arnol Schwarzene";
        comnt2_2._text = "Ill be back when i need this.";
        Comment comnt2_3 = new Comment();
        comnt2_3._name = "Hugh Jackman";
        comnt2_3._text = "Nah, I got Claws for that.";

        vid2._comments.Add(comnt2_1);
        vid2._comments.Add(comnt2_2);
        vid2._comments.Add(comnt2_3);
        
        // Video 3
        Video vid3 = new Video();
        vid3._title = "Easy Way to Bend Metal!";
        vid3._author = "Ryan Gosling";
        vid3._length = 15.12;

        Comment comnt3_1 = new Comment();
        comnt3_1._name = "Metallica";
        comnt3_1._text = "This is not what I though it was gonna be...";
        Comment comnt3_2 = new Comment();
        comnt3_2._name = "Toph Beifong";
        comnt3_2._text = "You mean like metal bending? Thats to easy.";
        Comment comnt3_3 = new Comment();
        comnt3_3._name = "Colossus Rasputin";
        comnt3_3._text = "I see what you are trying to do... Ill be watching you -_-";

        vid3._comments.Add(comnt3_1);
        vid3._comments.Add(comnt3_2);
        vid3._comments.Add(comnt3_3);

        // Videos in _videos list
        _videos.Add(vid1);
        _videos.Add(vid2);
        _videos.Add(vid3);

        foreach (Video video in _videos)
        {
            video.DisplayVideos();
        }
    }
}