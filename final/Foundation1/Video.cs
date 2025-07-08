using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

public class Video
{
    public string _title; 
    public string _author; 
    public int _seconds; 
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int seconds)
    { 
        _title = title; 
        _author = author; 
        _seconds = seconds; 
        _comments = new List<Comment>();
    }

    public void AddComment(string name, string text)
    {
        _comments.Add(new Comment(name, text));
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public int GetMin()
    {
        int min = _seconds/60; 
        return min; 
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nLength in seconds: {_seconds} seconds\n Length in Minutes:{GetMin()} Minutes\n Comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
        }

        Console.WriteLine();
    }
}