using System;

class Video
{
    public string _title = "";
    public string _author = "";
    public int _length;
    public List<Comment> _comments = new List<Comment>();
    public int _numComments;

    public Video()
    {

    }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void showComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment._commentPerson}: {comment._commentText}");
            Console.WriteLine("");
        }
    }

    public int getNumComments()
    {
        return _comments.Count;
    }
}