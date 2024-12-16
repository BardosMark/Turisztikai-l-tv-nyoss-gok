namespace Turisztikai_látványosságok
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Muzeum muzeum = new Muzeum("Magyarország", "Budapest", "Szépművészeti Múzeum", 9, 18, "Művészet", true, 2000);
            Console.WriteLine($"Csoportos ár 15 főre: {muzeum.CsoportosKedvezmeny(15)} Ft");

            
            Strand strand = new Strand("Magyarország", "Siófok", "Aranypart Strand", 8, 20, false, 1500);
            strand.CsuszdaHozzaad("Óriás csúszda");
            strand.CsuszdaHozzaad(new List<string> { "Hullám csúszda", "Gyerek csúszda" });
            Console.WriteLine($"Csúszdák száma: {strand.Csuszdak.Count}");

            Gyogyfurdo gyogyfurdo = new Gyogyfurdo("Magyarország", "Hévíz", "Hévízi Tófürdő", 7, 19, true, 2500, 14, true);
               Console.WriteLine($"Gyógyfürdő korhatára: {gyogyfurdo.Korhatar} év");
        }
    }

}
