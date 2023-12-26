// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
using static Util.typeConversion;
using static Util.Base;
using dataStorage;
namespace dataWriter;

class dataWriter
{
    public static void addPart()
    {
        println("Enter the details of the new computer part here:");
        computerParts newPart = new(
            input("Type:  "),
            input("Name:  "),
            input("Parameters:  "),
            Int(input("Price in HUF:  "))
        );
        
    }
}