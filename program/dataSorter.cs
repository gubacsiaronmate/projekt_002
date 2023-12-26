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
                    if (data.ContainsKey("MotherBoard"))
                    { data["MotherBoard"].Add(part); break; }
                    data["MotherBoard"] = new List<computerParts> { part };
                    break;

                case "cpu":
                    if (data.ContainsKey("CPU"))
                    { data["CPU"].Add(part); break; }
                    data["CPU"] = new List<computerParts> { part };
                    break;

                case "memory":
                    if (data.ContainsKey("Memory"))
                    { data["Memory"].Add(part); break; }
                    data["Memory"] = new List<computerParts> { part };
                    break;

                case "gpu":
                    if (data.ContainsKey("GPU"))
                    { data["GPU"].Add(part); break; }
                    data["GPU"] = new List<computerParts> { part };
                    break;

                case "storage":
                    if (data.ContainsKey("Storage"))
                    { data["Storage"].Add(part); break; }
                    data["Storage"] = new List<computerParts> { part };
                    break;

                case "display":
                    if (data.ContainsKey("Display"))
                    { data["Display"].Add(part); break; }
                    data["Display"] = new List<computerParts> { part };
                    break;

                case "mouse":
                    if (data.ContainsKey("Mouse"))
                    { data["Mouse"].Add(part); break; }
                    data["Mouse"] = new List<computerParts> { part };
                    break;

                case "keyboard":
                    if (data.ContainsKey("Keyboard"))
                    { data["Keyboard"].Add(part); break; }
                    data["Keyboard"] = new List<computerParts> { part };
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