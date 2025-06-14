class Listing : Activity
{
    private static string L_name = "Listing";
    private static string L_description = "This activity will help you reflect on the good things in your life \nby having you list as many things as you can in a certain area.";
    private int L_duration;

    List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public Listing() : base(L_name, L_description, 0)
    {

    }
    public void DisplayRndPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine(prompt);
    }

    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }

        Console.WriteLine("Start writing/ listing as many items as you can now");
    }

    public void ListingIdeas(int runtime)
    {
        List<string> items = new List<string>();
        DateTime startTime = DateTime.Now;

        Console.WriteLine($"You have {runtime} seconds to list as many items as you can.");
        while (true)
        {
            if ((DateTime.Now - startTime).TotalSeconds >= runtime)
                break;

            Console.Write(">");
            string input = Console.ReadLine();
            items.Add(input);
        }

        Console.WriteLine($"\nYou listed {items.Count} items:");
        foreach (string item in items)
        {
            Console.WriteLine($"- {item}");
        }

    } 

    public void Display()
    {
        Console.Clear(); 
        Spinner(5);
        Console.Clear(); 
         
        StartMessage(L_name);
        Thread.Sleep(5000);
        Console.Clear(); 
        Console.WriteLine($"This is specificly the {L_name} activity. {L_description} "); 
        Thread.Sleep(3000);
        Console.Clear();

        L_duration = RunTime();

        Console.Clear();
        Spinner(5);
        Console.Clear();

        DisplayRndPrompt();

        Countdown(5);
        Thread.Sleep(1000);
        Console.Clear();

        ListingIdeas(L_duration);
        Thread.Sleep(5000);
        Console.Clear();

        EndMessage();
        Spinner(5);
        Console.Clear();
    }
    
}