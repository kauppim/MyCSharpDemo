namespace RomanNumerals;
public static class TranslateUtil
{
    public const uint maxValue = 4000000000;
    private static readonly string[] powersOf1 = {"I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};
    private static readonly string[] powersOf10 = {"X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"};
    private static readonly string[] powersOf100 = {"C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"};
    private static readonly string[] powersOf1000 = {"M", "MM", "MMM", "Ma", "a", "aM", "aMM", "aMMM", "Mh"};
    private static readonly string[] powersOf10000 = {"h", "hh", "hhh", "hf", "f", "fh", "fhh", "fhhh", "he"};
    private static readonly string[] powersOf100000 = {"e", "ee", "eee", "eb", "b", "be", "bee", "beee", "ew"};
    private static readonly string[] powersOf1000000 = {"w", "ww", "www", "wA", "A", "Aw", "Aww", "Awww", "wH"};
    private static readonly string[] powersOf10000000 = {"H", "HH", "HHH", "HF", "F", "FH", "FHH", "FHHH", "HE"};
    private static readonly string[] powersOf100000000 = {"E", "EE", "EEE", "EB", "B", "BE", "BEE", "BEEE", "EW"};
    private static readonly string[] powersOf1000000000 = {"W", "WW", "WWW", "", "", "", "", "", ""};
    private static List<string[]> powers = new List<string[]> {powersOf1000000000, powersOf100000000, powersOf10000000, powersOf1000000, powersOf100000, powersOf10000, powersOf1000, powersOf100, powersOf10, powersOf1};

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
                            romanized = powersOf1[n];
                            break;
                        case 10:
                            romanized = powersOf10[n] + romanized;
                            break;
                        case 100:
                            romanized = powersOf100[n] + romanized;
                            break;
                        case 1000:
                            romanized = powersOf1000[n] + romanized;
                            break;
                        case 10000:
                            romanized = powersOf10000[n] + romanized;
                            break;
                        case 100000:
                            romanized = powersOf100000[n] + romanized;
                            break;
                        case 1000000:
                            romanized = powersOf1000000[n] + romanized;
                            break;
                        case 10000000:
                            romanized = powersOf10000000[n] + romanized;
                            break;
                        case 100000000:
                            romanized = powersOf100000000[n] + romanized;
                            break;
                        case 1000000000:
                            romanized = powersOf1000000000[n] + romanized;
                            break;
                    }

                }
                temp = (temp - n) / 10;
                powers *= 10;
            }
        }
        
        return romanized;
    }

    public static uint RomanToArabic(string romanInput)
    {
        uint arabicized = 0;
        uint seed = 1000000000;

        foreach (var power in powers)
        {
            var n = -1;
            var m = 0;
            foreach (var item in power)
            {
                if (!String.IsNullOrWhiteSpace(item) && romanInput.Contains(item))
                    n = m;
                m++;
            }
            if (n > -1) {
                arabicized += (uint) (n+1) * seed;
                romanInput = romanInput.Remove(0, power[n].Length);
            }
            seed /= 10;
        }
        return arabicized;
    }
}
