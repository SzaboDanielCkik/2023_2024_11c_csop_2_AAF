using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_04_30_Harcos
{
    class Program
    {
        /* HF Generálj ki 8 Harcost Kódnévvel és véletlen HP, DP-vel!
             * Kódnév: 5 db véletlen karakter, kis és nagybetűs
             * Hp: [1000,5000] között 00-ra végződjön.
             * DP: [50,200] 0-ra végződjön.
             * Kiesős harc! Ki a győztes?*/

        static List<Harcos> harcosok = new List<Harcos>();
        static Random r = new Random();

        static void Main(string[] args)
        {
            //Proba();
            HarcosokGeneralasa(8);
            Kiiratas(harcosok);
            Merkozesek();


            Console.ReadLine();
        }

        static void Merkozesek()
        {
            List<Harcos> gyoztesek = GyoztesKigyujt(harcosok);
            while (gyoztesek.Count > 1)
            {                
                Kiiratas(gyoztesek);
                gyoztesek = GyoztesKigyujt(gyoztesek);
            }
            Kiiratas(gyoztesek);
        }
        static List<Harcos> GyoztesKigyujt(List<Harcos> harcosok)
        {
            List<Harcos> gyoztesek = new List<Harcos>();
            for (int i = 0; i < harcosok.Count; i += 2)
            {
                while (!harcosok[i].Harcol(harcosok[i + 1])) ;
                if (harcosok[i].Eletero >= harcosok[i + 1].Eletero)
                    gyoztesek.Add(harcosok[i]);
                else
                    gyoztesek.Add(harcosok[i + 1]);
            }
            return gyoztesek;
        }

        static void Kiiratas(List<Harcos> lista)
        {
            for (int i = 0; i < lista.Count; i++)
                Console.WriteLine(lista[i].ToString());
            Console.WriteLine();
        }

        static void HarcosokGeneralasa(int db)
        {
            for (int i = 0; i < db; i++)
            {
                Harcos sv = new Harcos(
                    NevGeneralas(),
                    r.Next(10,50)*100,
                    r.Next(5,20)*10);
                harcosok.Add(sv);
            }
        }

        static string NevGeneralas()
        {
            //ASCII kisbetűk - 97-122
            string nev = "";
            for (int i = 0; i < 5; i++)
            {
                char c = (char)r.Next(97, 123);
                nev += r.Next(0, 2) == 0 ? ""+c : ("" + c).ToUpper();
                //if (r.Next(0, 2) == 0)
                //    nev += c;
                //else
                //    nev += ("" + c).ToUpper();
            }
            return nev;
        }

        static void Proba()
        {
            Harcos h1 = new Harcos("Ironman", 1000, 120);
            Harcos h2 = new Harcos("Pacman", 500, 375);

            //Console.WriteLine(h1.Harcol(h2));
            //Console.WriteLine(h1.Harcol(h2));
            //Console.WriteLine(h1.Harcol(h2));
            do
            {
                Console.WriteLine(h1.ToString());
                Console.WriteLine(h2.ToString());
                Console.WriteLine();
            } while (!h1.Harcol(h2));
            Console.WriteLine(h1.ToString());
            Console.WriteLine(h2.ToString());
        }
    }
}
