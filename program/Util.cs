namespace Util
{
    class Base
    {
        public static object Input(object? prompt)
        {
            Console.Write(prompt);
            object? usrinp = Console.ReadLine();
            if (usrinp == null) return "";
            else return usrinp;
        }

        public static void print(object? prompt) => Console.Write(prompt);

        public static void println(string prompt) => Console.WriteLine(prompt);
    }
}