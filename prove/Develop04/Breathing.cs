using System.ComponentModel.DataAnnotations;
using System.IO.Compression;
using System.Runtime.CompilerServices;

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
        }
    }

    public void Display()
    {
        Console.Clear(); 
        Spinner(5);
        Console.Clear(); 

        StartMessage(B_name);
        Thread.Sleep(5000);
        Console.Clear(); 
        Console.WriteLine($"This is specificly the {B_name} activity. {B_description} "); 
        Thread.Sleep(3000);
        Console.Clear();

        B_duration = RunTime();
        Console.Clear(); 
    
        RunBreathing(B_duration);

        EndMessage();
        Spinner(5);
    }
}