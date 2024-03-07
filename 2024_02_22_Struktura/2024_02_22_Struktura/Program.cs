using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_02_22_Struktura
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Változók:
             * Elemi típus
             * típus változó_név = érték;
             * int a = 5;
             * 
             * Összetett típusok:
             * Tömb - Array - azonos típusúak
             * Lista - List - azonos típusúak
             * 2D Tömb - 2D Array - mátrix - azonos típusúak
             * Listában a lista - azonos típusúak
             * 
             * Struktúra
             * definiálunk egy új szerkezetet, struktúrát*/

            Diak diak1 = new Diak();
            diak1.nev = "Béla";
            //Console.WriteLine(diak1.nev);
            diak1.osztalyfonok = "Nagy János";
            //Console.WriteLine(diak1.osztalyfonok);
            diak1.osztaly = "11.H";
            diak1.szulev = 2006;
            diak1.evVegiAtlag = 4.2;

            //Console.WriteLine("{0} ({3}): {1}\nofi: {2}\nÉv végi átlag: {4}",diak1.nev, diak1.osztaly,diak1.osztalyfonok,diak1.szulev, diak1.evVegiAtlag);
            //Console.WriteLine(diak1.ToString());

            Diak diak5 = new Diak("Jolán", "11.J", "Pintér Aladár", 2008, 4.0);
            //Console.WriteLine(diak5.ToString());
            //Console.WriteLine($"{diak1.nev} ({diak1.szulev}): {diak1.osztaly}\nofi: {diak1.osztalyfonok}\nÉv végi átlag: {diak1.evVegiAtlag}");

            Diak diak6 = new Diak("Karcsi", "11.J", "Pintér Aladár", 2007, 4.8);
            //Console.WriteLine(diak6.ToString());
            Diak diak7 = new Diak("Csilla", "11.H", "Nagy János", 2006, 3.4);
            //Console.WriteLine(diak7.ToString());
            Diak diak8 = new Diak("Feri", "11.J", "Pintér Aladár", 2004, 2.1);
            //Console.WriteLine(diak8.ToString());

            double a = diak1.evVegiAtlag;
            double b = diak5.evVegiAtlag;
            double c = diak6.evVegiAtlag;
            double d = diak7.evVegiAtlag;
            double e = diak8.evVegiAtlag;

            //if(a>b && a>c && a>d && a>e)
            //    Console.WriteLine("{0}  a legjobb.", diak1.nev);
            //else if(a < b && b > c && b > d && b > e)
            //    Console.WriteLine("{0}  a legjobb.", diak5.nev);
            //else if(c > b && a < c && c > d && c > e)
            //    Console.WriteLine("{0}  a legjobb.", diak6.nev);
            //else if(d > b && d > c && a < d && d > e)
            //    Console.WriteLine("{0}  a legjobb.", diak7.nev);
            //else if(e > b && e > c && e > d && a < e)
            //    Console.WriteLine("{0}  a legjobb.", diak8.nev);

            List<Diak> diakok = new List<Diak>();
            diakok.Add(diak1);
            diakok.Add(diak5);
            diakok.Add(diak6);
            diakok.Add(diak7);
            diakok.Add(diak8);

            //Console.WriteLine(diakok[4].nev);

            //A legjobb tanuló neve!
            int maxi = 0;
            for (int i = 1; i < diakok.Count; i++)
            {
                if (diakok[i].evVegiAtlag > diakok[maxi].evVegiAtlag)
                    maxi = i;
            }
            Console.WriteLine("{0} a legjobb tanuló",diakok[maxi].nev);

            //A legidősebb tanuló
            //A diákok korának átlaga
            //Mely osztály tanulói vannak a listában. Mindegyikből csak egy jelenjen meg!

            int minevi = 0;
            for (int j = 1; j < diakok.Count; j++)
            {
                if (diakok[j].szulev < diakok[minevi].szulev)
                    minevi = j;
            }
            Console.WriteLine("{0} a legidősebb tanuló", diakok[minevi].nev);

            double atlag = 0;
            for (int k = 0; k < diakok.Count; k++)
            {
                atlag += 2024 - diakok[k].szulev;
            }
            Console.WriteLine("{0} a diákok átlag kora",atlag/diakok.Count);



            Console.ReadLine();
        }
    }

    struct Tema
    { 
        // legalább 5 mezőt
        // ToString()
    }

    struct Diak {
        // Mezők, jellemzők, tulajdonságok
        public string nev, osztaly, osztalyfonok;
        public int szulev;
        public double evVegiAtlag;

        //Konstruktor - Speciális metódus
        public Diak(string ujnev, string ujosztaly, string ujosztalyfonok, int ujszulev, double ujevatlag)
        {
            nev = ujnev;
            osztaly = ujosztaly;
            osztalyfonok = ujosztalyfonok;
            szulev = ujszulev;
            evVegiAtlag = ujevatlag;
        }


        //Metódusok
        public override string ToString()
        {
            return string.Format("{0} ({3}): {1}\nofi: {2}\nÉv végi átlag: {4}\n", nev, osztaly, osztalyfonok, szulev, evVegiAtlag);
        }
    }
}
