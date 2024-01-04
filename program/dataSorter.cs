// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
using static Util.Base;
using dataStorage;
namespace dataSorter;

class dataSorter
{
    public static Dictionary<String, List<computerParts>> sortInitialData()
    {
        dataReader.dataReader dr = new();
        List<computerParts> sortableData = dr.loadData("database.txt");
        Dictionary<String, List<computerParts>> data = new();
        foreach (computerParts part in sortableData)
        {
            switch (part.getTypeValue().ToLower())
            {
                case "motherboard":
                    if (data.ContainsKey("motherboard"))
                    { data["motherboard"].Add(part); break; }
                    data["motherboard"] = new List<computerParts> { part };
                    break;

                case "cpu":
                    if (data.ContainsKey("cpu"))
                    { data["cpu"].Add(part); break; }
                    data["cpu"] = new List<computerParts> { part };
                    break;

                case "memory":
                    if (data.ContainsKey("memory"))
                    { data["memory"].Add(part); break; }
                    data["memory"] = new List<computerParts> { part };
                    break;

                case "gpu":
                    if (data.ContainsKey("gpu"))
                    { data["gpu"].Add(part); break; }
                    data["gpu"] = new List<computerParts> { part };
                    break;

                case "storage":
                    if (data.ContainsKey("storage"))
                    { data["storage"].Add(part); break; }
                    data["storage"] = new List<computerParts> { part };
                    break;

                case "display":
                    if (data.ContainsKey("display"))
                    { data["display"].Add(part); break; }
                    data["display"] = new List<computerParts> { part };
                    break;

                case "mouse":
                    if (data.ContainsKey("mouse"))
                    { data["mouse"].Add(part); break; }
                    data["mouse"] = new List<computerParts> { part };
                    break;

                case "keyboard":
                    if (data.ContainsKey("keyboard"))
                    { data["keyboard"].Add(part); break; }
                    data["keyboard"] = new List<computerParts> { part };
                    break;

            }
        }
        return data;
    }

    public static Dictionary<string, List<computerParts>> sortAddedPart(
        Dictionary<string, List<computerParts>> data, computerParts newPart)
    {
        if (!data.Keys.ToArray().Contains(newPart.getTypeValue().ToLower()))
        { println($"Type \"{newPart.getTypeValue()}\" is not a valid type in our database!"); return data; }
        data[newPart.getTypeValue().ToLower()].Add(newPart);
        return data;
    }
}


/*
    if (data.ContainsKey(""))
    { data[""].Add(part); break; }
    data[""] = new List<computerParts> { part };
    break;
*/