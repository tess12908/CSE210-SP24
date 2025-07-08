using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        
        Video video1 = new Video("How to Sew", "Cathy Perterson", 600);
        video1.AddComment("Alice", "Great tutorial! On my way to become a professional!!");
        video1.AddComment("Charlie", "Can you make one for how to knit?");
        video1.AddComment("Anne", "WOW! You are so good at sewing! Thanks for sharing!");
        
        Video video2 = new Video("Baking 101", "Sara Khole", 1200);
        video2.AddComment("Dave", "Awesome explanations!");
        video2.AddComment("Eve", "I finally understand why I need baking Powder");
        video2.AddComment("Frank", "I am still confused");
        
        Video video3 = new Video("Why serving a LDS mission is the best thing you could do", "Denise Burns", 900);
        video3.AddComment("Grace", "Very instightfull! ");
        video3.AddComment("Hank", "Loved the examples on why serving is a blessing! ");
        video3.AddComment("Ivy", "This really helped me chose to serve a mission!!");
        video3.AddComment("Sara", "Did you serve state side or foren?");
        
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }

    }
}