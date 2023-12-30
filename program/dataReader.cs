// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
using static Util.typeConversion;
using dataStorage;
namespace dataReader;

class dataReader
{
    public List<computerParts> loadData(string filepath)
    {
        List<computerParts> data = new();
        foreach (var item in File.ReadAllLines(filepath))
        {
            string[] line = item.Trim().Split(";");
            data.Add(new computerParts(line[0], line[1], line[2], Int(line[3])));
        }
        
        return data;
    }
}