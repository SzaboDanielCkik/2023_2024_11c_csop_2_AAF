using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_12_13__Lista
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /* Lista
             * List<típus> lista_neve;
             * List<típus> lista_neve = new List<típus>();
             * lista_neve.Add(érték); - érték hozzáadása, lista végére kerül az elem.
             * lista_neve.Count - elemszám meghatározása
             * lista_neve.Remove(érték) - a listából az első olyan értéket, amivel megegyezik.
             * lista_neve.RemoveAt(index) - az adott indexen lévő értéket kitörli a listából. */

            //ListaAlapok();

            // 1. Eljárás: Feltölti a listát egy a felhasználó által bekért elemszámmal [10,50] között!
            // 2. Eljárás: Hívjon meg egy ön által megírt függvényt, ami megadja a számok összegét!
            // 3. Eljárás: Hívjon meg egy ön által megírt függvényt, ami megadja a lekisebb szám indexét!
            // 4. Eljárás: Hívjon meg egy ön által megírt függvényt, ami megadja a paraméterben szereplő szám indexét, ha benne van a listában ha nincs akkor (-1)-et adjon vissza!
            // 5. Eljárás: Ami rendezi a lista elemeit csökkenő sorrendben!


            Console.ReadLine();
        }
        static void ListaAlapok()
        {
            List<int> lista = new List<int>();
            lista.Add(2);
            Console.WriteLine("első elem: "+lista[0]);
            lista.Add(13);
            lista.Add(7);
            lista.Add(11);
            Console.WriteLine("a lista elemszáma: " + lista.Count);
            Console.WriteLine("a lista utolsó eleme: " + lista[lista.Count-1]);
            Kiiratas(lista);

            if (lista.Remove(13))
            {
                lista.Add(16);
            }
            Kiiratas(lista);

            lista.RemoveAt(3);
            Kiiratas(lista);

        }

        static void Kiiratas(List<int> lista)
        {
            for (int i = 0; i < lista.Count; i++)
                Console.Write(lista[i] + " ");
            Console.WriteLine();
        }

    }
}
