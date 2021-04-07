using System;

namespace Net5.Fundamentals.Evidence.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int operacion;
            bool exit = false;

            while (!exit) 
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("** Calculadora **");
                    Console.WriteLine("=================");
                    Console.WriteLine(" 1. - Suma");
                    Console.WriteLine(" 2. - Resta");
                    Console.WriteLine(" 3. - Multiplicación");
                    Console.WriteLine(" 4. - División");
                    Console.WriteLine("99. - Salir");
                    Console.WriteLine("=================");
                    Console.Write("Elija operación (entero): ");
                    operacion = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    switch (operacion)
                    {
                        case 1:
                            calculator.Addition();
                            break;
                        case 2:
                            calculator.Subtraction();
                            break;
                        case 3:
                            calculator.Multiplication();
                            break;
                        case 4:
                            calculator.Division();
                            break;
                        case 99:
                            exit = true;
                            break;
                        default:
                            break;
                    }

                    if (operacion != 99)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("presione cualquier tecla para continuar");
                        Console.ReadKey();
                    }
                }catch( FormatException ex)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Error: {ex.Message}");
                    Console.WriteLine($"Error: Cadena de entrada no tiene el formato correcto.");
                    Console.WriteLine("");
                    Console.WriteLine("****** Seleccione una opción válida ******");
                    Console.WriteLine("");
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();
                }
            }
        }
    }
}



