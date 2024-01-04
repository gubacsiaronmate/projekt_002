// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
namespace Util;
class Base
{
    public static string input(object? prompt)
    {
        Console.Write(prompt);
        object? usrinp = Console.ReadLine();
        if (usrinp == null) return "";
        return typeConversion.String(usrinp).Trim('"');
    }

    public static void print(object? prompt) => Console.Write(prompt);

    public static void println(object? prompt) => Console.WriteLine(prompt);
}

public class CustomException : Exception
{
    public CustomException() { }
    
    public CustomException(string message) : base(message) { }
    
    public CustomException(string message, Exception innerException) : base(message, innerException) { }
}