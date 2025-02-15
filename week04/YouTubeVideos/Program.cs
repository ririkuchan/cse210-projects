using System;
using System.Collections.Generic;
using YouTubeVideos;

class Program
{
    static void Main()
    {
        
        Video video1 = new Video("Learning C#", "John Doe", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));

        Video video2 = new Video("OOP Concepts", "Jane Smith", 750);
        video2.AddComment(new Comment("Charlie", "This made OOP so clear!"));

        
        List<Video> videos = new List<Video> { video1, video2 };
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}
