// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
using dataStorage;
namespace Main;

class dataSorter
{
    public static Dictionary<String, List<computerParts>> sortData()
    {
        dataReader.dataReader dr = new();
        List<computerParts> partialData = dr.readData("database.txt");
        Dictionary<String, List<computerParts>> data = new();
        foreach (computerParts part in partialData)
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
}


/*
    if (data.ContainsKey(""))
    { data[""].Add(part); break; }
    data[""] = new List<computerParts> { part };
    break;
*/