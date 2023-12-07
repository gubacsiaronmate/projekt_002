// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
namespace Util;
class typeConversion : Base
{
    public static int Int(string value) => int.Parse(value);
    public static long Long(string value) => long.Parse(value);
    public static float Float(string value) => float.Parse(value);
    public static double Double(string value) => double.Parse(value);
}