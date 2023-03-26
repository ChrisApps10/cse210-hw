using System;

class Comment
{
    public string _commentText = "";
    public string _commentPerson = "";

    public Comment()
    {

    }

    public Comment(string text, string person)
    {
        _commentText = text;
        _commentPerson = person;
    }
}