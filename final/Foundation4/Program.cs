using System.IO.Pipes;

class Program
{
    static void Main()
    {
        ListMaker starting = new ListMaker();

        Console.WriteLine("Starting stats"); 
        Console.WriteLine(); 
        starting.AddActivity(new Running("Jan 3rd 2024", 30, 4.8));
        //Running.addToList(); 
        starting.AddActivity(new Bike("Jan 4th 2024", 60, 10.5));
        starting.AddActivity(new Swimming("Jan 7th 2024", 45, 30));
        Console.WriteLine(starting.GetAllSummaries());
        
        Console.WriteLine("///////////////////////////\n"); 
        ListMaker ending = new ListMaker();

        Console.WriteLine("Ending stats "); 
        Console.WriteLine(); 
        ending.AddActivity(new Running("April 1st 2024", 30, 6.8));
        ending.AddActivity(new Bike("April 2nd 2024", 60, 10.0));
        ending.AddActivity(new Swimming("April 3rd 2024", 45, 48));
        Console.WriteLine(ending.GetAllSummaries());

        
    }
}