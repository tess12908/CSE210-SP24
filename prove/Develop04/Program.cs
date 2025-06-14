using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running != false)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing activity");
            //string option_one = Console.ReadLine();
    
            Console.WriteLine("2. Start Reflecting activity");
            //string option_two = Console.ReadLine();

            Console.WriteLine("3. Start Listing activity");
            //string option_three = Console.ReadLine();


            Console.WriteLine("4. Quit");
            //string option_four = Console.ReadLine();

            Console.WriteLine("Select a choice from the menu");
            string user_choice = Console.ReadLine();

            if (user_choice == "1")
            {
                Breathing breathingActivity  = new Breathing();
                breathingActivity.Display();

            }
            if (user_choice == "2")
            {
                Reflection ReflectionActivity  = new Reflection();
                ReflectionActivity.Display();
            }
            if (user_choice == "3")
            {
                Listing ListingActivity  = new Listing();
                ListingActivity.Display();
            }
            if (user_choice == "4")
            {
                running = false; 
            }
        }
    }
}