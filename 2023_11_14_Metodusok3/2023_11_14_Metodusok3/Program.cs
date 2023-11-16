using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_11_14_Metodusok3
{
    class Program
    {

        static int[] tomb1;
        static int[] tomb2;
        static Random r = new Random();

        static void Main(string[] args)
        {
            /* Töltsön fel két [10,99] közötti véletlen számú tömböt [1,200] közötti számokkal, ehhez írjon egy tömbfeltöltés eljárást, úgy a folyamat függjön egy bemeneti tömb értékétől!
             * Írjon egy függvényt, amit kiszámolja egy tömb átlagát! (kerekítés nélkül) Majd írassa ki a tömbök átlagát 2 tizedesjegyre kerekítve!
             * Írjon egy megszámlálás metódust, ami megadja hány darab átlagtól kisebb szám van!
               Írjon metódusot, ami visszadja a tömb legkisebb elemének indexét! Írassa kis a két tömb legkisebb elemeit!
               Írjon egy metódust, ami megadja, hogy hány olyan szám van, ami a legkisebb szám többszöröse!
               
            x egész szám>0, k pozitív egész szám
            x Többszöröse -> x*k

            HF
            Írj metódust, ami megnézi, hogy van-e a tömbben az átlag egészre kerekített értéke?

             */


            Feladat1();
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();

            Console.ReadLine();
        }

        static void Feladat5()
        {
            int db1 = MinErtekTobbszoroseiDb(tomb1);
            int db2 = MinErtekTobbszoroseiDb(tomb2);

            Console.WriteLine("{0} szám van az első tömbben, ami a legkisebb szám többszöröse.", db1);
            Console.WriteLine("{0} szám van a második tömbben, ami a legkisebb szám többszöröse.", db2);
        }

        static int MinErtekTobbszoroseiDb(int[] tomb)
        {
            int mini = MinimumIndex(tomb);
            int db = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % tomb[mini] == 0)
                    db++;
            }
            return db;
        }

        static void Feladat4()
        {
            int minIndex1 = MinimumIndex(tomb1);
            int minIndex2 = MinimumIndex(tomb2);
            Console.WriteLine("A legkisebb elem értéke: az első tömbben: {0}", tomb1[minIndex1]);
            Console.WriteLine("A legkisebb elem értéke: a  második tömbben: {0}", tomb2[minIndex2]);
        }

        static int MinimumIndex(int[] tomb)
        {
            int index = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] < tomb[index])
                    index = i;
            }
            return index;
        }

        static void Feladat3()
        {
            int db1 = AtlagnalKisebbDarabszam(tomb1);
            int db2 = AtlagnalKisebbDarabszam(tomb2);

            Console.WriteLine("{0} darab átlagtól kisebb szám van az első tömbben.", db1);
            Console.WriteLine("{0} darab átlagtól kisebb szám van a második tömbben.", db2);
        }

        static int AtlagnalKisebbDarabszam(int[] tomb)
        {
            double atlag = Atlag(tomb);
            int db = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] < atlag)
                {
                    db++;
                }
            }
            return db;
        }

        static void Feladat2()
        {
            Console.WriteLine("1. tömb átlaga: " + Atlag(tomb1));
            Console.WriteLine("2. tömb átlaga: " + Atlag(tomb2));
        }

        static double Atlag(int[] tomb)
        {
            double osszeg = 0;
            for (int i = 0; i < tomb.Length; i++)
                osszeg += tomb[i];
            return osszeg / tomb.Length;
        }

        static void Feladat1()
        {
            //Random r = new Random();
            int db1 = r.Next(10, 100);
            tomb1 = new int[db1];
            int db2 = r.Next(10, 100);
            tomb2 = new int[db2];

            Tombfeltoltes(tomb1);
            Tombfeltoltes(tomb2);

            TombKiir(tomb1);
            TombKiir(tomb2);
        }

        static void TombKiir(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Tombfeltoltes(int[] tomb)
        {            
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(1, 201);
            }
        }
    }
}
