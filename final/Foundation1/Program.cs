using System;

class Program
{
    static void Main(string[] args)
    {
        VideoList videoList = new VideoList();
        Video video1 = new Video("Pokémon FireRed - Episode 43", "MunchingOrange", 605);
        videoList._videos.Add(video1);
        Comment _comment1 = new Comment("I BEAT the alakazam slowly as well and i stalled it with a toxic and the toxic damage added up and did about half to him and became a 2 hit ko", "Timothy Cho");
        Comment _comment2 = new Comment("i got caught in alakazams infinite recover loop against my kadabra", "William Cannon");
        Comment _comment3 = new Comment("Nice one munching orange", "Andrew McAllister");
        Comment _comment4 = new Comment("Orange u my friend are a BOSS", "Aaron Skill");
        video1._comments.Add(_comment1);
        video1._comments.Add(_comment2);
        video1._comments.Add(_comment3);
        video1._comments.Add(_comment4);

        Video video2 = new Video("10 hours Wii Shop Channel Music", "10 hours of", 36000);
        videoList._videos.Add(video2);
        Comment _comment5 = new Comment("I used this as background music for a science slideshow. It was one of the best decisions in my life.", "PottedPlantz");
        Comment _comment6 = new Comment("Better than everything on the radio right now.", "James Blonde");
        Comment _comment7 = new Comment("This song always plays in my head sometimes but I don't care because it is really catchy.", "Cyksta");
        Comment _comment8 = new Comment("Whoever made this song needs to get a raise!", "Rithan renacia");
        video2._comments.Add(_comment5);
        video2._comments.Add(_comment6);
        video2._comments.Add(_comment7);
        video2._comments.Add(_comment8);

        Video video3 = new Video("The Lamanites Must Rise in Majesty and Power", "General Conference", 658);
        videoList._videos.Add(video3);
        Comment _comment9 = new Comment("Amazing talk!", "Steve Gomez");
        Comment _comment10 = new Comment("How many years ago was this talk given?", "cuinn837");
        Comment _comment11 = new Comment("I can't believe its been this long", "Art890");
        Comment _comment12 = new Comment("He was a Gen Authority from 1974 until his death in 2008. That said, Im gonna say this was late 70s early 80s??", "UltraDoug");
        video3._comments.Add(_comment9);
        video3._comments.Add(_comment10);
        video3._comments.Add(_comment11);
        video3._comments.Add(_comment12);

        videoList.showVideoList();
    }
}