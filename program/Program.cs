// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
using static Util.Base;
namespace Main;

public static class Program
{
    public static void Main(string[] args)
    {
        string headLine = "Welcome to our Computer Parts storage!";
        string optText = "Please choose from this menu:";
        string[] options = { "[A]> Search Parts", "[B]> Add Part", "[C]> Print All", "[D]> Show Statistics", "[E]> Apply Discount", "[X]> Exit" };
        int numOfSpaces = 3;
        string starLine = new string('*', (headLine.Length + (2 * numOfSpaces) + 2));
        string spaceLine = new string(' ', (headLine.Length + (2 * numOfSpaces)));
        string smallSpacer = new string(' ', numOfSpaces);
        /* *   opt                     *
                ||
                V
            *{smallSpacer}{opt}{' ' * (headLine.Length - opt.Length + numOfSpaces)}* 
        */
        println(
            $"{starLine}"+
                $"\n*{spaceLine}*"+
                $"\n*{smallSpacer}{headLine}{smallSpacer}*"+
                $"\n*{spaceLine}*"+
                $"\n*{smallSpacer}{optText}{new string(' ', (headLine.Length - optText.Length + numOfSpaces))}*"+
                $"\n*{spaceLine}*"
        );
        foreach (var opt in options)
        {
            println($"*{smallSpacer}{opt}{new string(' ', (headLine.Length - opt.Length + numOfSpaces))}*");
        }
        println($"*{spaceLine}*\n{starLine}");
    }
}

/*
 
    ************************************************** // 50
    *                                                *
    *                                                *
    *                                                *
    *                                                *
    *                                                *
    *                                                *
    *                                                *
    **************************************************
 */