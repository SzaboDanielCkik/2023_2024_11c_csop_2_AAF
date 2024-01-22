using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_01_11_GyakorlasKockadobas
{
    class Program
    {
        static List<int> kockadobasok = new List<int>();
        static int[] statisztika = new int[6];

        static void Main(string[] args)
        {
            /* Szimuláljunk egy kockadobást és nézzük meg, hogy tényleg egyenlő valószínűséggel dobjuk ki a számokat!
             * Metódus: Feltölt egy n elemű listát kockadobással (6 oldalú kocka)!
             * Metódus: Egy szám hányszor fordult elő a dobások alkalmával!
             * Feladat1: 10 dobásonként, hogyan alakulnak a számok! 
             * Feladat2: Készítsen egy diagrammot a megjelenítéshez!*/


            ListaFeltoltes();
            StatisztikaKeszites();
            TombKiiratas();

            KoordinataRendszer();
            DiagramAbrazolas();


            Console.ReadLine();

        }

        static void DiagramAbrazolas()
        {
            int egyesDb = statisztika[0];
            for (int i = 0; i < egyesDb; i++)
            {
                Console.SetCursorPosition(7, 14-i);
                Console.Write("X");
            }
            int kettesDb = statisztika[1];
            for (int i = 0; i < kettesDb; i++)
            {
                Console.SetCursorPosition(9, 14 - i);
                Console.Write("X");
            }
        }

        static void KoordinataRendszer()
        {
            Random r = new Random();
            // y - vertikális tengely
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(5,5+i);
                Console.Write("|");
            }
            // x - horizontális tengely
            for (int i = 0; i < 20; i++)
            {
                Console.SetCursorPosition(i, 15);
                Console.Write("-");
            }
            // x tengely megjelölése
            for (int i = 1; i < 7; i++)
            {
                Console.SetCursorPosition(5 + (i * 2), 16);
                Console.Write(i);
            }

        }

        static void TombKiiratas()
        {
            for (int i = 0; i < statisztika.Length; i++)
                Console.Write(statisztika[i] + " ");
        }

        static void StatisztikaKeszites()
        {
            // 123456
            // 012345
            for (int i = 0; i < kockadobasok.Count; i++)
            {
                int index = kockadobasok[i] - 1;
                statisztika[index]++;
            }
        }

        static void ListaFeltoltes()
        {
            Console.Write("Adja meg hány dobást szimuláljunk: ");
            int n = Convert.ToInt32(Console.ReadLine());
            DobasokGeneralasa(n);
        }

        static void DobasokGeneralasa(int n)
        {
            Random r = new Random();
            for (int i = 0; i < n; i++)
                kockadobasok.Add(r.Next(1, 7));
        }
    }
}
