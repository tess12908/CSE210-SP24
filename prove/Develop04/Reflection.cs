class Reflection : Activity
{
    private static string R_name = "Reflection";
    private static string R_description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    private int R_duration;

    List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    List<string> _questions = new List<string>

    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };


    public Reflection() : base(R_name, R_description, 0)
    {

    }

    public void DisplayRndPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine(prompt);
    }

    public void DisplayRndQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        string question = _questions[index];
        Console.WriteLine(question);
    }

    public void AddTogether(int runTIme)
    { 
        double passed = 0;
        while (passed < runTIme)
        {
            DisplayRndPrompt();
            Thread.Sleep(2500);
            passed += 2.5;

            DisplayRndQuestion();
            Thread.Sleep(5000);
            passed += 2.5;

            if (passed >= runTIme)
            {
                break;
            }
            
            Console.Clear();
        }  
    }


    public void Display()
    {
        StartMessage(R_name);

        R_duration = RunTime();
        Spinner(5); 
        Console.Clear(); 

        AddTogether(R_duration);

        EndMessage();
        Spinner(5); 
        Console.Clear(); 
    }

}