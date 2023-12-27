// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
using static Util.typeConversion;
using static Util.Base;
namespace Main;

public static class Program
{
    public static void Main(string[] args)
    {
        // Variables:
        string headLine = "Welcome to our Computer Parts warehouse!";
        string optText = "Please choose from this menu:";
        string[] options = { "[A]> Search Parts", "[B]> Add Part", "[C]> Print All", "[D]> Show Statistics", "[E]> Apply Discount", "[X]> Exit" };
        string[] keys = {"A", "B", "C", "D", "E", "X"};
        string howToChooseText = "Press the corresponding key to continue";
        int numOfSpaces = 3;
        string starLine = new string('*', (headLine.Length + (2 * numOfSpaces) + 2));
        string spaceLine = new string(' ', (headLine.Length + (2 * numOfSpaces)));
        string smallSpacer = new string(' ', numOfSpaces);
        
        // Menu displayed:
        println(
            $"{starLine}"+
                $"\n*{spaceLine}*"+
                $"\n*{smallSpacer}{headLine}{smallSpacer}*"+
                $"\n*{spaceLine}*"+
                $"\n*{spaceLine}*"+
                $"\n*{smallSpacer}{optText}{new string(' ', (headLine.Length - optText.Length + numOfSpaces))}*"
        );
        foreach (var opt in options)
        {
            println($"*{smallSpacer}{opt}{new string(' ', (headLine.Length - opt.Length + numOfSpaces))}*");
        }
        println(
            $"*{spaceLine}*"+
                $"\n*{smallSpacer}{howToChooseText}{new string(' ', (headLine.Length - howToChooseText.Length + numOfSpaces))}*"+
                $"\n*{spaceLine}*"+
                $"\n{starLine}\n"
        );
        
        // Menu Input:
        string pressedKey = getPressedKey().KeyChar.ToString().ToUpper();
        
        // Menu Input Handling:
        while (Array.IndexOf(keys, pressedKey) == -1)
        {
            println(" <- This is an invalid input! Choose from the menu above!\n");
            pressedKey = getPressedKey().KeyChar.ToString().ToUpper();
        }
        switch (pressedKey)
        {
            case "A":
                println(String(pressedKey));
                break;
            
            case "B":
                println(String(pressedKey));
                break;
            
            case "C":
                println(String(pressedKey));
                break;
            
            case "D":
                println(String(pressedKey));
                break;
            
            case "E":
                println(String(pressedKey));
                break;
            
            case "X":
                println(String(pressedKey));
                break;
        }
    }

    private static ConsoleKeyInfo getPressedKey() => Console.ReadKey();
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


    *   opt     * ==> *{smallSpacer}{opt}{' ' * (headLine.Length - opt.Length + numOfSpaces)}*

*/
 