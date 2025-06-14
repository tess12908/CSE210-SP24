using System.ComponentModel.DataAnnotations;
using System.IO.Compression;

class Breathing : Activity
{
    private static string B_name = "Breathing";
    private static string B_description = "This activity will help you relax by walking your through breathing in and out slowly.\n Clear your mind and focus on your breathing.";
    private int B_duration;

    public Breathing() : base(B_name, B_description, 0)
    {

    }

    public void RunBreathing(int runTime)
    {
        int passed = 0;
        while (passed < runTime)
        {
            Console.WriteLine($"You have {runTime - passed} seconds left");
            Thread.Sleep(2500);

            Console.WriteLine("Breathe in...");
            Thread.Sleep(5000);
            passed += 5;

            if (passed >= runTime)
            {
                break;
            }

            Console.WriteLine("Breathe out...");
            Thread.Sleep(5000);
            passed += 5; 

            Console.Clear();      
        }
    }

    public void Display()
    {
        StartMessage(B_name);

        B_duration = RunTime();
        Spinner(5); 
        Console.Clear();

        RunBreathing(B_duration);

        EndMessage();
        Spinner(5); 
        Console.Clear(); 
    }
}