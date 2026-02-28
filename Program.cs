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

    static void Main()
    {
        int[] scores = {85, 90, 78, 92, 88};
        string[] menu = {"Display Values", "Show Total", "Show Average", "Exit"};
        for (int i = 0; i < menu.Length; i++)
        {
            Console.WriteLine($"{1+i}. {menu[i]}");
        }
        int choice;
        while ((choice = Prompt("Enter choice: ", 1, 4)) != 4)
        {
            switch (choice)
            {
                case 1: /* Display Values */
                    break;
                case 2: /* Show Total */
                    break;
                case 3: /* Show Average */
                    break;
            }
        }
    }
}