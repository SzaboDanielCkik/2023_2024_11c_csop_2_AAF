using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_26_Szovegkezeles
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Szövegkezelés
             * string - karakterlánc - karaktertömb
             * csak olvasható érték - a karaktereket külön-külön le lehet kérni, de nem változtathatók meg.
             * string szoveg = "kalapács";
             * pl. első karakter: szoveg[0]
             * szoveg hossza: szoveg.Length
             * szoveg[0] = 'A'; Ilyet nem lehet!!!!!
             */
            string szoveg = "kalapács";

            Console.WriteLine(szoveg);
            // szoveg első karaktere
            // szoveg hossza
            // szoveg utolsó karaktere
            // Írassátok ki a betűket egymás alá!

            Console.WriteLine("Az első karakter: " + szoveg[0]);
            int hossz = szoveg.Length;
            Console.WriteLine("A szöveg hossza: " + hossz);
            Console.WriteLine("Az utolsó karakter: " + szoveg[hossz - 1]);

            for (int i = 0; i < szoveg.Length; i++)
            {
                Console.WriteLine(szoveg[i]);
            }

            //Gyűjsd ki a szöveg minden második karakterét!
            // Majd nézd meg, hogy van-e benne a felhasználótól bekért betű!

            // pdf-ből 14-17.
             

            Console.ReadLine();
        }
    }
}
