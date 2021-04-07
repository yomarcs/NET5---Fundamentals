using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.Fundamentals.Evidence.Calculator
{
    class Calculator
    {
        public void Addition()
        {
            try
            {
                double sumando1, sumando2, suma;
                Console.WriteLine("** Suma **");
                Console.WriteLine("==========");
                Console.Write("Ingrese sumando: ");
                sumando1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese sumando: ");
                sumando2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("=====================");
                suma = sumando1 + sumando2;
                Console.WriteLine($"La suma es: {suma}");
            }catch(FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Error: Cadena de entrada no tiene el formato correcto.");
            }
        }

        public void Subtraction()
        {
            try
            {
                double minuendo, sustraendo, diferencia;
                Console.WriteLine("** Resta **");
                Console.WriteLine("===========");
                Console.Write("Ingrese minuendo : ");
                minuendo = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese sustraendo: ");
                sustraendo = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("=======================");
                diferencia = minuendo - sustraendo;
                Console.WriteLine($"La diferencia es: {diferencia}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Error: Cadena de entrada no tiene el formato correcto.");
            }
        }

        public void Multiplication()
        {
            try
            {
                double factor1, factor2, producto;
                Console.WriteLine("** Multiplicación **");
                Console.WriteLine("====================");
                Console.Write("Ingrese factor: ");
                factor1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese factor: ");
                factor2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("====================");
                producto = factor1 * factor2;
                Console.WriteLine($"El producto es: {producto}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Error: Cadena de entrada no tiene el formato correcto.");
            }
        }

        public void Division()
        {
            try
            {
                int dividendo, divisor, cociente;
                Console.WriteLine("** División **");
                Console.WriteLine("==============");
                Console.Write("Ingrese Dividendo : ");
                dividendo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese divisor: ");
                divisor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("=======================");
                cociente = dividendo / divisor;
                Console.WriteLine($"El cociente es: {cociente}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Error: Intento dividir por cero");
            }
        }


    }
}
