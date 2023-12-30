// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
using static dataSorter.dataSorter;
using static dataSearch.dataSearch;
using static Util.typeConversion;
using applyDiscountNamespace;
using System.Globalization;
using static Util.Base;
using dataStorage;
namespace Main;

public static class Program
{
    public static void Main()
    {
        // Text variables for printing:
        string headLine = "Welcome to our Computer Parts warehouse!";
        string optText = "Please choose from this menu:";
        string[] options = { "[A]> Search Parts", "[B]> Add Part", "[C]> Print All", "[D]> Show Statistics", "[E]> Apply Discount", "[F]> HTML generator", "[X]> Exit" };
        string[] keys = {"A", "B", "C", "D", "E", "F", "X"};
        string howToChooseText = "Press the corresponding key to continue";
        int numOfSpaces = 3;
        string starLine = new string('*', (headLine.Length + (2 * numOfSpaces) + 2));
        string spaceLine = new string(' ', (headLine.Length + (2 * numOfSpaces)));
        string smallSpacer = new string(' ', numOfSpaces);
        
        // Functionality variables:
        Dictionary<string, List<computerParts>> data = sortInitialData();
        string[] dataKeys = data.Keys.ToArray();
        string filepath = "database.txt";
        
        // Menu displayed:
        println(
            $"\n{starLine}"+
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
                List<string> searchResults = searchDatabase(
                    input("\nEnter the search term you want to search by:  "), data);
                foreach (var result in searchResults) { println(result); }
                Main();
                break;
            
            case "B":
                println("");
                data = sortAddedPart(data, computerParts.getNewPart());
                new dataWriter.dataWriter().saveData(data, filepath);
                println("New part added!");
                Main();
                break;
            
            case "C":
                println("");
                foreach (var key in dataKeys)
                {
                    foreach (var part in data[key])
                    {
                        println(part.ToMassPrintString());
                    }
                }
                Main();
                break;
            
            case "D":
                println("");
                showStatistics(data);
                Main();
                break;
            
            case "E":
                println("");
                data = new discountClass().applyDiscount(data);
                new dataWriter.dataWriter().saveData(data, filepath);
                println("Discount applied!");
                Main();
                break;
            
            case "F":
                println("");
                println("Code generated at \"~\\projekt_002\\program\\bin\\Debug\\net6.0\\index.html\"!");
                Main();
                break;
            
            case "X":
                new dataWriter.dataWriter().saveData(data, filepath);
                Exit();
                break;
        }
    }

    private static ConsoleKeyInfo getPressedKey() => Console.ReadKey();

    private static void Exit() => Environment.Exit(0);

    private static void showStatistics(Dictionary<string, List<computerParts>> data)
    {
        println("");
        string[] dataKeys = data.Keys.ToArray();
        foreach (var category in dataKeys)
        {
            println($"{CultureInfo.CurrentCulture.TextInfo.ToTitleCase(category)}: {data[category].Count}");
        }
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


    *   opt     * ==> *{smallSpacer}{opt}{' ' * (headLine.Length - opt.Length + numOfSpaces)}*

*/

// dataReader.dataReader dr = new();
// List<computerParts> sortableData = dr.loadData("database.txt");
