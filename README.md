# MyCSharpDemo

Demo project for my C# snippets.

Includes a class library to convert between Arabic and Roman numerals.

## How to run

TODO: Add instructions how to use the program.

## Class RomanNumerals

Transforms Arabic numbers to their Roman equivalents, and vice versa. Smallest allowed value is 1, and biggest allowed value is 3.999.999.999.

Following notation will be used for special numbers beyond I:

| Letter  | Number   | Letter  |  Number   | Letter  | Number        |
|---------|----------|---------|-----------|---------|---------------|
| V       |        5 |       a |     5.000 |       A |     5.000.000 |
| X       |       10 |       h |    10.000 |       H |    10.000.000 |
| L       |       50 |       f |    50.000 |       F |    50.000.000 |
| C       |      100 |       e |   100.000 |       E |   100.000.000 |
| D       |      500 |       b |   500.000 |       B |   500.000.000 |
| M       |    1.000 |       w | 1.000.000 |       W | 1.000.000.000 |

With this notation, the number 3.594.798.739 would be WWWBHEwAbeeheaMMMDCCXXXIX (WWW B HE wA bee he aMMM DCC XXX IX).

### Method ArabicToRoman

TODO: Description of the method. Add tests.

### Method RomanToArabic

TODO: Implement and describe the method. Add tests.

## Steps to create a solution

TODO: Notes to self for future reference. Same information is provided on [a web page](https://learn.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio-code?pivots=dotnet-7-0).