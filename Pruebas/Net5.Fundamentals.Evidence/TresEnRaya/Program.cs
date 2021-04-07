using System;
using System.Collections.Generic;

namespace TresEnRaya
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];

            LlenandoMatriz(matriz);
            Visualizar(matriz);
            TresRayas(matriz);

            Console.ReadKey(true);
        }

        public static void LlenandoMatriz(int[,] pMatriz)
        {
            Random rnd = new Random();

            for (int i = 0; i < 2; i++)
            {
                for (int p = 0; p < 2; p++)
                {
                    pMatriz[i, p] = rnd.Next(0, 2);
                }
            }
        }

        public static void Visualizar(int[,] pMatriz)
        {
            int f = 0, c = 10;

            for (int i = 0; i < 3; i++)
            {
                f = 5;
                for (int p = 0; p < 3; p++)
                {
                    Console.SetCursorPosition(c, f);
                    Console.WriteLine("{0}", pMatriz[i, p]);
                    f += 3;
                }
                c += 5;
            }
        }

        public static void TresRayas(int[,] pMatriz)
        {

            int a = 0, b = 0, c = 0, d = 0, e = 0, f = 0, h = 0, u = 0;

            for (int i = 0; i < 3; i++)
            {
                a += pMatriz[0, i];
            }
            if (a == 0 || a == 3)
            {
                Console.SetCursorPosition(10, 14);
                Console.WriteLine("Tres en rayas Columna 1");
            }

            for (int j = 0; j < 3; j++)
            {
                b += pMatriz[1, j];
            }
            if (b == 0 || b == 3)
            {
                Console.SetCursorPosition(10, 15);
                Console.WriteLine("Tres en rayas Columna 2");
            }

            for (int j = 0; j < 3; j++)
            {
                c += pMatriz[2, j];
            }
            if (c == 0 || c == 3)
            {
                Console.SetCursorPosition(10, 16);
                Console.WriteLine("Tres en rayas Columna 3");
            }
            for (int j = 0; j < 3; j++)
            {
                d += pMatriz[j, 0];
            }
            if (d == 0 || d == 3)
            {
                Console.SetCursorPosition(10, 17);
                Console.WriteLine("Tres en rayas Fila 1");
            }

            for (int j = 0; j < 3; j++)
            {
                e += pMatriz[j, 1];
            }
            if (e == 0 || e == 3)
            {
                Console.SetCursorPosition(11, 18);
                Console.WriteLine("Tres en rayas Fila 2");
            }

            for (int j = 0; j < 3; j++)
            {
                f += pMatriz[j, 2];
            }
            if (f == 0 || f == 3)
            {
                Console.SetCursorPosition(10, 19);
                Console.WriteLine("Tres en rayas Fila 3");
            }

            int x = 2;
            while (x >= 0)
            {
                for (int j = 0; j < 3; j++)
                {
                    h += pMatriz[x, j];
                    x--;
                }
            }
            if (h == 0 || h == 3)
            {
                Console.SetCursorPosition(10, 20);
                Console.WriteLine("Tres en rayas Diagonal Secundaria  ");
            }
            int l = 0;
            while (l < 3)
            {
                u = u + pMatriz[l, l];
                l++;
            }
            if (u == 0 || u == 3)
            {
                Console.SetCursorPosition(10, 21);
                Console.WriteLine("Tres en rayas Diagonal Primaria  ");
            }
        }
    }
}
