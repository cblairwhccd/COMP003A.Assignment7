namespace COMP003A.Assignment7;

class Program
{
    /* Prompt for integer within min/max range */
    static int Prompt(string prompt, int min, int max)
    {
        int result;
        while (true)
        {
            Console.Write(prompt);
            try
            {
                result = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid selection.");
                continue;
            }
            if (result < min || result > max)
            {
                Console.WriteLine("Selection out of range.");
                continue;
            }
            break;
        }
        return result;
    }

    /* Show menu options */
    static void DisplayMenu()
    {
        string[] menu = {"Display Values", "Show Total", "Show Average", "Exit"};
        for (int i = 0; i < menu.Length; i++)
        {
            Console.WriteLine($"{1+i}. {menu[i]}");
        }
    }

    /* Display all scores */
    static void DisplayValues(int[] scores)
    {
        Console.WriteLine("\nValues:");
        foreach (int score in scores)
        {
            Console.WriteLine(score);
        }
    }

    /* Calculate total score and print */
    static void ShowTotal(int[] scores)
    {
    }

    /* Calculate average score and print */
    static void ShowAverage(int[] scores)
    {
        int total = 0;
        foreach (int score in scores)
        {
            total += score;
        }
        /* BUGFIX: Must cast to double before division, or it will do integer division. */
        double average = (double)total / scores.Length;
        Console.WriteLine($"Average: {average}");
    }

    static void Main()
    {
        int[] scores = {85, 90, 78, 92, 88};
        DisplayMenu();
        int choice;
        while ((choice = Prompt("Enter choice: ", 1, 4)) != 4)
        {
            switch (choice)
            {
                case 1: DisplayValues(scores); break;
                case 2: ShowTotal(scores); break;
                case 3: ShowAverage(scores); break;
            }
            Console.WriteLine();
        }
    }
}