using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_05_03_Hallgato
{
    class Hallgato
    {
        //Mezők, adattagok, jellemzők, tulajdonságok
        public string azonosito;
        private int evfolyam, kreditszam;

        // Getter, setter
        public int Evfolyam
        {
            get {
                return evfolyam;
            }
        }

        public int Kreditszam {
            get {
                return kreditszam;
            }
        }



        //Konstruktorok
        public Hallgato(string id, int evfolyam, int kredit)
        {
            azonosito = id;
            this.evfolyam = evfolyam;
            kreditszam = kredit;
        }

        public Hallgato(string id)
        {
            azonosito = id;
            evfolyam = 1;
            kreditszam = 0;
        }

        //Metódusok
        public void TargyFelvesz(int kredit)
        {
            kreditszam += kredit;
        }

        public bool Vizsgazik()
        {
            //bool tovabblephet = false;
            if (kreditszam > 0)
            {
                evfolyam++;
                kreditszam = 0;
                //tovabblephet = true;
                return true;
            }
            else
                return false;
                //tovabblephet = false;
            //return tovabblephet;
        }

        public override string ToString()
        {
            return string.Format($"id: {azonosito} evf: {evfolyam} kredit: {kreditszam}");
        }
    }
}
