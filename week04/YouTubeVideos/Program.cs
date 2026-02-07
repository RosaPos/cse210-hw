using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("Learn C#", "Rosa Posadas", 120);
        v1.AddComment(new Comment("Juana", "Wonderful video!"));
        v1.AddComment(new Comment("Jose", "I liked it so much."));
        v1.AddComment(new Comment("Maria", "Thanks for sharing!"));

        List<Video> videos = new List<Video>();
        videos.Add(v1);

        foreach (Video v in videos)
        {
            v.Display();
        }
    }
}
