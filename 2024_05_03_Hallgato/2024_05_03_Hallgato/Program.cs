using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_05_03_Hallgato
{
    class Program
    {
        static List<Hallgato> hallgatok = new List<Hallgato>();
        static void Main(string[] args)
        {
            //Fajlbeolvasas("hallgatok.txt");
            //1. Hány olyan tanuló van akik nem léphetnek évfolyamot?
            //2. Van-e olyan harmadik féléves tanuló, akinek a kredit száma megegyezik a legtöbb kredittel?
            //3. Rendezd a tanulókat évfolyam szerint növekvő sorrendbe!

            Proba();
            Fajlbeolvasas();
            Console.ReadLine();
        }

        static void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("hallgatok.txt");
            f.ReadLine();
            while (!f.EndOfStream)
            {
                string[] st = f.ReadLine().Split('\t');
                Hallgato sv = new Hallgato(st[0], Convert.ToInt32(st[1]), Convert.ToInt32(st[2]));
                hallgatok.Add(sv);
            }
            f.Close();
        }

        static void Proba()
        {
            Hallgato h1 = new Hallgato("HoEmbeR");
            Hallgato h2 = new Hallgato("madArIJEsztO", 2, 23);

            Console.WriteLine(h1.Evfolyam+" "+h1.Kreditszam);

            Console.WriteLine(h1.ToString());
            Console.WriteLine(h2.ToString());
            Console.WriteLine();

            h1.TargyFelvesz(5);
            h2.TargyFelvesz(5);
            
            Console.WriteLine(h1.ToString());
            Console.WriteLine(h2.ToString());
            Console.WriteLine();

            Console.WriteLine(h1.Vizsgazik());
            Console.WriteLine(h2.Vizsgazik());

            Console.WriteLine(h1.ToString());
            Console.WriteLine(h2.ToString());
            Console.WriteLine();


            h1.TargyFelvesz(3);
            Console.WriteLine(h1.ToString());
            Console.WriteLine(h2.ToString());
            Console.WriteLine();

            Console.WriteLine(h1.Vizsgazik());
            Console.WriteLine(h2.Vizsgazik());

            Console.WriteLine(h1.ToString());
            Console.WriteLine(h2.ToString());
            Console.WriteLine();

        }
    }
}
