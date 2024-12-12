public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Eternal Quest Menu:");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Details");
            Console.WriteLine("3. Create a New Goal");
            Console.WriteLine("4. Record an Event");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    CreateGoal();
                    break;
                case "4":
                    RecordEvent();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player Score: {_score}");
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Choose Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string typeChoice = Console.ReadLine();

        Console.Write("Enter Goal Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Goal Description: ");
        string description = Console.ReadLine();
        Console.Write("Enter Goal Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (typeChoice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter Target Count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter Bonus Points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid choice. Goal not created.");
                break;
        }
    }

    public void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("Enter Goal Index to Record Event: ");
        int index = int.Parse(Console.ReadLine());

        if (index >= 0 && index < _goals.Count)
        {
            Goal goal = _goals[index];
            goal.RecordEvent();
            _score += goal.IsComplete() ? goal.Points : 0;
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }

    public void SaveGoals()
    {
        // Serialization logic
    }

    public void LoadGoals()
    {
        // Deserialization logic
    }
}
