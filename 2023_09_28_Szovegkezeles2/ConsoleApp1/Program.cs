using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string szoveg = "kalapács";
            Console.WriteLine(szoveg);
            Console.Write("Adjon meg egy betű, amire lecserélem az 'á' karaktert: ");
            char c = Convert.ToChar(Console.ReadLine());
            string ujszoveg = "";

            for (int i = 0; i < szoveg.Length; i++)
            {
                if (szoveg[i] == 'a')
                {
                    //szoveg[i] = c;
                    ujszoveg += c;
                }
                else
                {
                    ujszoveg += szoveg[i];
                }
            }
            Console.WriteLine(ujszoveg);

            // A szó visszafele
            string forditott = "";
            for (int j = szoveg.Length - 1; j >= 0; j--)
            {
                //Console.Write(szoveg[j]);
                forditott += szoveg[j];
            }
            Console.WriteLine(forditott);

            //Van-e benne bizonyos betű.

            int index = 0;
            while (index < szoveg.Length && szoveg[index] != c)
                index++;
            if (index < szoveg.Length)
            {
                Console.WriteLine("Van a szövegben {0} betű", c);
            }
            else
            {
                Console.WriteLine("Nincs a szövegben {0} betű", c);
            }

            Console.ReadLine();
        }
    }
}
