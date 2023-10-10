using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_10_04_Szovegkezeles3
{
    class Program
    {
        static void Main(string[] args)
        {
            //HF 14-25 feladatok

            // Kérjen be a felhasználótól egy dupla betűt. (Hossza = 2)
            // Ha felhasználó nem két betűt adott meg, akkor addig kérje be a program, amíg jól nem adja meg.
            // Adott egy szöveg, és döntse el, hogy van-e a szövegben ez a dupla betű!
            // szöveg: Senki sem tökéletes de a programozók átkozottúl közel állnak hozzá.

            string dupla;
            do
            {
                Console.Write("Adjon meg egy dupla betűt: ");
                dupla = Console.ReadLine();
            } while (dupla.Length != 2);

            string szoveg = "Senki sem tökéletes de a programozók átkozottúl közel állnak hozzá";
            Console.WriteLine(szoveg);
            int i = 0;
            while (i < szoveg.Length-1 && 
                !(szoveg[i] == dupla[0] && szoveg[i+1] == dupla[1]))
            {
                i++;
            }
            if (i < szoveg.Length-1)
            {
                Console.WriteLine("Van benne {0} dupla betű.", dupla);
            }
            else
            {
                Console.WriteLine("Nincs benne {0} dupla betű.",dupla);
            }

            // Ascii kód
            Console.WriteLine(szoveg[0]+szoveg[1]);
            // karakter ábrázolása, Ascii kód
            //S = 83, e = 101 
            char karakter = 'ő';
            Console.WriteLine(karakter);
            int karakterkod = karakter;
            Console.WriteLine(karakterkod);

            int kk = 100;
            Console.WriteLine(kk);
            char k = (char)kk;
            Console.WriteLine(k);

            /* HF Kérje be a felhasználótól a teljes nevét!
             * (Feltételezhetjük, hogy két szóból áll)
             * pl Kis Pista
             * Generálj ki neki egy felhasználó nevet,
             * a két szó első három betűjéből (kisbetűk legyenek)
             * pl. kispis
             * Generálj ki mellé 10 hosszú kis és nagy betűkből
             * és karakterekből álló jelszót! Vegyesen legyen!*/


            Console.ReadLine();
        }
    }
}
