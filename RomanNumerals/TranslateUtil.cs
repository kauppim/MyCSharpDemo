namespace RomanNumerals;
public static class TranslateUtil
{
    public const uint maxValue = 4000000000;

    public static string ArabicToRoman(string arabicInput)
    {
        var romanized = "(NaN)";
        uint temp = 0;

        try
        {
            temp = System.Convert.ToUInt32(arabicInput);
        }
        catch (System.Exception)
        {
            return romanized;
        }

        if (temp > 0 && temp < maxValue) 
        {
            romanized = "";
            var powers = 1;
            
            while (temp > 0)
            {
                var n = (temp % 10);
                if (n > 0 && n < 10)
                {
                    n -= 1;
                    switch (powers)
                    {
                        case 1:
                            romanized = (new string[] {"I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"})[n];
                            break;
                        case 10:
                            romanized = (new string[] {"X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXX", "XC"})[n] + romanized;
                            break;
                        case 100:
                            romanized = (new string[] {"C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"})[n] + romanized;
                            break;
                        case 1000:
                            romanized = (new string[] {"M", "MM", "MMM", "Ma", "a", "aM", "aMM", "aMMM", "Mh"})[n] + romanized;
                            break;
                        case 10000:
                            romanized = (new string[] {"h", "hh", "hhh", "hf", "f", "fh", "fhh", "fhhh", "he"})[n] + romanized;
                            break;
                        case 100000:
                            romanized = (new string[] {"e", "ee", "eee", "eb", "b", "be", "bee", "beee", "ew"})[n] + romanized;
                            break;
                        case 1000000:
                            romanized = (new string[] {"w", "ww", "www", "wA", "A", "Aw", "Aww", "Awww", "wH"})[n] + romanized;
                            break;
                        case 10000000:
                            romanized = (new string[] {"H", "HH", "HHH", "HF", "F", "FH", "FHH", "FHHH", "HE"})[n] + romanized;
                            break;
                        case 100000000:
                            romanized = (new string[] {"E", "EE", "EEE", "EB", "B", "BE", "BEE", "BEEE", "EW"})[n] + romanized;
                            break;
                        case 1000000000:
                            romanized = (new string[] {"W", "WW", "WWW", "", "", "", "", "", ""})[n] + romanized;
                            break;
                    }

                }
                Console.WriteLine("Current value: " + romanized);
                temp = (temp - n) / 10;
                powers *= 10;
                Console.WriteLine("Temp: " + temp);
            }
        }
        
        return romanized;
    }

    public static uint RomanToArabic(string romanInput)
    {
        // TODO: Implement method.
        return 0;
    }
}
