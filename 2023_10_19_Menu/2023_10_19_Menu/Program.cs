using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_10_19_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu;
            do
            {
                Console.Clear();
                Console.WriteLine("1. - Két szám megadása");
                Console.WriteLine("2. - A két szám összege");
                Console.WriteLine("3. - A két szám szorzata");
                Console.WriteLine("0. - Kilépés");
                Console.Write("Adjon meg egy menüpontot: ");
                menu = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("be: két szám");
                        break;
                    case 2:
                        Console.WriteLine("összeg");
                        break;
                    case 3:
                        Console.WriteLine("szorzat");
                        break;
                    case 0:
                        Console.WriteLine("kilépés");
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
                Console.ReadLine();
            } while (menu != 0);
        }
    }
}
