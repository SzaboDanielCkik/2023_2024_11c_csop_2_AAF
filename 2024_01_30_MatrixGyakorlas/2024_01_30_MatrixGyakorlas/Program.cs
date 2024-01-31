using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_01_30_MatrixGyakorlas
{
    class Program
    {
        static int[,] matrix = new int[4, 4];
        static void Main(string[] args)
        {
            /* 1. Töltsön fel egy 4x4-os mátrixot [1,20] közötti számokkal!
             * 2. FV: Adja meg a fő és mellék átlók szorzatának hányadosát!
             * 3. FV: Készítsen egy új mátrixot, aminek az első sorában eltárolja a sorok terjedelmét a másodikban pedig az oszlopok szórását!
             * 4. metódus: kérjen be a felhasználótól egy sor és egy oszlop számot és írassa ki az adott helyen lévő számok szomszédját (az átlós is szomszédnak számít)*/

            MatrixFeltoltes(matrix);
            MatrixKiir(matrix);
            Feladat2();

            Console.ReadLine();

        }

        static void Feladat2()
        {
            Console.WriteLine("2. feladat");
            double hanyados = KetAtloHanyadosa(matrix);
            Console.WriteLine("A két átló szórzatának hányadosa: " + hanyados);
        }

        static double KetAtloHanyadosa(int[,] matrix)
        {
            double foatloSzorzata = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                foatloSzorzata *= matrix[i, i];
            }

            double mellekatloSzorzata = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int oszlop = matrix.GetLength(1) - i - 1;
                mellekatloSzorzata *= matrix[i, oszlop];
            }
            return foatloSzorzata / mellekatloSzorzata;
        }

        static void MatrixFeltoltes(int[,] matrix)
        {
            Random r = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(1, 21);
                }
            }
        }

        static void MatrixKiir(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
