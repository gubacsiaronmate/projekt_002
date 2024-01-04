// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
using dataStorage;

namespace htmlGenerator;

class Generator
{
    public static void generateHtml(string filepath, Dictionary<string, List<computerParts>> data)
    {
        StreamWriter sw = new(filepath);
        sw.WriteLine("<div id=\"wrapper\">");
        foreach (var key in data.Keys.ToArray())
        {
            sw.WriteLine($"\t<div id=\"category\">{key}: ");
            foreach (var part in data[key])
            {
                sw.WriteLine($"\t\t<p>{part.ToMassPrintString()}</p>");
            }
            sw.WriteLine("</div>");
        }
        sw.WriteLine("</div>");
        sw.Close();
    }
}