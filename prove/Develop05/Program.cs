class Program
{
    static void Main(string[] args)
{
    bool running = true;
    Menu menu = new Menu(); 

    while (running == true)
    {
        int score = menu.ShowTotalScore();
        Console.WriteLine($"Points: {score}");
        Console.WriteLine("");
        string userChoice = menu.MenuDisplay();

        if (userChoice == "1")
        {
            Console.WriteLine("The type of Goals are:");
            Console.WriteLine("1. Simple Goal \n 2. Eternal Goal \n 3. Checklist Goal");
            string choiceOfGoal = Console.ReadLine();
            menu.CreateGoal(choiceOfGoal);
        }
        else if (userChoice == "2")
        {
            menu.DisplayGoals();
        }
        else if (userChoice == "3")
        {
            Console.WriteLine("What do you want to name the txt file? Format as 'name.txt' ");
            string fileName = Console.ReadLine();
            menu.SaveGoals(fileName); 
        }
        else if (userChoice == "4")
        {
            Console.WriteLine("What is the name of the TXT file you want to access? Format as 'name.txt'");
            string fileName = Console.ReadLine();
            menu.LoadGoals(fileName);
        }
        else if (userChoice == "5")
        {
            menu.DisplayGoals();
            menu.RecordEvent();
        }
        else if (userChoice == "6")
        {
            running = false;
        }
    }
}

} 