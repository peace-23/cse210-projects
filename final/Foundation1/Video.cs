using System;
using System.Collections.Generic;
using System.Text;


class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    private List<Comment> comments;

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        comments = new List<Comment>();
    }

    public void AddComment(string author, string text)
    {
        Comment c = new Comment(author, text);
        comments.Add(c);
    }

    public List<Comment> GetComments()
    {
        return comments;
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }
}
