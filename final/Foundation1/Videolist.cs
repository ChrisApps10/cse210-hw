

using System;

class VideoList
{
    public List<Video> _videos = new List<Video>();
    public VideoList()
    {

    }

    public void showVideoList()
    {
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Videos");
        Console.WriteLine("");
        foreach (Video video in _videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            int numComments = video.getNumComments();
            Console.WriteLine($"Comments: ({numComments} total)");
            video.showComments();
            Console.WriteLine("----------------------------------------------------");
        }
    }

}