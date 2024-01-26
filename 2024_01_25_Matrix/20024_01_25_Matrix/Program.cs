using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20024_01_25_Matrix
{
    class Program
    {
        static int[,] tomb = new int[4, 6];
        static void Main(string[] args)
        {
            /* Mátrix - 2d Tömb - [sor, oszlop] - Típus
             * Típus[,] tombNev;
             * Típus[,] tombNev = new típus[sor,oszlop];
             * típus[,] tombNev = new típus[,]{{1,2,3},{4,5,6},{7,8,9}};
             * */

            /* Eljárás: Feltölt egy 4x6-os mátrixot véletlen két jegyű számokkal!
             * Fv: Megadja a számok átlagát!
             * Fv: Megadja a számok legnagyobb értékét!
             * metódus: A legkisebb szám helyének meghatározása (sor, oszlop)
             * fv: Van-e a számok között 13-al osztható?
             HF: 
                metódus: írassa ki a sorok átlagát!
                metódus: írassa ki az oszlopok legnagyobb értékét!
                eljárás: új mátrixba tükrözd az eredeti mátrix értékit! (ami sor volt oszlop lesz)
                szorgalmi: Add meg a számok determinánsát!
                
             */

            //Alapok();

            MatrixFeltoltese(tomb);
            MatrixKiir(tomb);
            Feladat1();
            Feladat2();
            Feladat3();
            Feladat4();

            Console.ReadLine();
        }

        static void Feladat4()
        {
            Console.WriteLine("4. feladat");
            int a = 17;
            if (VaneSzammalOszthato(tomb, a))
            {
                Console.WriteLine("Van {0} számmal osztható.", a);
            }
            else
            {
                Console.WriteLine("Nincs {0} számmal osztható.", a);
            }
        }

        static bool VaneSzammalOszthato(int[,] mtomb, int a)
        {
            int i = 0;
            int j = 0;
            //bool vane = false;
            while (i < mtomb.GetLength(0) /*&& !vane*/)
            {
                j = 0;
                while (j < mtomb.GetLength(1) && mtomb[i, j] % a != 0)
                    j++;
                if (j < mtomb.GetLength(1))
                    //vane = true;
                    return true;
                else
                    i++;
            }
            //return vane;
            return false;
        }

        static void Feladat3()
        {
            Console.WriteLine("3. feladat");
            //int[] t = LegkisebbIndexek(tomb);
            //Console.WriteLine(t[0]+" "+t[1]);
            int mins, mino;
            (mins, mino) = LegkisebbIndexek(tomb);
            Console.WriteLine(mins + " " + mino);
        }

        static (int, int) LegkisebbIndexek(int[,] mtomb)
        {
            int minsor = 0;
            int minoszlop = 0;
            for (int i = 0; i < mtomb.GetLength(0); i++)
            {
                for (int j = 0; j < mtomb.GetLength(1); j++)
                {
                    if (mtomb[i, j] < mtomb[minsor, minoszlop])
                    {
                        minsor = i;
                        minoszlop = j;
                    }
                }
            }
            //Console.WriteLine(minsor + " " + minoszlop);
            //return minsor + " " + minoszlop;
            //int[] minSorOszlop = new int[] { minsor, minoszlop };
            //return minSorOszlop;3
            return (minsor, minoszlop);
        }

        static void Feladat2()
        {
            Console.WriteLine("\n2. feladat");
            Console.WriteLine("A legnagyobb szám: " + Maximum(tomb));
        }

        static int Maximum(int[,] mtomb)
        {
            int maxe = mtomb[0, 0];
            for (int i = 0; i < mtomb.GetLength(0); i++)
            {
                for (int j = 0; j < mtomb.GetLength(1); j++)
                {
                    if (maxe < mtomb[i, j])
                        maxe = mtomb[i, j];
                }
            }
            return maxe;
        }

        static void Feladat1()
        {
            Console.WriteLine("\n1. feladat");
            Console.WriteLine("A számok átlaga: " + Math.Round( Atlag(tomb), 3));
        }

        static double Atlag(int[,] mtomb)
        {
            double osszeg = 0;
            for (int i = 0; i < mtomb.GetLength(0); i++)
            {
                for (int j = 0; j < mtomb.GetLength(1); j++)
                {
                    osszeg += mtomb[i, j];
                }
            }
            return osszeg / mtomb.Length;
        }

        static void MatrixKiir(int[,] mtomb)
        {
            for (int i = 0; i < mtomb.GetLength(0); i++)
            {
                for (int j = 0; j < mtomb.GetLength(1); j++)
                {
                    Console.Write(mtomb[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void MatrixFeltoltese(int[,] mtomb)
        {
            Random r = new Random();
            for (int i = 0; i < mtomb.GetLength(0); i++)
            {
                for (int j = 0; j < mtomb.GetLength(1); j++)
                {
                    mtomb[i, j] = r.Next(10, 100);
                }
            }
        }

        static void Alapok()
        {
            //Mátrix deklarálása és inicializálása
            int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //Mátrix első eleme
            Console.WriteLine("első elem: " + matrix[0, 0]);

            //Mátrix eleminek kiíratása
            //int[,] matrix = new int[3,5];
            //matrix.GetLength(0) -> 3
            //matrix.GetLength(1) -> 5

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                { 
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }


        }
    }
}
