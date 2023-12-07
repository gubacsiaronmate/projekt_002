// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
namespace dataStorage;

internal abstract class computerParts
{
    private string Type { get; set; }
    private string Name { get; set; }
    private string Parameters { get; set; }
    private int Price { get; set; }

    protected computerParts(string type, string name, string parameters, int price)
    {
        Type = type;
        Name = name;
        Parameters = parameters;
        Price = price;
    }
}