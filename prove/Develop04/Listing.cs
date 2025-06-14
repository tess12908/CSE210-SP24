class Listing : Activity
{
    private static string L_name = "Listing";
    private static string L_description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
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

        while ((DateTime.Now - startTime).TotalSeconds < runtime)
        {
            string entered = "";
            if (entered == "")
            {
                string input = Console.ReadLine();
                items.Add(input);
            }
        }

        Console.WriteLine($"You listed {items.Count} items");
        foreach (string item in items)
        {
            Console.WriteLine($"- {item}");
        }
    }

    public void Display()
    {
        StartMessage(L_name);

        L_duration = RunTime();
        Spinner(5); 
        Console.Clear();

        DisplayRndPrompt();

        Countdown(5);
        Console.Clear();

        ListingIdeas(L_duration);

        EndMessage();
        Spinner(5); 
        Console.Clear(); 
    }

}