// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
using static Util.typeConversion;
using static Util.Base;
using dataStorage;
namespace applyDiscountNamespace;

class discountClass
{
    public Dictionary<string, List<computerParts>> applyDiscount(Dictionary<string, List<computerParts>> data)
    {
        string[] dataKeys = data.Keys.ToArray();
        int discountPercentage = 1;
        try { discountPercentage = Int(input("Enter discount percentage:  ")); }
        catch (FormatException)
        {
            println("Incorrect format! Please do not use % when entering discount!");
            applyDiscount(data);
        }
        // Console.Write("Enter discount percentage:  ");
        // discountPercentage = Convert.ToInt32(Console.ReadLine());
        string target = input("Enter which category should this discount apply to (enter \"all\" for all):  ").ToLower();
        if (target == "all")
        {
            // part.Price -= (part.Price * discountPercentage) / 100;
            foreach (var key in dataKeys)
            {
                foreach (var part in data[key])
                {
                    part.setPriceValue(part.getPriceValue() - (part.getPriceValue() * discountPercentage) / 100);
                }
            }
        } 
        else if (dataKeys.Contains(target))
        {
            foreach (var part in data[target])
            {
                part.setPriceValue(part.getPriceValue() - (part.getPriceValue() * discountPercentage) / 100);
            }
        }

        return data;
    }
}