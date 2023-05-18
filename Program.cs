using System.Configuration;
using System.IO;
namespace HegyekMo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] szoveg = File.ReadAllLines("C:\\Users\\Mónus Bence\\source\\repos\\HegyekMo2\\HegyekMo2\\hegyekMo.txt");
            List<HegyCsucs> csucsok = new List<HegyCsucs>();

            foreach (var hegy in szoveg.Skip(1)) {
                string[] adatok = hegy.Split(';');
                HegyCsucs ujHegyCsucs = new HegyCsucs(adatok[0], adatok[1], Convert.ToInt32(adatok[2]));
                csucsok.Add(ujHegyCsucs);
            }
            //3. feladat:
            Console.WriteLine($"3. feladat: Hegycsúcsok száma: {csucsok.Count} db");
            //4. feladat:
            Console.WriteLine($"4. feladat: Hegycsúcsok átlagos magassága: {csucsok.Average(x => x.Magassag)} m");
            //5.feladat:
            Console.WriteLine($"5. feladat: {csucsok.Max(x => x.Magassag)} m");
        }
    }
}