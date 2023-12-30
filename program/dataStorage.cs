// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
using static Util.typeConversion;
using static Util.Base;
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
    
    public void setTypeValue(string newType) => Type = newType;
    public void setNameValue(string newName) => Name = newName;
    public void setParametersValue(string newParameters) => Parameters = newParameters;
    public void setPriceValue(int newPrice) => Price = newPrice;

    public string ToWritableString() => $"{Type};{Name};{Parameters};{Price};";
    
    public string ToMassPrintString() => $"Type: {Type}; Name: {Name}; Parameters: {Parameters}; Price: {Price};";
    
    public string ToSinglePrintString() => $"Type: {Type}\nName: {Name}\nParameters: {Parameters}\nPrice: {Price}";
    
    public static computerParts getNewPart()
    {
        println("Enter the details of the new computer part here:");
        computerParts newPart = new(
            input("Type:  "),
            input("Name:  "),
            input("Parameters:  "),
            Int(input("Price in HUF:  "))
        );
        return newPart;
    }
}