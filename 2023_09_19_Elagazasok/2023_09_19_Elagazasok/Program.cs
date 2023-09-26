using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_19_Elagazasok
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Elágazások
             * ha(feltétel(ek))
             *      szekvencia;
             *      
             * if(feltétel(ek))
             * { // egy utasítás esetén a zárójel elhagyható.
             *      Szekvencia;
             * }
             * 
             * ha(feltétel(ek))
             *      szekvencia1;
             * különben
             *      szekvencia2;
             * 
             * if(feltétel(ek))
             * {
             *      Szekvencia1;
             * }
             * else
             * {
             *      Szekvencia2;
             * }
             * 
             * if(feltétel(ek))
             *      Szekvencia1;
             * else if(feltétel(ek))
             *      Szekvencia2;
             * ....
             * else
             *      SzekvenciaN;
             *      
             *      
             * switch(változó)
             * {
             *      case érték1: Szekvencia1;
             *          break;
             *      case érték2: Szekvencia2;
             *          break;
             *      case érték3: Szekvencia2;
             *          break;
             *      case érték4: Szekvencia2;
             *          break;
             *      default: SzekvenciaN;
             *          break;
             * }
             */

            Console.Write("Adjon meg egy napot: ");
            string nap = Console.ReadLine();
            switch (nap)
            {
                case "hétfő": Console.WriteLine("raguleves");
                    break;
                case "kedd":
                    Console.WriteLine("rántott husi");
                    break;
                default: Console.WriteLine("Hibás napot adott meg.");
                    break;
            }
            // HF pdf-ből 7-9.

            // HF pdf-ből 10-13 

            // Generálj ki két véletlen számot [-10,10] között. Szorozd össze a két értéket. Ha a szorzat kiesik az intervallumból, akkor ezt jelezzük a felhasználónak. Ha az intervallumon belül van, akkor írassuk ki a szorzat értékét!

            Random r = new Random();
            int a = r.Next(-10, 11);
            int b = r.Next(-10, 11);
            int szorzat = a * b;
            Console.WriteLine(a + " " + b);
            if (szorzat >= -10 && szorzat <= 10)
            {
                Console.WriteLine("A szorzat: " + szorzat);
            }
            else
            {
                Console.WriteLine("A szorzat nincs benne az intervallumba.");
            }

            // Az ékezet betűket szeretném lecserélni. Kérjen be a felhasználótól egy ékezetes betűt és írassa ki ékezet nélkül! Ha nem jó betűt adott meg, jelezze a felhasználónak!
            //á é í ó ö ő ú ü ű
            Console.Write("Adjon meg egy ékezetes betűt: ");
            string betu = Console.ReadLine();
            switch (betu)
            {
                case "á": Console.WriteLine("a"); break;
                case "é": Console.WriteLine("e"); break;
                case "í": Console.WriteLine("i"); break;
                case "ó": Console.WriteLine("o"); break;
                case "ö": Console.WriteLine("o"); break;
                case "ő": Console.WriteLine("o"); break;
                case "ú": Console.WriteLine("u"); break;
                case "ü": Console.WriteLine("u"); break;
                case "ű": Console.WriteLine("u"); break;
                default: Console.WriteLine("Nem ékezetes betűt adott meg!"); break;
            }

            // HF 11-12 - Farenheit - C

            double F = 126;
            double C = (F-32)/1.8;
            Console.WriteLine("{0} F° = {1} C°", F, C);

            C = 52.4;
            F = C * 1.8 + 32;
            Console.WriteLine("{0} C° = {1} F°", C, F);


            Console.ReadLine();
        }
    }
}
