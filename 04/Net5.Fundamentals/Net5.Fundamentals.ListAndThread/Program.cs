﻿using System;

namespace Net5.Fundamentals.ListAndThread
{
    class Program
    {
        static void Main(string[] args)
        {
            string opt;
            bool exit = false;
            ListAndThread listAndThread = new ListAndThread();

            do
            {
                Console.Clear();
                Console.WriteLine("List And Thread");
                Console.WriteLine("===============");
                Console.WriteLine(" 1 - Array");
                Console.WriteLine(" 2 - List");
                Console.WriteLine(" 3 - Dictionary");
                Console.WriteLine("99 - exit");
                Console.WriteLine("");
                Console.Write("Seleccione una opcion : ");
                opt = Console.ReadLine();
                Console.Clear();

                switch (opt)
                {
                    case "1":
                        listAndThread.ArraySample();
                        break;
                    case "2":
                        listAndThread.ListSample();
                        break;
                    case "3":
                        listAndThread.DictionarySample();
                        break;
                    case "4":
                        listAndThread.SortedListSample();
                        break;
                    case "99":
                        exit = true;
                        break;
                    default:
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Presione un a tecla para continuar");
                    Console.ReadKey();
                }

            } while (!exit);

        }
    }
}
