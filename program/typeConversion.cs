// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable ClassNeverInstantiated.Global
using System.Text.Json;
namespace Util;
class typeConversion : Base
{
    // Numeric
    public static int Int(string value) => int.Parse(value);
    public static long Long(string value) => long.Parse(value);
    public static float Float(string value) => float.Parse(value);
    public static double Double(string value) => double.Parse(value);
    
    // Text
    public static string String(object value) => JsonSerializer.Serialize(value);
}