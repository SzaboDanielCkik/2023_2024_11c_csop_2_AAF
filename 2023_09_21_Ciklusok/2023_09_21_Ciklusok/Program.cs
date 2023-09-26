using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_21_Ciklusok
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ciklusok
             * Számlálós
             * 
             * ciklus i = kezdőértéktől vég értékig léptetés
             *      Ciklus mag
             * ciklus vége
             * 
             * for(int i = kezdőérték; i<végérték; i+=léptetés)
             * {// Egy utasítás esetén a zárójel elhagyható.
             *      Ciklusmag
             * }
             * 
             * Elől tesztelős
             * ciklus amíg(benmaradási feltétel(ek))
             *      Ciklus mag;
             * ciklus vége
             * 
             * while(benmaradási feltétel(ek))
             * {
             *      Ciklus mag;
             * }
             * 
             * Hátul tesztelős
             * 
             * Csináld
             *      Ciklus mag;
             * amíg(benmaradási feltétel(ek));
             * 
             * do{
             *      Ciklus mag;
             * }while(benmaradási feltétel(ek));*/

            // Irasd ki az első 30 pozitív páros számot!
            for (int i = 2; i < 61; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // i++; i = i+1; i += 1;
            for (int i = 1; i < 31; i++)
            {
                Console.Write(i*2 + " ");
            }
            Console.WriteLine();
            //Írass ki 15 db véletlen számot [50, 1000] között úgy, hogy a szám 10-zel osztható legyen!

            Random r = new Random();
            for (int i = 0; i < 15; i++)
            {
                Console.Write(r.Next(5, 101) * 10 + " ");
            }
            Console.WriteLine();

            int db = 1;
            do {
                int vel = r.Next(50, 1001);
                if (vel % 10 == 0)
                {
                    db++;
                    Console.Write(vel + " ");
                }
            } while (db<=15);
            Console.WriteLine();
            // Generálj ki véletlen számokat [50,1000] addig 
            // amíg 7-tel oszthatót nem kapunk!

            int a;
            do
            {
                a = r.Next(50, 1001);
                Console.Write(a + " ");
            }
            while (a % 7 != 0);


            int szam = r.Next(50, 1001);
            while (szam % 7 != 0)
            {
                Console.Write(szam + " ");
                szam = r.Next(50, 1001);
            }
            Console.WriteLine(szam);

            // 26-28

            Console.ReadLine();
        }
    }
}
