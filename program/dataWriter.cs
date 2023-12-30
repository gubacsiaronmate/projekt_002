// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
using static Util.typeConversion;
using static Util.Base;
using dataStorage;
namespace dataWriter;

class dataWriter
{
    public void saveData(Dictionary<string, List<computerParts>> data, string filepath)
    {
        StreamWriter sw = new(filepath);
        string[] dataKeys = data.Keys.ToArray();
        foreach (var key in dataKeys)
        {
            foreach (var part in data[key])
            {
                sw.WriteLine(part.ToWritableString());
            }
        }
    }
}