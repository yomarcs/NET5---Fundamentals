using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Net5.Fundamentals.ControlStructure
{
    public class ControlStructureImplement
    {
        public void IfStructure()
        {
            // Declaramos precio
            int precio;
            // Pintamos encabezado
            Console.WriteLine("If Structure");
            Console.WriteLine("============");
            // WriteLine >> Realiza un salto de linea al final de la ejecución
            // Write >> No realiza el salto de linea por lo que el cursor estara al costado 
            Console.Write("Ingrese un precio (Entero) : ");
            // Recibimos dato por consola con ReadLine(), por defecto en formato string
            // Convertimos o casteamos con convert a formato entero
            // asignamos el valor ingresado a precio;
            precio = Convert.ToInt32(Console.ReadLine());
            // Estructura if
            if (precio > 100) // Condición
            {
                // Si la conicion es verdadera(true) ejecuta esta linea de código
                Console.WriteLine("El precio es mayor que 100");
            }
        }

        public void IfElseIfStructure()
        {
            // Declaramos precio
            int precio;
            // Pintamos encabezado
            Console.WriteLine("If Else If Structure");
            Console.WriteLine("====================");
            // WriteLine >> Realiza un salto de linea al final de la ejecución
            // Write >> No realiza el salto de linea por lo que el cursor estara al costado
            Console.Write("Ingrese un precio (Entero) : ");
            // Recibimos dato por consola con ReadLine(), por defecto en formato string
            // Convertimos o casteamos con convert a formato entero
            // asignamos el valor ingresado a precio;
            precio = Convert.ToInt32(Console.ReadLine());
            // Estructura if...else
            if (precio == 100) // Condición
                {
                    // Si la condicion es verdadera(true) ejecuta esta linea de código
                    Console.WriteLine("El precio es 100");
                }
            // sino si(Nueva condición)
            else if(precio == 200)
                {
                    // Si la condicion es verdadera(true) ejecuta esta linea de código
                    Console.WriteLine("El precio es 200");
                }
            else // Si ninguna condición se cumple devuelve falso(false)
                {
                    // Si la condicion es falso(false) ejecuta esta linea de código
                    Console.WriteLine("El precio no es ni 100 ni 200");
                }
        }

        public void IfNested()
        {
            int precio;
            Console.WriteLine("If Nested");
            Console.WriteLine("============");
            Console.Write("Ingrese un precio (Entero) : ");
            // Recibimos dato por consola con ReadLine(), por defecto en formato string
            // Convertimos o casteamos con convert a formato entero
            // asignamos el valor ingresado a precio;
            precio = Convert.ToInt32(Console.ReadLine());
            // if anidados >> Cuando la sentencia de la rama verdadera o false es a su vez otra sentencia if
            if (precio >= 0)
            {
                // Adinamiento de if
                if(precio > 100)
                {
                    Console.WriteLine("Es un precio de oferta");
                }
                else
                {
                    Console.WriteLine("Es un precio de rebaja");
                }
            }
            else
            {
                Console.WriteLine("El precio no puede ser negativo");
            }
        }

        public void ForStructure()
        {            
            Console.WriteLine("For Structure");
            Console.WriteLine("=============");
            // Capturamos el valor de la cantidad de veces que queremos que se repita el codigo
            Console.Write("Ingrese la cantidad de repeticiones (Entero) : ");
            // Parseamos el ingreso de limit(por defecto string)
            int limit = int.Parse(Console.ReadLine()); 

            //  try
            //  {
            //    limit = int.Parse(Console.ReadLine());
            //  }
            //  catch (Exception ex)
            //  {
            //  }
            
            // En algunos métodos el try esta embebido, la siguiente linea resume las lineas 105 a 111
            //int.TryParse(Console.ReadLine(),out limit);

            // La cantidad de repiticiones esta prefijada con la variable limit
            // for (inicialización, expresión booleana, actualización)         
            for (int x = 1; x <= limit; x++)
            {
                // using System.Threading
                // Thread.Sleep(valor en milisegundos) >> Sirve para darle un intervalo de tiempo por cada ciclo de repetición
                Thread.Sleep(800);
                // $" literal {valor}" >> hace que todo lo que este entre {} se interpreta como valor 
                Console.WriteLine($"x={x}");
            }
        }

        public void WhileStructure()
        {
            // Cantidad de pizzas
            int stock;
            // Contador de personas atendidas
            int peopleCount = 0;
            // Cantidad de entregas
            int deliveryQuantity = 0;

            Console.WriteLine("While Structure");
            Console.WriteLine("===============");
            Console.Write("Ingrese el stock inicial (Entero) : ");
            // convertimos a entero el ingreso de stock (por defecto string)
            stock = Convert.ToInt32(Console.ReadLine());
            // La cantidad de repeticiones no esta prefijada, es aleatoria
            // Seguira imprimiendo mientras la condicion sea verdadera
            // while(expresión Lógica)
            while (stock >=10)
            {
                Console.Write("Ingrese cantidad a entregar (Entero) : ");
                // Convertimos string a entero y lo alojamos en la variable diliveryQuantity
                deliveryQuantity = Convert.ToInt32(Console.ReadLine());

                // Solo si el stock sea mayor que la cantidad a entregar
                if (stock >= deliveryQuantity)
                {
                    // Restamos al stock la cantidad a entregar
                    stock = stock - deliveryQuantity;
                    // Aumentamos el contador de personas atendidas
                    peopleCount++;
                }
            };
            // Pintamos el Stock final y la cantidad de personas atendidas
            Console.WriteLine($"Stock final = {stock}");
            Console.WriteLine($"Cantidad de personas atentidas = {peopleCount}");
        }

        public void DoWhileStructure()
        {
            int score = 0;

            Console.WriteLine("Do While Structure");
            Console.WriteLine("==================");
            
            // Do while >> La epresion de validación va al final
            // Asi que por lo menos el código se ejecuta 1 vez antes de evaluar si la la expresion es verdadera o falsa
            do{
                Console.Write("Ingrese su nota (Entero) : ");
                score = Convert.ToInt32(Console.ReadLine());

                if (score >= 11 && score <=20)
                {
                    Console.WriteLine("Aprobaste :)");
                }
                else if(score>=0 && score <=10)
                {
                    Console.WriteLine("Desaprobaste :(");
                }
                else
                {
                    Console.WriteLine("Es una nota invalida");
                }
            } while (score!=0);
        }

        public void SwitchStructure()
        {
        // Switch >> Es una estructura selectiva que elige una sola opcion ha ejecutar de todos los candidatos posibles basado en la coincidencia de patron de la expresion de coincidencia
            int numberDay;
            string day;

            Console.WriteLine("Switch Structure");
            Console.WriteLine("================");
            Console.Write("Ingrese dia de la semana laborable (1 - 5) : ");
            // Switch recibe enteros o string
            // Si fuese string en case colocaremos case "1":
            numberDay = Convert.ToInt32(Console.ReadLine());

            switch (numberDay)
            {
                case 1:
                    day = "Lunes";
                    break;
                case 2:
                    day = "Martes";
                    break;
                case 3:
                    day = "Miercoles";
                    break;
                case 4:
                    day = "Jueves";
                    break;
                case 5:
                    day = "Viernes";
                    break;
                default:
                    // Instrucciones si se cumple el caso Default
                    day = "No es un dia laborable";
                    break;
            }
            Console.WriteLine(day);
        }

        public void BreakCommand()
        {
            Console.WriteLine("Break Command");
            Console.WriteLine("==============");
            Console.Write("Ingrese la cantidad de repeticiones (Entero) : ");
            int limit = Convert.ToInt32(Console.ReadLine());

            int x = 0;

            for (x = 1; x <= limit; x++)
            {
                if (x == 5)
                {
                    // Break >> Cortocircuita una estructura, en este caso hace terminar el ciclo for
                    break;
                }
                Console.WriteLine($"x={x}");
            }
        }

        public void ContinueCommandInFor()
        {
            Console.WriteLine("Continue Command in For");
            Console.WriteLine("=======================");
            Console.Write("Ingrese la cantidad de repeticiones (Entero) : ");
            int limit = Convert.ToInt32(Console.ReadLine());

            int x = 0;

            for (x = 1; x <= limit; x++)
            {
                if (x < 9)
                {   
                    // continue >> cuando la expresion el verdadera, hace que salte al siguiente bucle obviando la expresion que sigue despues de continue
                    continue;
                }
                Console.WriteLine($"x={x}");
            }
        }

        public void ContinueCommandInWhile()
        {
            Console.WriteLine("Continue Command in While");
            Console.WriteLine("=========================");
            Console.Write("Ingrese la cantidad de repeticiones (Entero) : ");
            int limit = Convert.ToInt32(Console.ReadLine());

            int x = 0;

            while(x < limit)
            {
                x++;
                if (x < 5)
                {   
                    continue;
                }

                Console.WriteLine($"x={x}");
            }
        }

        public void GoToCommandInSwitch()
        {
            // using System.Threading
            // Thread.Sleep(valor en milisegundos) >> Sirve para darle un intervalo de tiempo por cada ciclo de repetición
            Thread.Sleep(800);
            // GOTO >> transfiere el control de programa directamente a una declaracion etiquetada
            int cost = 0;
            Console.WriteLine("GoTo Command in Switch");
            Console.WriteLine("======================");
            Console.WriteLine("Tamaños de cafe : ");
            Console.WriteLine("1 = Regular");
            Console.WriteLine("2 = Grande");
            Console.WriteLine("3 = Venti");
            Console.Write("Por favor ingrese su eleccion : ");
            int opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    //cost = cost + 25;
                    cost += 25;
                    break;
                case 2:                    
                    cost += 25;
                    goto case 1;                    
                case 3:                    
                    cost += 50;
                    goto case 1;                    
                default:
                    Console.WriteLine("Selección inválida");
                    break;
            }

            if(cost != 0)
            {
                Console.WriteLine($"Por favor inserte {cost} soles");
            }

            Console.WriteLine("Gracias por su compra.");
        }

        public void ForEachStructure()
        {
            Console.WriteLine("For Each Structure");
            Console.WriteLine("==================");
            Console.Write("Ingrese la cantidad de elementos (Entero) : ");
            
            int peopleCount = Convert.ToInt32(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < peopleCount; i++)
            {
                people.Add(new Person
                {
                    Nombre = $"First Name - {i}",
                    ApellidoPaterno = $"Last Name - {i}",
                    ApellidoMaterno = $"Sur Name - {i}",
                });
            }

            foreach (Person person in people)
            {
                Console.WriteLine($"Complete Name : {person.Nombre} {person.ApellidoPaterno} {person.ApellidoMaterno}");
            }
        }

        public void TryCatchStructure()
        {
            int dividendo = 100;
            int divisor = 0;
            int resultado = 0;

            //  el código escrito
            try
            {
                Console.WriteLine("Try Catch Structure");
                Console.WriteLine("===================");
                Console.Write("Ingrese Dividendo (Entero) : ");
                dividendo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese Divisor (Entero) : ");
                divisor = Convert.ToInt32(Console.ReadLine());

                resultado = dividendo / divisor;

                Console.WriteLine($"{dividendo} / {divisor} = {resultado}");
            // catch >> Captura el error(Exception) y podemos gestionarlo, y asi no se cuelgue nuestro programa
            }catch(Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
        }

        public void TryCatchFinallyStructure()
        {
            int dividendo = 100;
            int divisor = 0;
            int resultado = 0;
            bool successOperation = false;

            try
            {
                Console.WriteLine("Try Catch Structure");
                Console.WriteLine("===================");
                Console.Write("Ingrese Dividendo (Entero) : ");
                dividendo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese Divisor (Entero) : ");
                divisor = Convert.ToInt32(Console.ReadLine());

                resultado = dividendo / divisor;
                Console.WriteLine($"{dividendo} / {divisor} = {resultado}");
                successOperation = true;
            }
            // catch >> Captura el error(Exception) y podemos gestionarlo, y asi no se cuelgue nuestro programa
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
                successOperation = false;
            }
            // finally siempre se ejecuta, salte o no un error (Exception)
            finally
            {
                if (successOperation)
                {
                    Console.WriteLine($"La operación fue exitosa :)");
                }
                else
                {
                    Console.WriteLine($"La operación no fue exitosa :(");
                }
            }
        }
    }
}
