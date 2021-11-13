using System;
using System.Collections.Generic;
using System.IO;

namespace Versenyke
{   
    class szamocskak
    {
        public int szam;
    }
    class Program
    {   
            static List<szamocskak> adatok = new List<szamocskak>();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            StreamReader sr = new StreamReader("szamok1.txt");

            string egysor;
            while ((egysor = sr.ReadLine()) != null)
            {
                string[] egysordarabok = egysor.Split(' ');
                szamocskak egyadat = new szamocskak();

                egyadat.szam = Convert.ToInt32(egysor);


                adatok.Add(egyadat);
            }
            sr.Close();

            Console.WriteLine("Beolvasott adatok szama: {0}", adatok.Count);

            //1. feladat
            //a) Hányszor fordul elő az 5-ös számjegy a fájlban tárolt számok között? (2 pont)
            int dex=0;
            int counter=0;
            for (dex = 0; dex < adatok.Count; dex++)
                if (adatok[dex].szam == 5)
                    counter++;
            Console.WriteLine("5 szam darabja: {0}", counter);
            //1. feladat
            //b) Hány sora lesz a táblázatnak, ha minden sora 91 db számjegyet tartalmaz? (1 pont)

            StreamWriter sw = new StreamWriter("91es.txt");
            int soros = 0;
            for (dex = 0; dex < adatok.Count; dex++)
            {

                        sw.Write("{0} ", Convert.ToString(adatok[dex]));
                        if ((dex+1)%91==0)
                {
                    sw.WriteLine();
                    soros++;
                }

            }
            Console.WriteLine("Sorok szama a 91es tablazatban: {0}", soros);

            sw.Close();

            //c) Mennyi a fájlban tárolt számok összege-különbsége, ha fenti eljárást követjük? (5 pont)






        }
    }
}
