using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2024_04_03_Szamla
{
    struct Hivas
    {
        public int ko, kp, kmp, vo, vp, vmp;
        public string telefonszam;

        public Hivas(int ujko,int ujkp, int ujkmp, int ujvo, int ujvp, int ujvmp, string ujtelszam)
        {
            ko = ujko;
            kp = ujkp;
            kmp = ujkmp;
            vo = ujvo;
            vp = ujvp;
            vmp = ujvmp;
            telefonszam = ujtelszam;
        }

        public int BeszeltetesIdeje()
        {
            return vo * 3600 + vp * 60 + vmp - (ko * 3600 + kp * 60 + kmp);
        }
    }

    class Program
    {
        static List<Hivas> hivasok = new List<Hivas>();
        static void Main(string[] args)
        {
            Fajlbeolvasas();
            Feladat2();
            Feladat3();
            FajlbaKiiratas();

            Console.ReadLine();
        }

        static void Feladat3()
        {
            Console.WriteLine("2. feladat: ");
            int index = LeghosszabHivasIndexe();
            Console.WriteLine("{0} - sorszámon a {1} telefonról érkezett",index+1, hivasok[index].telefonszam);
        }

        static int LeghosszabHivasIndexe()
        {
            int maxi = 0;
            for (int i = 1; i < hivasok.Count; i++)
            {
                if (hivasok[i].BeszeltetesIdeje() > hivasok[maxi].BeszeltetesIdeje())
                    maxi = i;
            }
            return maxi;
        }

        static void Feladat2()
        {
            Console.WriteLine("2. feladat: ");
            Console.WriteLine("{0} darab mobilhívás történt.", MobilDarabSzamok());
        }

        static int MobilDarabSzamok()
        {
            int db = 0;
            for (int i = 0; i < hivasok.Count; i++)
            {
                string korzet = ""+hivasok[i].telefonszam[0] + hivasok[i].telefonszam[1];
                if (korzet == "39" || korzet == "41" || korzet == "71")
                    db++;
            }
            return db;
        }

        static void FajlbaKiiratas()
        {
            StreamWriter f = new StreamWriter("egysoros.txt");
            for (int i = 0; i < hivasok.Count; i++)
            {
                f.WriteLine(hivasok[i].ko + " " + hivasok[i].kp + " ");
                f.WriteLine(hivasok[i].vo + " " + hivasok[i].vp + " ");
                f.WriteLine(hivasok[i].telefonszam);
            }
            f.Close();
        }

        static void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("hivasok.txt");

            while (!f.EndOfStream)
            {
                string[] st = f.ReadLine().Split(' ');
                int[] adatok = new int[st.Length];

                for (int i = 0; i < st.Length; i++)
                    adatok[i] = Convert.ToInt32(st[i]);

                string telefonsz = f.ReadLine();
                Hivas sv = new Hivas(adatok[0], adatok[1], adatok[2], adatok[3], adatok[4], adatok[5], telefonsz);
                hivasok.Add(sv);
            }

            f.Close();
        }
    }
}
