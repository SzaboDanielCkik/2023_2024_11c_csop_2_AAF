using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_11_30_Gyakorlas
{
    class Program
    {
        static Random r = new Random();
        static int[] tomb1 = new int[23];
        static int[] tomb2 = new int[23];
        static void Main(string[] args)
        {
            /* Eljárás: Töltsön fel két 23 elemű tömböt [10,50] között úgy, hogy minden számból csak egy szerepelhet!
             * Feladat1 E: Adja meg mindkét tömb (FV) mediánját!
             * Feladat2 E: Melyek azok a páros számok, amelyek mindkét tömbben szerepelnek?
             * HF : Gyűjtse ki a két tömbből a szűrt páratlan elemeket!
             */

            TombFeltoltes(tomb1);
            TombFeltoltes(tomb2);
            TombKiiratas(tomb1);
            TombKiiratas(tomb2);
            Feladat1();
            //Feladat2();

            Console.ReadLine();
        }

        static void Feladat1()
        {
            Rendezes(tomb1);
            Rendezes(tomb2);
            TombKiiratas(tomb1);
            TombKiiratas(tomb2);
            Console.WriteLine("Az első tömb mediánja: " + Median(tomb1));
            Console.WriteLine("A második tömb mediánja: " + Median(tomb2));
        }

        static double Median(int[] tomb)
        {
            double median;
            if (tomb.Length % 2 == 1)
                median = tomb[tomb.Length  / 2];
            else
            {
                int db = tomb.Length;
                median = (tomb[db / 2] + tomb[db / 2 - 1]) / 2;
            }
            return median;
        }

        static void Rendezes(int[] tomb)
        {
            for (int i = 0; i < tomb.Length - 1; i++)
            {
                for (int j = i + 1; j < tomb.Length; j++)
                {
                    if (tomb[i] > tomb[j])
                    {
                        int sv = tomb[i];
                        tomb[i] = tomb[j];
                        tomb[j] = sv;
                    }
                }
            }
        }

        static void TombKiiratas(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
                Console.Write(tomb[i] + " ");
            Console.WriteLine();
        }

        static void TombFeltoltes(int[] tomb)
        {
            int i = 0;
            while(i<tomb.Length)
            {
                int a = r.Next(10, 51);
                if (!BenneVanE(tomb, a))
                {
                    tomb[i] = a;
                    i++;
                }
            }
        }

        static bool BenneVanE(int[] tomb, int a)
        {
            int i = 0;
            while (i < tomb.Length && tomb[i] != a)
                i++;
            return i < tomb.Length;
        }
    }
}
