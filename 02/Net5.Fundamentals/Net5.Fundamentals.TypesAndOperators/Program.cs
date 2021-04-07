using System;
using System.Linq;
using System.Collections.Generic;

namespace Net5.Fundamentals.TypesAndOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaracion y asignación de variables de tipo

            // Entero
            int a = 5;
            int b = a + 2;

            // Booleano
            bool test = true;

            // No se permite operaciones entre diferentes tipos de datos
            // int c = a + test;

            // Solo declaración de variables
            float temperature;
            string name;

            // Instancia de clase MyClass
            MyClass myClass = new MyClass();

            // char >> se asigna valor con comillas simples ''
            char firstLetter = 'C';

            // string >> se asigna valor con comilla dobles ""
            var limit = "";
            limit = "animal";

            // declaracion de array
            int[] source = { 1, 2, 3, 4, 5 };

            // var >> Se utiliza para declarar un tipo de dato que varia segun su asignación
            // var letra = '' >> Si deseamos char le asignamos comillas simples
            // var cadena = "" >> si deseamos que sea string le asignamos comillas dobles
            // var linq = (expresion)
            // linq >> Es toda esa expresion declarada y asingada a la variable query
            var query = from item in source where item <= item select item;

            // asignacion de valor a la variable MyProperty de la instancia de clase MyClass
            myClass.MyProperty = 5;
            // Llamamos al metodo ChangeMyClass y le pasamos como parametro de referencia myClass
            ChangeMyClass(myClass);
            // Impresion de valor contenido en MyProperty
            Console.WriteLine(myClass.MyProperty); // 20

            // Llamamos al metodo ChangeValue y le pasamos como valor a 
            ChangeValue(a);
            // impresion de valor contenido en a0
            Console.WriteLine(a);

            // int >> es un alias para System.Int32
            int aa = 123;
            System.Int32 bb = 123;

            // declaramos c que tomara el tipo int al asignarle valores int
            var c = aa + bb;
            // declaramos hexa que tomara un tipo Hexadecimal al asignarle un valor hexadecimal 
            var hexa = 0x2A;
            // declaramos binary que tomara un tipo binario al asignarle un valor binario 
            var binary = 0b_0010_1010;


            string cadena = "test";
            char letter = 'D';

            // delcaracion y asignacion de arreglo de chars
            var chars = new[]
            {
                'J',
                '\u006A', // valor ASSCI para "J"
                '\x00A', //  valor hexadecimal para "J"
                (char)106 // valor decimal para "J"
            };
            // Concatenamos los valores de chars dejando un espacio
            Console.WriteLine(string.Join(" ", chars));

            // Tipo de dato enum >> Es un conjunto de constantes que guardan o no valores
            Console.WriteLine((int)Season.Autum); // Impreme el número del enumerado >> 2
            Console.WriteLine(Season.Autum.ToString()); // Imprime el valor del enumerado >> Autum 
            // Sirve para hacer comparaciones en tre otras cosas
            var error = Errorcode.ConnectionLost;
            var test1 = ((ushort)Errorcode.ConnectionLost == 100);
            var test2 = (Errorcode.ConnectionLost == error);
            
            // Struct >> instancia de clase struct
            // Coords coords = new Coords(1,2,3);
            // Es lo mismo que:
            Coords coords = new Coords()
            {
                X = 1,
                Y = 2,
                Z = 3
            };

            // Tupla >> Agrupa varios elementos de datos en una estructura de datos ligera
            // Es como una mini clase
            // tiene un limite de valores.. buscar!
            // Podemos asignarle nombres, por defecto son Items
            (double, double, double) coord = (3, 4, 5);
            (MyClass, string name, int, int, int, int, int) tupla = (new MyClass(), "Yomar", 2, 3, 4, 5, 6);
            Console.WriteLine(coord);
            Console.WriteLine(tupla.name);

            // Tipos que admiten valores nulos
            // bool eval = null; // No permite
            // int num = null; // No permite
            string cad = null; // Si permite
            MyClass myClass1 = null; // Si permite
            // Lo que hizo C# para permitir valores nulos en esos tipo fue agregarle un signo de ?
            bool? evalu = null;
            int? num = null;
            int notNulleable = 0;
            // test es creado en la linea 17
            Console.WriteLine(test == evalu);
            // ChangeValue solo admite enteros
            // Al pasarle num que es un valor Nulleable aparecen 2 nuevas cpciones Value y HasValue 
            // ChangeValue(num.Value);

            // Records
            Dog dog = new Dog("Firulais");
            Console.WriteLine(dog.ToString());

            // Conversiones implicitas
            int numInt = 12345678;
            long bigNum = numInt;
            // Conversion entre clases
            Derived Derivade = new Derived();
            Base baseClass = Derivade;

            // Conversiones explicitas
            // Giraffe hereda de Animal
            Giraffe g = new Giraffe();
            Animal animal = g;
            // Conversion forzada(cast)
            // Aqui queremos que el animal herede de Giraffe y al forzar el cast se pierde datos sol quedandonos con datos compatibles
            Giraffe g2 = (Giraffe)animal;

            // Operadores unarios
            int i = 3;
            Console.WriteLine($"i ={i}");
            Console.WriteLine($"++i = {++i}");
            Console.WriteLine($"i = {i}");

            // Operadores logicos
            if(!test && evalu.Value)
            {
                a = 5;
            }
            else
            {
                a = 6;
            }

            // Operador ternario "?"
            a = (test ? 5 : (evalu.Value ? 4 : 2));

            // Operador"??"
            // Si num es nulo le asigno 5 sino se le asigna num
            num = (num == null ? 5 : num);
            // Si num es nulo le asigno 5 sino se le asigna num (es la misma expreion simplificada con el operador "??"
            num = num ?? 5;

            // operador "=>"
            List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6 };
            nums.ForEach(num => Console.WriteLine(num));

            // Clases parciales 
            // Podemos dividir una clase en varios archivos agregando partial
            // Al instanciar la clase se uniran los archivos formando una sola 
            // Esto es para dividir una calse con codigo extenso
            // Employee esta divido en 2 archivos EmployeePartA y EmployeePartB
            Employee employee = new Employee();
            


        }

        static void ChangeMyClass(MyClass param)
        {
            param.MyProperty = 20;
        }

        static void ChangeValue(int param)
        {
            param = 20;
        }
    }
}   
