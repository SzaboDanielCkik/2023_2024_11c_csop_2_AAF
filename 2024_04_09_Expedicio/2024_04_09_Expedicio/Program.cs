using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2024_04_09_Expedicio
{
    class Program
    {
        static List<Vetel> adasok = new List<Vetel>();
        static void Main(string[] args)
        {
            Fajlbeolvasas();
            Feladat2();
            Feladat3();

            Console.ReadLine();
        }

        static void Feladat3()
        {
            Console.WriteLine("3. feladat");
            int index = FarkasosAdas();
            if(index>-1)
                Console.WriteLine("{0}.nap {1}.rádióamatőr", 
                adasok[index].nap, adasok[index].amator);
            else
                Console.WriteLine("Nem volt az üzenetekben farkas");
        }

        static int FarkasosAdas()
        {
            int i = 0;
            //while (i < adasok.Count && !VaneBenneFarkas(adasok[i].adas))
            while (i < adasok.Count && !adasok[i].adas.Contains("farkas"))
                i++;
            if (i < adasok.Count)
                return i;
            else 
                return -1;
        }

        static bool VaneBenneFarkas(string adas)
        {
            int i = 0;
            while (i < adas.Length - 5 && !(adas[i]=='f' && adas[i+1]=='a' && adas[i+2] == 'r' && adas[i+3] == 'k' && adas[i + 4] == 'a' && adas[i + 5] == 's'))
                i++;
            return i < adas.Length - 5;
        }

        static void Feladat2()
        {
            Console.WriteLine("2. feladat");
            Console.WriteLine("Az első üzenet rögzítője: "+adasok[0].amator
              /*adasok.First().amatar*/);
            Console.WriteLine("Az utolsó üzenet rögzítője: "+
                adasok[adasok.Count-1].amator
                /*adasok.Last().amator*/);
        }

        static void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("veetel.txt");

            while (!f.EndOfStream)
            {
                string[] st = f.ReadLine().Split(' ');
                string adas = f.ReadLine();
                Vetel sv = new Vetel(Convert.ToInt32(st[0]), Convert.ToInt32(st[1]), adas);
                adasok.Add(sv);
            }

            f.Close();
        }
    }

    struct Vetel
    {
        //Adattagok, mezők, jellemzők, tulajdonságok, ...
        public int nap, amator;
        public string adas;

        //Konstruktor
        public Vetel(int nap, int amator, string adas)
        {
            this.nap = nap;
            this.amator = amator;
            this.adas = adas;
        }

        //metódusok
        public override string ToString()
        {
            return nap+" "+amator+" "+adas;
        }
    }

}
