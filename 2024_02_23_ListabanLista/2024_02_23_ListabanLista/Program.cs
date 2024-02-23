using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_02_23_ListabanLista
{
    class Program
    {
        static List<List<int>> listak = new List<List<int>>();
        static void Main(string[] args)
        {
            ListakFeltoltese();
            ListakKiiratasa();

            // FVek
            // Adja meg hányadik lista a leghosszabb!
            // Adja meg azt a listát, amelyik tartalmaz 13-al osztható számot! Ha nincs írja ki, hogy nincs!
            // Adja meg a legkisebb elem indexét! (sorát és elemszámát)

            Console.ReadLine();
        }

        static void ListakKiiratasa()
        {
            for (int i = 0; i < listak.Count; i++)
            {
                for (int j = 0; j < listak[i].Count; j++)
                {
                    Console.Write(listak[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void ListakFeltoltese()
        {
            Random r = new Random();
            int sor = 6;
            //int[] elemszam = new int[] { 4, 7, 1, 3, 12, 4 };
            int elemszam = r.Next(5,12);
            for (int i = 0; i < sor; i++)
            {
                List<int> segedLista = new List<int>();
                segedLista.Clear();
                for (int j = 0; j < elemszam; j++)
                {
                    segedLista.Add(r.Next(10,100));
                }
                listak.Add(segedLista);
            }

        }
    }
}
