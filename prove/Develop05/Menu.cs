public class Menu
{
    int TotalScore = 0;
    private static List<Goals> _goals = new List<Goals>();
    public Menu()
    {

    }

    public string MenuDisplay() // the menu questions
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create a new Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("What would you like to do? ");
        return Console.ReadLine();
    }

    public List<String> BasicQuestions() // makes a list of the basic questions and the ans. returns the list
    {

        List<String> Questions = new List<String>();

        Console.WriteLine("What is the name of your goal");
        string _name = Console.ReadLine();
        Questions.Add(_name);

        Console.WriteLine("What is a short description of your goal");
        string _description = Console.ReadLine();
        Questions.Add(_description);

        Console.WriteLine("How many points will it be worth");
        string _score = Console.ReadLine();
        Questions.Add(_score);

        return Questions;
    }

    public List<int> QuestionsForChecklist() // the extra questions for the checklist
    {
        List<int> Questions = new List<int>();
        Console.WriteLine("How many times does this goal need to be completed for a bonus?");
        int _targetCount = int.Parse(Console.ReadLine());
        Questions.Add(_targetCount);
        Console.WriteLine($"What is the bonus for completing it {_targetCount} times?");
        int _bonus = int.Parse(Console.ReadLine());
        Questions.Add(_bonus);

        return Questions;
    }

    public int ShowTotalScore() // shows the total score so far
    {
        return TotalScore;
    }

    public void CreateGoal(string UserChoiceOfGoal) // takes in the user choice of the goal and then 
    {
        if (UserChoiceOfGoal == "1")
        {
            List<String> BasicQSimple = new List<String>();
            BasicQSimple = BasicQuestions(); // this will show the basic questions above and add it to the list so th nI can chose the index to show a answer
            Simple newGoal = new Simple(BasicQSimple[0], BasicQSimple[1], BasicQSimple[2]); // this will make a new instance of the newGoal using simple. It will show the name (index 0) and then the desc(index 1) ands then points (index 2)
            _goals.Add(newGoal); // adds this list to the list of goals saved in this class

        }
        else if (UserChoiceOfGoal == "2")
        {
            List<String> BasicQEternal = new List<String>();
            BasicQEternal = BasicQuestions(); // makes a list of the basic questions
            Eternal newGoal = new Eternal(BasicQEternal[2], BasicQEternal[0], BasicQEternal[1]); // shows the score, name and desc
            _goals.Add(newGoal);
        }
        else if (UserChoiceOfGoal == "3")
        {
            List<String> BasicQChecklist = new List<String>();
            BasicQChecklist = BasicQuestions(); // makes a list of the basic questions and the ans
            List<int> ExtraCheckQ = QuestionsForChecklist(); // makes a list of the extra questions needed for the checklist
            Checklist newGoal = new Checklist(ExtraCheckQ[0], ExtraCheckQ[1], BasicQChecklist[2], BasicQChecklist[0], BasicQChecklist[1]); // now I can call the index of the target count, bonus, score, name and desc
            _goals.Add(newGoal);
        }
    }

    public void DisplayGoals()
    {
        foreach (Goals goal in _goals) // display all of the goals inside of the goals list
        {
            goal.Display();
        }
    }

    public void RecordEvent()
    {
        Console.Write("Enter goal number to record an event. \nFor example, if you want to complete the 2nd goal listed enter 2: ");
        int input = int.Parse(Console.ReadLine());

        Goals selectedGoal = _goals[input - 1]; // match index and input number

        int pointsEarned = selectedGoal.RecordEvent();

        TotalScore += pointsEarned;

        Console.WriteLine($"Event recorded! Your new score is: {TotalScore}");
    }

    public void SaveGoals(string filename)
    {
        Console.WriteLine("Saving Goals...");

        List<string> lines = new List<string>();

        lines.Add(TotalScore.ToString()); // this makes the total score the 0 index 

        foreach (Goals goal in _goals)
        {
            if (goal is Simple simpleGoal)
            {
                lines.Add($"Simple|{simpleGoal.GetSimpleTitle()}|{simpleGoal.GetSimpleDescription()}|{simpleGoal.GetSimplePoints()}|{simpleGoal.GetIsComplete()}");
            }
            else if (goal is Eternal eternalGoal)
            {
                lines.Add($"Eternal|{eternalGoal.GetEternalTitle()}|{eternalGoal.GetEternalDescription()}|{eternalGoal.GetEternalPoints()}");
            }
            else if (goal is Checklist checklistGoal)
            {
                lines.Add($"Checklist|{checklistGoal.GetCheckListTitle()}|{checklistGoal.GetCheckListDescription()}|{checklistGoal.GetCheckListPoints()}|{checklistGoal.GetTimesCompleted()}|{checklistGoal.GetTargetCount()}|{checklistGoal.GetIsComplete()}|{checklistGoal.GetBonus()}");
            }

        }

        File.WriteAllLines(filename, lines); // Write all lines at once

        Console.WriteLine($"Goals saved successfully! Check '{filename}' to see all of your goals.");
    }

    public void LoadGoals(string filename) // USE parse() and trim() to account for user input!!!!!
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        if (lines.Length == 0)
        {
            Console.WriteLine("File is empty.");
            return;
        }

        if (!int.TryParse(lines[0].Trim(), out int parsedScore))
        {
            Console.WriteLine("Couldn't parse total score.");
            return;
        }

        TotalScore = parsedScore;
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            for (int j = 0; j < parts.Length; j++)
            {
                parts[j] = parts[j].Trim();
            }

            Goals goal = null;

            string goalType = parts[0];
            if (goalType == "Simple" && parts.Length == 5)
            {
                string title = parts[1];
                string desc = parts[2];
                string score = parts[3];
                bool isComplete = bool.Parse(parts[4]);

                goal = new Simple(title, desc, score);
                if (isComplete) goal.RecordEvent();
            }
            else if (goalType == "Eternal" && parts.Length == 4)
            {
                string title = parts[1];
                string desc = parts[2];
                string score = parts[3];

                goal = new Eternal(score, title, desc);
            }
            else if (goalType == "Checklist" && parts.Length == 8)
            {
                string title = parts[1];
                string desc = parts[2];
                string score = parts[3];
                int completed = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                bool isComplete = bool.Parse(parts[6]);
                int bonus = int.Parse(parts[7]);

                Checklist checklist = new Checklist(target, bonus, score, title, desc);
                for (int j = 0; j < completed; j++)
                {
                    checklist.RecordEvent();
                }

                goal = checklist;
            }

            if (goal != null)
            {
                _goals.Add(goal);
            }
        }

        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Goals goal = _goals[i];
            string checkbox;

            if (goal.GetIsComplete())
            {
                checkbox = "[X]";
            }
            else
            {
                checkbox = "[ ]";
            }

            string title = "";
            string description = "";
            string progress = "";

            if (goal is Simple simpleGoal)
            {
                title = simpleGoal.GetSimpleTitle();
                description = simpleGoal.GetSimpleDescription();
            }
            else if (goal is Eternal eternalGoal)
            {
                title = eternalGoal.GetEternalTitle();
                description = eternalGoal.GetEternalDescription();
            }
            else if (goal is Checklist checklistGoal)
            {
                title = checklistGoal.GetCheckListTitle();
                description = checklistGoal.GetCheckListDescription();
                progress = $" -- Currently completed: {checklistGoal.GetTimesCompleted()}/{checklistGoal.GetTargetCount()}";
            }

            Console.WriteLine($"{i + 1}. {checkbox} {title} ({description}){progress}");
        }
        Console.WriteLine($"Loaded { _goals.Count } goals. Total Score: {TotalScore}");
    }
} 