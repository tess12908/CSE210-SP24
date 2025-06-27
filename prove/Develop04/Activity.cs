using System.ComponentModel;
using Microsoft.VisualBasic;
class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    List<String> animationStrings = new List<string>
    {
        "|",
        "/",
        "-",
        "\\", // i used chat GPT here to figure out why i needed 2 back slashes here instead of one! Apparently it's a syntax thing in c#
        "|"
    }; 

    protected Activity(string name, string description, int duration)
    {
        _duration = duration;
        _name = name;
        _description = description;
    }
    protected void StartMessage(string activity)
    {
        Console.WriteLine($"Welcome to the Mindfulness Activity Program! - this is the {activity} activity");
        Console.WriteLine();
        Console.WriteLine("These Activitys are designed to help you slow down, focus your thoughts,");
        Console.WriteLine("and become more aware of the present moment.");
        Console.WriteLine();
    }

    protected void EndMessage()
    {
        Console.WriteLine("Well done! You've completed the mindfulness activity.");
        Console.WriteLine("I hope that this helped you become more mindful and reflective");
        Console.WriteLine("Come back soon"); 
    }

    protected void Spinner(int seconds)
    {
        DateTime endtime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endtime)
        {
            Console.Write(animationStrings[i % animationStrings.Count]); // I went to the drop in lab to get help and this is what the recommended. They explained that it loops through the spinner symbols repeatedly like a minni while in a while
            Thread.Sleep(500);
            Console.Write("\b");
            i++; 
        }
    }

    protected int RunTime()
    {
        Console.WriteLine("How long would you like to do this for? We recommend at least 30 seconds");
        _duration = int.Parse(Console.ReadLine()); 
        return _duration; 
    }

}