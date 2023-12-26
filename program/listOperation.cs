// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
namespace Util;
public static class ListExtensions
{
    public static int ToMultiple(this List<int> list)
    {
        int sum = 1;
        foreach (int item in list)
        {
            sum *= item;
        }
        return sum;
    }

    public static long ToMultiple(this List<long> list)
    {
        long sum = 1;
        foreach (long item in list)
        {
            sum *= item;
        }
        return sum;
    }

    public static float ToMultiple(this List<float> list)
    {
        float sum = 1.0F;
        foreach (float item in list)
        {
            sum *= item;
        }
        return sum;
    }

    public static double ToMultiple(this List<double> list)
    {
        double sum = 1.0;
        foreach (double item in list)
        {
            sum *= item;
        }
        return sum;
    }
}