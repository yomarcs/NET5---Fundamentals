using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.Fundamentals.ListAndThread
{
    public class ListAndThread
    {
        public void ArraySample()
        {
            Console.WriteLine("Array");
            Console.WriteLine("=====");

            // Declaro un arreglo
            int[] array = new int[5];
            // Asignando valores al arreglo declarado - array
            for (int i = 0; i < 5; i++) array[i] = i;
            // Recorriendo arreglo y pintando en consola sus valores
            for (int i = 0; i < 5; i++) Console.WriteLine($"array[{i}] : {array[i]}");
           
            // Metodo para obtener la longitud del arreglo
            Console.Write("Longitud: ");
            Console.WriteLine($"Size : {array.Length}");

            //=============================================================================================
            Console.WriteLine("");
            Console.WriteLine($"Inicializacion y asignacion");
            // 2 formas de inicializar arrays y asignar valores
            int[] array2 = new int[] { 1, 2, 3, 4, 5 };
            int[] array3 = { 6, 7, 8, 9, 10 };
            // Recorriendo y imprimiendo valores deñ array
            for (int i = 0; i < 5; i++) Console.WriteLine($"array3[{i}] : {array3[i]}");

            //=============================================================================================
            Console.WriteLine("");
            Console.WriteLine($"Arreglo multi-dimensional");
            int[,] multidimensionalArray = { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"multidimensionalArray[{i},{j}] : {multidimensionalArray[i, j]}");
                }
            }

            //=============================================================================================
            Console.WriteLine("");
            Console.WriteLine("Matriz");
            // Array de diferentes dimensiones
            // declaramos e inicializamos la primera dimension del array con 6 elementos
            int[][] matrix = new int[6][];
            // Declaramos explicitamente el tamaño de las demas dimensiones asignando sus valores
            // Debemos definir el tamaño de cada array, no existe array dinámicos
            // En la posicion 0 declaramo la segunda dimension con 5 valores
            matrix[0] = new int[] { 1, 2, 3, 4, 5 };
            // En la posicion 1 declaramo la segunda dimension con 6 valores
            matrix[1] = new int[] { 1, 2, 3, 4, 5, 6 };
            // En la posicion 2 declaramo la segunda dimension con 7 valores
            matrix[2] = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            // No es necesario llenar de valores todos los campos, aunque su espacio en memoria esta separada
            //matrix[3]
            //matrix[4]
            //matrix[5]

            for (int i = 0; i < 6; i++)
            {   
                // Si el contenido de la matriz es nulo continuamos a la siguiente iteración
                if (matrix[i] == null) continue;
                // Recorremos la 2da dimension
                // colocamos matriz.legnth pq cada dimension es de diferente tamaño
                for (int j = 0; j < matrix[i].Length; j++)
                {   
                    //Pintamos los valores
                    Console.WriteLine($"matrix[{i}],[{j}] : {matrix[i][j]}");
                }
            }

            //=============================================================================================
            Console.WriteLine("");
            Console.WriteLine("Arreglo de String");
            string[] weekDays = new string[] {"Lunes","Martes","Miercoles","Jueves","Viernes" };
            for (int i = 0; i < weekDays.Length; i++)
            {
                Console.WriteLine(weekDays[i]);
            }
        }

        public void ListSample()
        {
            Console.WriteLine("List");
            Console.WriteLine("====");

            // El listado es dinamico, por lo que no definimos su tamaño
            // Declaración de listado
            List<int> numberList = new List<int>();
            numberList.Add(1);
            numberList.Add(3);
            numberList.Add(5);
            numberList.Add(7);
            
            // Con ForEach iteramos cada elemento de la lista
            numberList.ForEach(num => Console.WriteLine($"Numbers : {num}"));

            // ==================================================================
            List<string> cities = new List<string>()
            {
                "Lima",
                "Villa el Salvador",
                "Rimac",
                "Callao",
                "Jesus Maria",
                "San Juan De Lurigancho",
                "Miraflores",
                "San Isidro",
                "Villa Maria del Triunfo"
            };

            Console.WriteLine("");
            cities.ForEach(city => Console.WriteLine($"Cities : {city}"));

            // Se puede manipuar y extraer informacion debido a que se integra con linq
            Console.WriteLine("");
            Console.WriteLine("Ciudades de tamaño menor o igual a 6");
            // Sentencia linq
            cities.Where(city => city.Length <= 6).ToList().ForEach(c =>
            {
                Console.WriteLine($"Cities : {c}");
            });

            // ======================================================================

            List<Person> people = new List<Person>
            {
                new Person{Name = "Erick",Age=38,Sex="M"},
                new Person{Name = "Jorge",Age=30,Sex="M"},
                new Person{Name = "Azucena",Age=22,Sex="F"},
                new Person{Name = "Jeniffer",Age=21,Sex="F"}
            };

            Console.WriteLine("");
            Console.WriteLine("Mujeres del salon de clase");
            people.Where(person => person.Sex == "F").ToList().ForEach(p =>Console.WriteLine(p.Name));
            Console.WriteLine("");
            Console.WriteLine($"La suma de las edades es : {people.Sum(p=>p.Age)}");
        }

        public void DictionarySample()
        {
            Console.WriteLine("Dictionary");
            Console.WriteLine("==========");

            // El diccionario se define por 2 valores <llave, valor>, el valor puede ser objeto
            // Este diccionario esta definido por un (string, objeto(clase Person))
            Dictionary<string, Person> people = new Dictionary<string, Person>();

            // Agregando elementos a al diccionario
            people.Add("12345678", new Person { DNI= "42731171", Name = "Yomar", Age = 36, Sex = "M" });
            people.Add("56428632", new Person { DNI= "56428632", Name = "Fabian", Age = 30, Sex = "M" });
            people.Add("41635163", new Person { DNI= "41635163", Name = "Gabriel", Age = 22, Sex = "M" });
            people.Add("88382238", new Person { DNI= "88382238", Name = "Karen", Age = 21, Sex = "F" });

            Console.WriteLine($"Azucena : {people.Where(kvp => kvp.Value.Name == "Karen").Select(s => s.Key).First()} ");
            Console.WriteLine($"Key : 56428632, value {people["56428632"].Name}");
        }
    }
}
