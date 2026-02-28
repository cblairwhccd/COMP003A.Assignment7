namespace COMP003A.Assignment7;

class Program
{
    /* Prompt for integer */
    static int Prompt(string prompt)
    {
        int result;
        Console.Write(prompt);
        try
        {
            result = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            result = -1;
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

    /* Calculate total score */
    static int CaclulateTotal(int[] scores)
    {
        int total = 0;
        foreach (int score in scores)
        {
            total += score;
        }
        return total;
    }

    /* Calculate total score and print */
    static void ShowTotal(int[] scores)
    {
        int total = CaclulateTotal(scores);
        Console.WriteLine($"Total: {total}");
    }

    /* Calculate average score and print */
    static void ShowAverage(int[] scores)
    {
        int total = CaclulateTotal(scores);
        /* BUGFIX: Must cast to double before division, or it will do integer division. */
        /* Previous result: 86; Correct result: 86.6 */
        double average = (double)total / scores.Length;
        Console.WriteLine($"Average: {average}");
    }

    /* Display individual scores, total score and average score from score data */
    static void Main()
    {
        /* Score data */
        int[] scores = {85, 90, 78, 92, 88};
        DisplayMenu();
        int choice;
        while ((choice = Prompt("Enter choice: ")) != 4)
        {
            if (choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid selection.");
                continue;
            }
            switch (choice)
            {
                case 1: DisplayValues(scores); break;
                case 2: ShowTotal(scores); break;
                case 3: ShowAverage(scores); break;
            }
            Console.WriteLine();
        }
        Console.WriteLine("Program ended.");
    }
}