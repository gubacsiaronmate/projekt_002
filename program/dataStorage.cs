// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
namespace dataStorage;

internal class computerParts
{
    private string Type { get; set; }
    private string Name { get; set; }
    private string Parameters { get; set; }
    private int Price { get; set; }

    public computerParts(string type, string name, string parameters, int price)
    {
        Type = type;
        Name = name;
        Parameters = parameters;
        Price = price;
    }

    public string getTypeValue() => Type;
    public string getNameValue() => Name;
    public string getParametersValue() => Parameters;
    public int getPriceValue() => Price;
    
    public string ToMassPrintString() => $"Type: {Type}; Name: {Name}; Parameters: {Parameters}; Price: {Price};";
    
    public string ToSinglePrintString() => $"Type: {Type}\nName: {Name}\nParameters: {Parameters}\nPrice: {Price}";
}