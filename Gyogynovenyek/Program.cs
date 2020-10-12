using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gyogynovenyek
{
    class Program
    {
        static List<Gyogynovenykek> Novenyek = new List<Gyogynovenykek>();


        static Dictionary<string, int> Reszek = new Dictionary<string, int>();


        static void Beolvasas()
        {
            StreamReader sr = new StreamReader("noveny.csv");
            while (!sr.EndOfStream)
            {
                Novenyek.Add(new Gyogynovenykek(sr.ReadLine()));
            }
            sr.Close();
        }


        static void elsoFeladat()
        {
            int db = 0;
            for (int i = 0; i < Novenyek.Count; i++)
            {
                db++;
            }
            Console.WriteLine("\n1. feladat: Növények száma: {0}", db);


            //Másik megoldás: int a = Novenyek.Count();
        }


        static void masodikFeladat()
        {
            Console.WriteLine("\n2. feladat: Gyűjthető részek:");
            foreach (var n in Novenyek)
            {
                if (!Reszek.ContainsKey(n.Resz))
                {
                    Reszek.Add(n.Resz, 0);
                }
            }

            foreach (var n in Novenyek)
            {
                Reszek[n.Resz]++;
            }

            foreach (var r in Reszek)
            {
                Console.WriteLine($"{r.Key}: {r.Value}");
            }
        }


        static void harmadikFeladat()
        {
            int max = 0;
            foreach (var n in Novenyek)
            {
                if (max < n.Idotartam)
                {
                    max = n.Idotartam;
                }
            }

            foreach (var n in Novenyek)
            {
                if (max == n.Idotartam)
                {
                    Console.WriteLine("\n3. feladat: A legtöbb idő, amíg gyűjthető: {0} Növények: {1}", max, n.Nev);
                }
            }
        }


        static void negyedikFeladat()
        {
            double szum = 0;
            double atlag = 0;
            foreach (var n in Novenyek)
            {
                szum = szum + n.Idotartam;
            }
            atlag = szum / Novenyek.Count();
            Console.WriteLine("\n4. feladat: Átlagos gyűjthető időtartam: {0}", atlag);
        }


        static void Main(string[] args)
        {
            Beolvasas();
            //foreach (var n in Novenyek)
            //{
            //    Console.WriteLine($"{n.Nev} - {n.Resz} - {n.Kezd} - {n.Veg} - {n.Idotartam}");
            //}

            elsoFeladat();
            masodikFeladat();
            harmadikFeladat();
            negyedikFeladat();

            Console.ReadKey();
        }
    }
}
