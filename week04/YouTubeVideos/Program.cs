using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of videos
        var video1 = new Video("Learning C#", "Tech Guru", 600);
        var video2 = new Video("Mastering Design Patterns", "Dev Academy", 1200);
        var video3 = new Video("Understanding OOP", "Code Explained", 900);

        // Add comments to Video 1
        video1.AddComment(new Comment("Alice", "This was super helpful!"));
        video1.AddComment(new Comment("Bob", "Great explanation."));
        video1.AddComment(new Comment("Charlie", "I learned so much, thank you!"));

        // Add comments to Video 2
        video2.AddComment(new Comment("David", "Loved the examples."));
        video2.AddComment(new Comment("Eva", "Clear and concise."));
        video2.AddComment(new Comment("Frank", "Design patterns made easy!"));

        // Add comments to Video 3
        video3.AddComment(new Comment("Grace", "Now I understand OOP better."));
        video3.AddComment(new Comment("Hannah", "Great visuals!"));
        video3.AddComment(new Comment("Ian", "Looking forward to more videos."));

        // Store videos in a list
        var videos = new List<Video> { video1, video2, video3 };

        // Iterate through the list of videos and display information
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}
