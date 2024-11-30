using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Arcane: Animation Test", "League of Legends", 78);
        video1.AddComment(new Comment("twentyonetortas5921", "You know Arcane is an artistic masterpiece when even the drafts and works in between the process of the shows creation are amazing enough to pass as their own works."));
        video1.AddComment(new Comment("TheRealGuywithoutaMustache", "This animation is already great, but the level of animation in the actual show truly blew this out of the water."));
        video1.AddComment(new Comment("cricketben6742", "So cool that stuff like that gets released now!"));
        
        Video video2 = new Video("Arcane: Season 2 | Isha Pulls the Trigger", "Nerd Clips HD", 142);
        video2.AddComment(new Comment("DanishaIva", "The way Jinx screams Isha makes my heart shattering"));
        video2.AddComment(new Comment("dustf1nger118", "Isha lived up to her name in Sanskrit:  One Who Protects"));
        
        Video video3 = new Video("Ekko y Powder Bailando - Arcane - Español Latino", "Nikzard", 159);
        video3.AddComment(new Comment("BravoManGameplaysyTutorialesTM", "quien diria que el mejor momento de la 1er temporada es cuando ellos dos pelean y el mejor momento de la 2da temporada es cuando ellos bailan"));
        video3.AddComment(new Comment("Chano1472", "Algo que es genial de ekko es que jamas dudo en irse siempre estuvo dispuesto a despedirse de su realidad soñada, quizo irse lo antes posible para ayudar a sus amigos"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            video.DisplayComments();
            Console.WriteLine(); 
        }
    }
}
