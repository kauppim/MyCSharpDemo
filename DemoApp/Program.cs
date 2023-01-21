using RomanNumerals;

class Program
{
    // TODO: Change this to be suitable for two class methods.
    static void Main(string[] args)
    {
        var input = "1986";
        string output = TranslateUtil.ArabicToRoman(input);
        Console.WriteLine("Input: " + input);
        Console.WriteLine("Romanized: " + output);
        Console.WriteLine("Arabicized: " + $"{TranslateUtil.RomanToArabic(output)}");

        input = "3594798739";
        output = TranslateUtil.ArabicToRoman(input);
        Console.WriteLine("Input: " + input);
        Console.WriteLine("Romanized: " + output);
        Console.WriteLine("Arabicized: " + $"{TranslateUtil.RomanToArabic(output)}");
    }
}