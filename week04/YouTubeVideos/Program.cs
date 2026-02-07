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

        Video v2 = new Video("Encapsulation Basics", "Rosa Posadas", 180);
        v2.AddComment(new Comment("Ana", "Very clear explanation."));
        v2.AddComment(new Comment("Luis", "Now I understand private fields."));
        v2.AddComment(new Comment("Karla", "Great examples!"));

        Video v3 = new Video("Lists in C#", "Rosa Posadas", 240);
        v3.AddComment(new Comment("Pedro", "Helpful practice."));
        v3.AddComment(new Comment("Sofia", "Nice pace."));
        v3.AddComment(new Comment("Dani", "Good tips!"));

        List<Video> videos = new List<Video>();
        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        foreach (Video v in videos)
        {
            v.Display();
        }
    }
}
