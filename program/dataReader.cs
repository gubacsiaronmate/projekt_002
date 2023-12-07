// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
using dataStorage;
using static Util.typeConversion;
namespace dataReader;

class dataReader
{
    public List<computerParts> readData(string filepath)
    {
        FileStream fs = new FileStream(filepath, FileMode.Open);
        StreamReader sr = new StreamReader(fs);
        List<computerParts> data = new();
        while(!sr.EndOfStream)
        {
            /*
            string sor = sr.ReadLine() ?? "";
            string[] resz = sor.Split(',');
            string _nev = resz[0];
            char _nem = Convert.ToChar(resz[1]);
            int _pont = Convert.ToInt32(resz[2]);
            string _szak = resz[3];
            string _nyelv = resz[4];
            Felvetelizo uj = new Felvetelizo(_nev, _nem, _pont, _szak, _nyelv);
            adatok.Add(uj);
            */
            string[] line = sr.ReadLine()!.Split(";");
            data.Add(new computerParts(line[0], line[1], line[2], Int(line[3])));
        }
        sr.Close();
        fs.Close();

        return data;
    }
}