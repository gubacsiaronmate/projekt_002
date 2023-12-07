// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
namespace Util;
class Base
{
    public static string Input(object? prompt)
    {
        Console.Write(prompt);
        object? usrinp = Console.ReadLine();
        if (usrinp == null) return "";
        else return typeConversion.String(usrinp);
    }

    public static void print(object? prompt) => Console.Write(prompt);

    public static void println(object? prompt) => Console.WriteLine(prompt);
}