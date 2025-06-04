using System;

class Program
{
    static void Main()
    {
        Reference ref1 = new Reference("1 Nephi", "21", 15, 16);
        Scripture scripture1 = new Scripture(ref1, "For can a woman forget her sucking child, that she should not have compassion on the son of her womb? Yea, they may forget, yet will I not forget thee, O house of Israel. Behold, I have graven thee upon the palms of my hands; thy walls are continually before me.");

        string userChoice = "";
        bool running = true; 

        while (userChoice != "quit")
        {
            scripture1.DisplayScripture();

            if (scripture1.IsAllHidden())
            {
                Console.WriteLine("\nAll words are hidden! Great job memorizing!!!");
                running = false;
            }

            Console.WriteLine("\nPress Enter to hide a word or type 'quit' to exit:");
            userChoice = Console.ReadLine();

            if (userChoice == "")
            {
                scripture1.HideWords();
            }
            else if (userChoice.ToLower() == "quit")
            {
                running = false;
            }
        }
    }
}
