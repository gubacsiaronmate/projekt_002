// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
using static Util.typeConversion;
using dataStorage;
namespace dataSearch;

class dataSearch
{
    public static List<string> searchDatabase(string keyword, Dictionary<string, List<computerParts>> data)
    {
        List<string> foundItems = new();
        string[] dataKeys = data.Keys.ToArray();
        if (dataKeys.Contains(keyword.ToLower()))
        {
            foreach (var part in data[keyword])
            {
                if (data[keyword].Count == 0)
                { foundItems.Add("This category has no parts! You may add new parts to this category in the add parts menu."); }
                else if (data[keyword].Count == 1)
                { foundItems.Add(part.ToSinglePrintString()); }
                else { foundItems.Add(part.ToMassPrintString()); }
            }
            return foundItems;
        }

        foreach (var key in dataKeys)
        {
            List<computerParts> results = data[key].Where(part =>
                part.getNameValue().Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                String(part.getPriceValue()).Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
            foreach (var part in results)
            {
                if (results.Count == 0)
                { foundItems.Add("There are no parts in the database that match this search term! You may add new parts to this category in the add parts menu."); }
                else if (results.Count == 1)
                { foundItems.Add(part.ToSinglePrintString()); }
                else { foundItems.Add(part.ToMassPrintString()); }
            }
        }
        return foundItems;
    }
}