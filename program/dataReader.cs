// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
using dataStorage;
using static Util.typeConversion;
namespace dataReader;

class dataReader
{
    public List<computerParts> readData(string filepath)
    {
        List<computerParts> data = new();
        foreach (var item in File.ReadAllLines(filepath))
        {
            string[] line = item.Split(";");
            data.Add(new computerParts(line[0], line[1], line[2], Int(line[3])));
        }
        
        return data;
    }
}