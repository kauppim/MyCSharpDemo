using RomanNumerals;

class Program
{
    // TODO: Change this to be suitable for two class methods.
    static void Main(string[] args)
    {
        int row = 0;

        do
        {
            if (row == 0 || row >= 25)
                ResetConsole();

            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;
            Console.WriteLine($"Input: {input}");
            Console.WriteLine("Romanized: " +
                 $"{TranslateUtil.ArabicToRoman(input)}");
            Console.WriteLine();
            row += 4;
        } while (true);
        return;

        // Declare a ResetConsole local method
        void ResetConsole()
        {
            if (row > 0)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine($"{Environment.NewLine}Smallest allowed value is 1; largest allowed value is {TranslateUtil.maxValue - 1}.");
            Console.WriteLine($"{Environment.NewLine}Press <Enter> only to exit; otherwise, enter a number and press <Enter>:{Environment.NewLine}");
            row = 3;
        }
    }
}