using static Util.Base;
using dataStorage;

dataReader.dataReader dr = new();
List<computerParts> data = dr.readData("database.txt");
foreach (computerParts parts in data)
{
    println(parts);
}