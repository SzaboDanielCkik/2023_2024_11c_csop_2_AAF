using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_05_10_Vektorok
{
    class Program
    {
        static List<Vektor> vektorok = new List<Vektor>();
        static List<Vektor> generalasok = new List<Vektor>();

        static void Main(string[] args)
        {
            //Proba();
            VektorGeneralas(1000);
            
            vektorok = Fajlbeolvasas("vektorok.csv");
            generalasok = Fajlbeolvasas("generalt.csv");

            Console.WriteLine("Vektorok átlagának hossza: " + AtlagHossz(vektorok));

            Console.ReadLine();
        }

        static double AtlagHossz(List<Vektor> lista)
        {
            double osszeg = 0;
            for (int i = 0; i < lista.Count; i++)
                osszeg += lista[i].Hossz();
            return osszeg / lista.Count;
        }

        static void VektorGeneralas(int db)
        {
            StreamWriter g = new StreamWriter("generalt.csv");
            for (int i = 0; i < db; i++)
            {
                g.WriteLine(SzamGeneralas(2001,-1000) + ";" + SzamGeneralas(2001, -1000));
            }
            g.Close();
        }

        static double SzamGeneralas(int a, int b)
        {
            Random r = new Random();
            return r.NextDouble() * a - b;
        }

        static List<Vektor> Fajlbeolvasas(string utvonal)
        {
            List<Vektor> lista = new List<Vektor>();
            StreamReader f = new StreamReader(utvonal);

            while (!f.EndOfStream)
            {
                Vektor sv = new Vektor(f.ReadLine());
                lista.Add(sv);
            }
            f.Close();

            return lista;
        }

        static void Proba()
        {
            Vektor v = new Vektor(3, 4);
            Console.WriteLine(v.AlphaFok());
            Console.WriteLine(v.Meredekseg());
            Console.WriteLine(v.Hossz());

            Console.WriteLine(v.Nyujtas(1));
            Console.WriteLine(v.Hossz());
        }
    }
}
